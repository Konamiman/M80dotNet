using System;

namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The INC A instruction.
        /// </summary>
        private void INC_A()
        {
            var oldValue = A;
            var newValue = (byte)(oldValue + 1);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x00) ? 1 : 0;
            PF = (newValue == 0x80) ? 1 : 0;
            NF = 0;
        }

        /// <summary>
        /// The DEC A instruction.
        /// </summary>
        private void DEC_A()
        {
            var oldValue = A;
            var newValue = (byte)(oldValue - 1);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x0F) ? 1 : 0;
            PF = (newValue == 0x7F) ? 1 : 0;
            NF = 1;
        }

        /// <summary>
        /// The INC B instruction.
        /// </summary>
        private void INC_B()
        {
            var oldValue = B;
            var newValue = (byte)(oldValue + 1);
            B = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x00) ? 1 : 0;
            PF = (newValue == 0x80) ? 1 : 0;
            NF = 0;
        }

        /// <summary>
        /// The DEC B instruction.
        /// </summary>
        private void DEC_B()
        {
            var oldValue = B;
            var newValue = (byte)(oldValue - 1);
            B = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x0F) ? 1 : 0;
            PF = (newValue == 0x7F) ? 1 : 0;
            NF = 1;
        }

        /// <summary>
        /// The INC C instruction.
        /// </summary>
        private void INC_C()
        {
            var oldValue = C;
            var newValue = (byte)(oldValue + 1);
            C = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x00) ? 1 : 0;
            PF = (newValue == 0x80) ? 1 : 0;
            NF = 0;
        }

        /// <summary>
        /// The DEC C instruction.
        /// </summary>
        private void DEC_C()
        {
            var oldValue = C;
            var newValue = (byte)(oldValue - 1);
            C = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x0F) ? 1 : 0;
            PF = (newValue == 0x7F) ? 1 : 0;
            NF = 1;
        }

        /// <summary>
        /// The INC D instruction.
        /// </summary>
        private void INC_D()
        {
            var oldValue = D;
            var newValue = (byte)(oldValue + 1);
            D = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x00) ? 1 : 0;
            PF = (newValue == 0x80) ? 1 : 0;
            NF = 0;
        }

        /// <summary>
        /// The DEC D instruction.
        /// </summary>
        private void DEC_D()
        {
            var oldValue = D;
            var newValue = (byte)(oldValue - 1);
            D = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x0F) ? 1 : 0;
            PF = (newValue == 0x7F) ? 1 : 0;
            NF = 1;
        }

        /// <summary>
        /// The INC E instruction.
        /// </summary>
        private void INC_E()
        {
            var oldValue = E;
            var newValue = (byte)(oldValue + 1);
            E = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x00) ? 1 : 0;
            PF = (newValue == 0x80) ? 1 : 0;
            NF = 0;
        }

        /// <summary>
        /// The DEC E instruction.
        /// </summary>
        private void DEC_E()
        {
            var oldValue = E;
            var newValue = (byte)(oldValue - 1);
            E = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x0F) ? 1 : 0;
            PF = (newValue == 0x7F) ? 1 : 0;
            NF = 1;
        }

        /// <summary>
        /// The INC H instruction.
        /// </summary>
        private void INC_H()
        {
            var oldValue = H;
            var newValue = (byte)(oldValue + 1);
            H = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x00) ? 1 : 0;
            PF = (newValue == 0x80) ? 1 : 0;
            NF = 0;
        }

        /// <summary>
        /// The DEC H instruction.
        /// </summary>
        private void DEC_H()
        {
            var oldValue = H;
            var newValue = (byte)(oldValue - 1);
            H = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x0F) ? 1 : 0;
            PF = (newValue == 0x7F) ? 1 : 0;
            NF = 1;
        }

        /// <summary>
        /// The INC L instruction.
        /// </summary>
        private void INC_L()
        {
            var oldValue = L;
            var newValue = (byte)(oldValue + 1);
            L = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x00) ? 1 : 0;
            PF = (newValue == 0x80) ? 1 : 0;
            NF = 0;
        }

        /// <summary>
        /// The DEC L instruction.
        /// </summary>
        private void DEC_L()
        {
            var oldValue = L;
            var newValue = (byte)(oldValue - 1);
            L = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x0F) ? 1 : 0;
            PF = (newValue == 0x7F) ? 1 : 0;
            NF = 1;
        }

        /// <summary>
        /// The INC IXH instruction.
        /// </summary>
        private void INC_IXH()
        {
            var oldValue = IXH;
            var newValue = (byte)(oldValue + 1);
            IXH = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x00) ? 1 : 0;
            PF = (newValue == 0x80) ? 1 : 0;
            NF = 0;
        }

        /// <summary>
        /// The DEC IXH instruction.
        /// </summary>
        private void DEC_IXH()
        {
            var oldValue = IXH;
            var newValue = (byte)(oldValue - 1);
            IXH = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x0F) ? 1 : 0;
            PF = (newValue == 0x7F) ? 1 : 0;
            NF = 1;
        }

        /// <summary>
        /// The INC IXL instruction.
        /// </summary>
        private void INC_IXL()
        {
            var oldValue = IXL;
            var newValue = (byte)(oldValue + 1);
            IXL = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x00) ? 1 : 0;
            PF = (newValue == 0x80) ? 1 : 0;
            NF = 0;
        }

        /// <summary>
        /// The DEC IXL instruction.
        /// </summary>
        private void DEC_IXL()
        {
            var oldValue = IXL;
            var newValue = (byte)(oldValue - 1);
            IXL = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x0F) ? 1 : 0;
            PF = (newValue == 0x7F) ? 1 : 0;
            NF = 1;
        }

        /// <summary>
        /// The INC IYH instruction.
        /// </summary>
        private void INC_IYH()
        {
            var oldValue = IYH;
            var newValue = (byte)(oldValue + 1);
            IYH = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x00) ? 1 : 0;
            PF = (newValue == 0x80) ? 1 : 0;
            NF = 0;
        }

        /// <summary>
        /// The DEC IYH instruction.
        /// </summary>
        private void DEC_IYH()
        {
            var oldValue = IYH;
            var newValue = (byte)(oldValue - 1);
            IYH = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x0F) ? 1 : 0;
            PF = (newValue == 0x7F) ? 1 : 0;
            NF = 1;
        }

        /// <summary>
        /// The INC IYL instruction.
        /// </summary>
        private void INC_IYL()
        {
            var oldValue = IYL;
            var newValue = (byte)(oldValue + 1);
            IYL = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x00) ? 1 : 0;
            PF = (newValue == 0x80) ? 1 : 0;
            NF = 0;
        }

        /// <summary>
        /// The DEC IYL instruction.
        /// </summary>
        private void DEC_IYL()
        {
            var oldValue = IYL;
            var newValue = (byte)(oldValue - 1);
            IYL = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x0F) ? 1 : 0;
            PF = (newValue == 0x7F) ? 1 : 0;
            NF = 1;
        }

        /// <summary>
        /// The INC (HL) instruction.
        /// </summary>
        private void INC_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue + 1);
            Memory[address] = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x00) ? 1 : 0;
            PF = (newValue == 0x80) ? 1 : 0;
            NF = 0;
        }

        /// <summary>
        /// The DEC (HL) instruction.
        /// </summary>
        private void DEC_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue - 1);
            Memory[address] = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x0F) ? 1 : 0;
            PF = (newValue == 0x7F) ? 1 : 0;
            NF = 1;
        }

        /// <summary>
        /// The INC (IX+n) instruction.
        /// </summary>
        private void INC_aIX_plus_n()
        {
            var offset = Memory[PC++];
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue + 1);
            Memory[address] = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x00) ? 1 : 0;
            PF = (newValue == 0x80) ? 1 : 0;
            NF = 0;
        }

        /// <summary>
        /// The DEC (IX+n) instruction.
        /// </summary>
        private void DEC_aIX_plus_n()
        {
            var offset = Memory[PC++];
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue - 1);
            Memory[address] = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x0F) ? 1 : 0;
            PF = (newValue == 0x7F) ? 1 : 0;
            NF = 1;
        }

        /// <summary>
        /// The INC (IY+n) instruction.
        /// </summary>
        private void INC_aIY_plus_n()
        {
            var offset = Memory[PC++];
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue + 1);
            Memory[address] = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x00) ? 1 : 0;
            PF = (newValue == 0x80) ? 1 : 0;
            NF = 0;
        }

        /// <summary>
        /// The DEC (IY+n) instruction.
        /// </summary>
        private void DEC_aIY_plus_n()
        {
            var offset = Memory[PC++];
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue - 1);
            Memory[address] = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = ((newValue & 0x0F) == 0x0F) ? 1 : 0;
            PF = (newValue == 0x7F) ? 1 : 0;
            NF = 1;
        }
    }
}