namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The RET instruction.
        /// </summary>
        private void RET()
        {
            var sp = (ushort)SP;
            var newPC = NumberUtils.CreateShort(
                Memory[sp],
                Memory[(ushort)(sp + 1)]);
            PC = (ushort)newPC;

            SP += 2;
        }

        /// <summary>
        /// The RETI instruction.
        /// </summary>
        private void RETI()
        {
            var sp = (ushort)SP;
            var newPC = NumberUtils.CreateShort(
                Memory[sp],
                Memory[(ushort)(sp + 1)]);
            PC = (ushort)newPC;

            SP += 2;
        }

        /// <summary>
        /// The JP instruction.
        /// </summary>
        private void JP_nn()
        {
            var newAddress = (ushort)FetchWord();

            PC = newAddress;
        }

        /// <summary>
        /// The CALL instruction.
        /// </summary>
        private void CALL_nn()
        {
            var newAddress = (ushort)FetchWord();

            var valueToPush = (short)PC;
            var sp = (ushort)(SP - 1);
            Memory[sp] = valueToPush.GetHighByte();
            sp--;
            Memory[sp] = valueToPush.GetLowByte();
            SP = (short)sp;
            PC = newAddress;
        }

        /// <summary>
        /// The RET C instruction.
        /// </summary>
        private void RET_C()
        {
            if (CF == 0)
            {
                return;
            }

            var sp = (ushort)SP;
            var newPC = NumberUtils.CreateShort(
                Memory[sp],
                Memory[(ushort)(sp + 1)]);
            PC = (ushort)newPC;

            SP += 2;
        }

        /// <summary>
        /// The JP C instruction.
        /// </summary>
        private void JP_C_nn()
        {
            var newAddress = (ushort)FetchWord();

            if (CF == 0)
                return;

            PC = newAddress;
        }

        /// <summary>
        /// The CALL C instruction.
        /// </summary>
        private void CALL_C_nn()
        {
            var newAddress = (ushort)FetchWord();

            if (CF == 0)
                return;

            var valueToPush = (short)PC;
            var sp = (ushort)(SP - 1);
            Memory[sp] = valueToPush.GetHighByte();
            sp--;
            Memory[sp] = valueToPush.GetLowByte();
            SP = (short)sp;
            PC = newAddress;
        }

        /// <summary>
        /// The RET NC instruction.
        /// </summary>
        private void RET_NC()
        {
            if (CF == 1)
            {
                return;
            }

            var sp = (ushort)SP;
            var newPC = NumberUtils.CreateShort(
                Memory[sp],
                Memory[(ushort)(sp + 1)]);
            PC = (ushort)newPC;

            SP += 2;
        }

        /// <summary>
        /// The JP NC instruction.
        /// </summary>
        private void JP_NC_nn()
        {
            var newAddress = (ushort)FetchWord();

            if (CF == 1)
                return;

            PC = newAddress;
        }

        /// <summary>
        /// The CALL NC instruction.
        /// </summary>
        private void CALL_NC_nn()
        {
            var newAddress = (ushort)FetchWord();

            if (CF == 1)
                return;

            var valueToPush = (short)PC;
            var sp = (ushort)(SP - 1);
            Memory[sp] = valueToPush.GetHighByte();
            sp--;
            Memory[sp] = valueToPush.GetLowByte();
            SP = (short)sp;
            PC = newAddress;
        }

        /// <summary>
        /// The RET Z instruction.
        /// </summary>
        private void RET_Z()
        {
            if (ZF == 0)
            {
                return;
            }

            var sp = (ushort)SP;
            var newPC = NumberUtils.CreateShort(
                Memory[sp],
                Memory[(ushort)(sp + 1)]);
            PC = (ushort)newPC;

            SP += 2;
        }

        /// <summary>
        /// The JP Z instruction.
        /// </summary>
        private void JP_Z_nn()
        {
            var newAddress = (ushort)FetchWord();

            if (ZF == 0)
                return;

            PC = newAddress;
        }

        /// <summary>
        /// The CALL Z instruction.
        /// </summary>
        private void CALL_Z_nn()
        {
            var newAddress = (ushort)FetchWord();

            if (ZF == 0)
                return;

            var valueToPush = (short)PC;
            var sp = (ushort)(SP - 1);
            Memory[sp] = valueToPush.GetHighByte();
            sp--;
            Memory[sp] = valueToPush.GetLowByte();
            SP = (short)sp;
            PC = newAddress;
        }

        /// <summary>
        /// The RET NZ instruction.
        /// </summary>
        private void RET_NZ()
        {
            if (ZF == 1)
            {
                return;
            }

            var sp = (ushort)SP;
            var newPC = NumberUtils.CreateShort(
                Memory[sp],
                Memory[(ushort)(sp + 1)]);
            PC = (ushort)newPC;

            SP += 2;
        }

        /// <summary>
        /// The JP NZ instruction.
        /// </summary>
        private void JP_NZ_nn()
        {
            var newAddress = (ushort)FetchWord();

            if (ZF == 1)
                return;

            PC = newAddress;
        }

        /// <summary>
        /// The CALL NZ instruction.
        /// </summary>
        private void CALL_NZ_nn()
        {
            var newAddress = (ushort)FetchWord();

            if (ZF == 1)
                return;

            var valueToPush = (short)PC;
            var sp = (ushort)(SP - 1);
            Memory[sp] = valueToPush.GetHighByte();
            sp--;
            Memory[sp] = valueToPush.GetLowByte();
            SP = (short)sp;
            PC = newAddress;
        }

        /// <summary>
        /// The RET PE instruction.
        /// </summary>
        private void RET_PE()
        {
            if (PF == 0)
            {
                return;
            }

            var sp = (ushort)SP;
            var newPC = NumberUtils.CreateShort(
                Memory[sp],
                Memory[(ushort)(sp + 1)]);
            PC = (ushort)newPC;

            SP += 2;
        }

        /// <summary>
        /// The JP PE instruction.
        /// </summary>
        private void JP_PE_nn()
        {
            var newAddress = (ushort)FetchWord();

            if (PF == 0)
                return;

            PC = newAddress;
        }

        /// <summary>
        /// The CALL PE instruction.
        /// </summary>
        private void CALL_PE_nn()
        {
            var newAddress = (ushort)FetchWord();

            if (PF == 0)
                return;

            var valueToPush = (short)PC;
            var sp = (ushort)(SP - 1);
            Memory[sp] = valueToPush.GetHighByte();
            sp--;
            Memory[sp] = valueToPush.GetLowByte();
            SP = (short)sp;
            PC = newAddress;
        }

        /// <summary>
        /// The RET PO instruction.
        /// </summary>
        private void RET_PO()
        {
            if (PF == 1)
            {
                return;
            }

            var sp = (ushort)SP;
            var newPC = NumberUtils.CreateShort(
                Memory[sp],
                Memory[(ushort)(sp + 1)]);
            PC = (ushort)newPC;

            SP += 2;
        }

        /// <summary>
        /// The JP PO instruction.
        /// </summary>
        private void JP_PO_nn()
        {
            var newAddress = (ushort)FetchWord();

            if (PF == 1)
                return;

            PC = newAddress;
        }

        /// <summary>
        /// The CALL PO instruction.
        /// </summary>
        private void CALL_PO_nn()
        {
            var newAddress = (ushort)FetchWord();

            if (PF == 1)
                return;

            var valueToPush = (short)PC;
            var sp = (ushort)(SP - 1);
            Memory[sp] = valueToPush.GetHighByte();
            sp--;
            Memory[sp] = valueToPush.GetLowByte();
            SP = (short)sp;
            PC = newAddress;
        }

        /// <summary>
        /// The RET M instruction.
        /// </summary>
        private void RET_M()
        {
            if (SF == 0)
            {
                return;
            }

            var sp = (ushort)SP;
            var newPC = NumberUtils.CreateShort(
                Memory[sp],
                Memory[(ushort)(sp + 1)]);
            PC = (ushort)newPC;

            SP += 2;
        }

        /// <summary>
        /// The JP M instruction.
        /// </summary>
        private void JP_M_nn()
        {
            var newAddress = (ushort)FetchWord();

            if (SF == 0)
                return;

            PC = newAddress;
        }

        /// <summary>
        /// The CALL M instruction.
        /// </summary>
        private void CALL_M_nn()
        {
            var newAddress = (ushort)FetchWord();

            if (SF == 0)
                return;

            var valueToPush = (short)PC;
            var sp = (ushort)(SP - 1);
            Memory[sp] = valueToPush.GetHighByte();
            sp--;
            Memory[sp] = valueToPush.GetLowByte();
            SP = (short)sp;
            PC = newAddress;
        }

        /// <summary>
        /// The RET P instruction.
        /// </summary>
        private void RET_P()
        {
            if (SF == 1)
            {
                return;
            }

            var sp = (ushort)SP;
            var newPC = NumberUtils.CreateShort(
                Memory[sp],
                Memory[(ushort)(sp + 1)]);
            PC = (ushort)newPC;

            SP += 2;
        }

        /// <summary>
        /// The JP P instruction.
        /// </summary>
        private void JP_P_nn()
        {
            var newAddress = (ushort)FetchWord();

            if (SF == 1)
                return;

            PC = newAddress;
        }

        /// <summary>
        /// The CALL P instruction.
        /// </summary>
        private void CALL_P_nn()
        {
            var newAddress = (ushort)FetchWord();

            if (SF == 1)
                return;

            var valueToPush = (short)PC;
            var sp = (ushort)(SP - 1);
            Memory[sp] = valueToPush.GetHighByte();
            sp--;
            Memory[sp] = valueToPush.GetLowByte();
            SP = (short)sp;
            PC = newAddress;
        }
    }
}