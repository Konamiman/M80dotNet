namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The RST 00h instruction.
        /// </summary>
        private void RST_00()
        {
            var valueToPush = (short)PC;
            var sp = (ushort)(SP - 1);
            Memory[sp] = valueToPush.GetHighByte();
            sp--;
            Memory[sp] = valueToPush.GetLowByte();
            SP = (short)sp;
            PC = 0x00;
        }

        /// <summary>
        /// The RST 08h instruction.
        /// </summary>
        private void RST_08()
        {
            var valueToPush = (short)PC;
            var sp = (ushort)(SP - 1);
            Memory[sp] = valueToPush.GetHighByte();
            sp--;
            Memory[sp] = valueToPush.GetLowByte();
            SP = (short)sp;
            PC = 0x08;
        }

        /// <summary>
        /// The RST 10h instruction.
        /// </summary>
        private void RST_10()
        {
            var valueToPush = (short)PC;
            var sp = (ushort)(SP - 1);
            Memory[sp] = valueToPush.GetHighByte();
            sp--;
            Memory[sp] = valueToPush.GetLowByte();
            SP = (short)sp;
            PC = 0x10;
        }

        /// <summary>
        /// The RST 18h instruction.
        /// </summary>
        private void RST_18()
        {
            var valueToPush = (short)PC;
            var sp = (ushort)(SP - 1);
            Memory[sp] = valueToPush.GetHighByte();
            sp--;
            Memory[sp] = valueToPush.GetLowByte();
            SP = (short)sp;
            PC = 0x18;
        }

        /// <summary>
        /// The RST 20h instruction.
        /// </summary>
        private void RST_20()
        {
            var valueToPush = (short)PC;
            var sp = (ushort)(SP - 1);
            Memory[sp] = valueToPush.GetHighByte();
            sp--;
            Memory[sp] = valueToPush.GetLowByte();
            SP = (short)sp;
            PC = 0x20;
        }

        /// <summary>
        /// The RST 28h instruction.
        /// </summary>
        private void RST_28()
        {
            var valueToPush = (short)PC;
            var sp = (ushort)(SP - 1);
            Memory[sp] = valueToPush.GetHighByte();
            sp--;
            Memory[sp] = valueToPush.GetLowByte();
            SP = (short)sp;
            PC = 0x28;
        }

        /// <summary>
        /// The RST 30h instruction.
        /// </summary>
        private void RST_30()
        {
            var valueToPush = (short)PC;
            var sp = (ushort)(SP - 1);
            Memory[sp] = valueToPush.GetHighByte();
            sp--;
            Memory[sp] = valueToPush.GetLowByte();
            SP = (short)sp;
            PC = 0x30;
        }

        /// <summary>
        /// The RST 38h instruction.
        /// </summary>
        private void RST_38()
        {
            var valueToPush = (short)PC;
            var sp = (ushort)(SP - 1);
            Memory[sp] = valueToPush.GetHighByte();
            sp--;
            Memory[sp] = valueToPush.GetLowByte();
            SP = (short)sp;
            PC = 0x38;
        }
    }
}