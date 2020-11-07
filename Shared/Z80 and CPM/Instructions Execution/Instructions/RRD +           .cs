namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The RRD instruction.
        /// </summary>
        void RRD()
        {
            var memoryAddress = (ushort)HL;

            var Avalue = A;
            var HLcontents = Memory[memoryAddress];

            var newAvalue = (byte)((Avalue & 0xF0) | (HLcontents & 0x0F));
            var newHLcontents = (byte)(((HLcontents >> 4) & 0x0F) | ((Avalue << 4) & 0xF0));
            A = newAvalue;
            Memory[memoryAddress] = newHLcontents;

            SF = newAvalue.GetBit(7);
            ZF = (newAvalue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newAvalue];
            NF = 0;
        }

        /// <summary>
        /// The RLD instruction.
        /// </summary>
        void RLD()
        {
            var memoryAddress = (ushort)HL;

            var Avalue = A;
            var HLcontents = Memory[memoryAddress];

            var newAvalue = (byte)((Avalue & 0xF0) | ((HLcontents >> 4) & 0x0F));
            var newHLcontents = (byte)(((HLcontents << 4) & 0xF0) | (Avalue & 0x0F));
            A = newAvalue;
            Memory[memoryAddress] = newHLcontents;

            SF = newAvalue.GetBit(7);
            ZF = (newAvalue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newAvalue];
            NF = 0;
        }
    }
}
