namespace Konamiman.M80dotNet
{
    /// <summary>
    /// Z80 instructions execution main code and auxiliary methods.
    /// </summary>
    public partial class Z80Processor
    {
        private void InitializeInstructionTables()
        {
            Initialize_CB_InstructionsTable();
            Initialize_DD_InstructionsTable();
            Initialize_DDCB_InstructionsTable();
            Initialize_ED_InstructionsTable();
            Initialize_FD_InstructionsTable();
            Initialize_FDCB_InstructionsTable();
            Initialize_SingleByte_InstructionsTable();
            GenerateParityTable();
        }

        public void Execute(byte firstOpcodeByte)
        {
            switch (firstOpcodeByte)
            {
                case 0xCB:
                    CB_InstructionExecutors[Memory[PC++]]();
                    break;
                case 0xED:
                    ED_InstructionExecutors[Memory[PC++]]();
                    break;
                case 0xDD:
                    Execute_DD_Instruction();
                    break;
                case 0xFD:
                    Execute_FD_Instruction();
                    break;
            }
            SingleByte_InstructionExecutors[firstOpcodeByte]();
        }

        private short FetchWord()
        {
            return NumberUtils.CreateShort(
                lowByte: Memory[PC++],
                highByte: Memory[PC++]);
        }

        private void WriteShortToMemory(ushort address, short value)
        {
            Memory[address] = value.GetLowByte();
            Memory[(ushort)(address + 1)] = value.GetHighByte();
        }

        private short ReadShortFromMemory(ushort address)
        {
            return NumberUtils.CreateShort(
               Memory[address],
               Memory[(ushort)(address + 1)]);
        }
    }
}
