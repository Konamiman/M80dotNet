namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The PUSH AF instruction.
        /// </summary>
        private void PUSH_AF()
        {
            var valueToPush = AF;
            var sp = (ushort)(SP - 1);
            Memory[sp] = valueToPush.GetHighByte();
            sp--;
            Memory[sp] = valueToPush.GetLowByte();
            SP = (short)sp;
        }

        /// <summary>
        /// The POP AF instruction.
        /// </summary>
        private void POP_AF()
        {
            var sp = (ushort)SP;
            var newAF = NumberUtils.CreateShort(
                Memory[sp],
                Memory[(ushort)(sp + 1)]);
            AF = newAF;

            SP += 2;
        }

        /// <summary>
        /// The PUSH BC instruction.
        /// </summary>
        private void PUSH_BC()
        {
            var valueToPush = BC;
            var sp = (ushort)(SP - 1);
            Memory[sp] = valueToPush.GetHighByte();
            sp--;
            Memory[sp] = valueToPush.GetLowByte();
            SP = (short)sp;
        }

        /// <summary>
        /// The POP BC instruction.
        /// </summary>
        private void POP_BC()
        {
            var sp = (ushort)SP;
            var newBC = NumberUtils.CreateShort(
                Memory[sp],
                Memory[(ushort)(sp + 1)]);
            BC = newBC;

            SP += 2;
        }

        /// <summary>
        /// The PUSH DE instruction.
        /// </summary>
        private void PUSH_DE()
        {
            var valueToPush = DE;
            var sp = (ushort)(SP - 1);
            Memory[sp] = valueToPush.GetHighByte();
            sp--;
            Memory[sp] = valueToPush.GetLowByte();
            SP = (short)sp;
        }

        /// <summary>
        /// The POP DE instruction.
        /// </summary>
        private void POP_DE()
        {
            var sp = (ushort)SP;
            var newDE = NumberUtils.CreateShort(
                Memory[sp],
                Memory[(ushort)(sp + 1)]);
            DE = newDE;

            SP += 2;
        }

        /// <summary>
        /// The PUSH HL instruction.
        /// </summary>
        private void PUSH_HL()
        {
            var valueToPush = HL;
            var sp = (ushort)(SP - 1);
            Memory[sp] = valueToPush.GetHighByte();
            sp--;
            Memory[sp] = valueToPush.GetLowByte();
            SP = (short)sp;
        }

        /// <summary>
        /// The POP HL instruction.
        /// </summary>
        private void POP_HL()
        {
            var sp = (ushort)SP;
            var newHL = NumberUtils.CreateShort(
                Memory[sp],
                Memory[(ushort)(sp + 1)]);
            HL = newHL;

            SP += 2;
        }

        /// <summary>
        /// The PUSH IX instruction.
        /// </summary>
        private void PUSH_IX()
        {
            var valueToPush = IX;
            var sp = (ushort)(SP - 1);
            Memory[sp] = valueToPush.GetHighByte();
            sp--;
            Memory[sp] = valueToPush.GetLowByte();
            SP = (short)sp;
        }

        /// <summary>
        /// The POP IX instruction.
        /// </summary>
        private void POP_IX()
        {
            var sp = (ushort)SP;
            var newIX = NumberUtils.CreateShort(
                Memory[sp],
                Memory[(ushort)(sp + 1)]);
            IX = newIX;

            SP += 2;
        }

        /// <summary>
        /// The PUSH IY instruction.
        /// </summary>
        private void PUSH_IY()
        {
            var valueToPush = IY;
            var sp = (ushort)(SP - 1);
            Memory[sp] = valueToPush.GetHighByte();
            sp--;
            Memory[sp] = valueToPush.GetLowByte();
            SP = (short)sp;
        }

        /// <summary>
        /// The POP IY instruction.
        /// </summary>
        private void POP_IY()
        {
            var sp = (ushort)SP;
            var newIY = NumberUtils.CreateShort(
                Memory[sp],
                Memory[(ushort)(sp + 1)]);
            IY = newIY;

            SP += 2;
        }
    }
}