using System;

namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// The AND A instruction.
		/// </summary>
		private void AND_A()
        {
            var oldValue = A;
            var argument = A;
            var newValue = (byte)(oldValue & argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 1;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The XOR A instruction.
		/// </summary>
		private void XOR_A()
        {
            var oldValue = A;
            var argument = A;
            var newValue = (byte)(oldValue ^ argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The OR A instruction.
		/// </summary>
		private void OR_A()
        {
            var oldValue = A;
            var argument = A;
            var newValue = (byte)(oldValue | argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The AND B instruction.
		/// </summary>
		private void AND_B()
        {
            var oldValue = A;
            var argument = B;
            var newValue = (byte)(oldValue & argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 1;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The XOR B instruction.
		/// </summary>
		private void XOR_B()
        {
            var oldValue = A;
            var argument = B;
            var newValue = (byte)(oldValue ^ argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The OR B instruction.
		/// </summary>
		private void OR_B()
        {
            var oldValue = A;
            var argument = B;
            var newValue = (byte)(oldValue | argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The AND C instruction.
		/// </summary>
		private void AND_C()
        {
            var oldValue = A;
            var argument = C;
            var newValue = (byte)(oldValue & argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 1;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The XOR C instruction.
		/// </summary>
		private void XOR_C()
        {
            var oldValue = A;
            var argument = C;
            var newValue = (byte)(oldValue ^ argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The OR C instruction.
		/// </summary>
		private void OR_C()
        {
            var oldValue = A;
            var argument = C;
            var newValue = (byte)(oldValue | argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The AND D instruction.
		/// </summary>
		private void AND_D()
        {
            var oldValue = A;
            var argument = D;
            var newValue = (byte)(oldValue & argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 1;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The XOR D instruction.
		/// </summary>
		private void XOR_D()
        {
            var oldValue = A;
            var argument = D;
            var newValue = (byte)(oldValue ^ argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The OR D instruction.
		/// </summary>
		private void OR_D()
        {
            var oldValue = A;
            var argument = D;
            var newValue = (byte)(oldValue | argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The AND E instruction.
		/// </summary>
		private void AND_E()
        {
            var oldValue = A;
            var argument = E;
            var newValue = (byte)(oldValue & argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 1;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The XOR E instruction.
		/// </summary>
		private void XOR_E()
        {
            var oldValue = A;
            var argument = E;
            var newValue = (byte)(oldValue ^ argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The OR E instruction.
		/// </summary>
		private void OR_E()
        {
            var oldValue = A;
            var argument = E;
            var newValue = (byte)(oldValue | argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The AND H instruction.
		/// </summary>
		private void AND_H()
        {
            var oldValue = A;
            var argument = H;
            var newValue = (byte)(oldValue & argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 1;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The XOR H instruction.
		/// </summary>
		private void XOR_H()
        {
            var oldValue = A;
            var argument = H;
            var newValue = (byte)(oldValue ^ argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The OR H instruction.
		/// </summary>
		private void OR_H()
        {
            var oldValue = A;
            var argument = H;
            var newValue = (byte)(oldValue | argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The AND L instruction.
		/// </summary>
		private void AND_L()
        {
            var oldValue = A;
            var argument = L;
            var newValue = (byte)(oldValue & argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 1;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The XOR L instruction.
		/// </summary>
		private void XOR_L()
        {
            var oldValue = A;
            var argument = L;
            var newValue = (byte)(oldValue ^ argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The OR L instruction.
		/// </summary>
		private void OR_L()
        {
            var oldValue = A;
            var argument = L;
            var newValue = (byte)(oldValue | argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The AND (HL) instruction.
		/// </summary>
		private void AND_aHL()
        {
            var oldValue = A;
            var address = (ushort)HL;
            var argument = Memory[address];
            var newValue = (byte)(oldValue & argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 1;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The XOR (HL) instruction.
		/// </summary>
		private void XOR_aHL()
        {
            var oldValue = A;
            var address = (ushort)HL;
            var argument = Memory[address];
            var newValue = (byte)(oldValue ^ argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The OR (HL) instruction.
		/// </summary>
		private void OR_aHL()
        {
            var oldValue = A;
            var address = (ushort)HL;
            var argument = Memory[address];
            var newValue = (byte)(oldValue | argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The AND n instruction.
		/// </summary>
		private void AND_n()
        {
            var argument = Memory[PC++];
            var oldValue = A;
            var newValue = (byte)(oldValue & argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 1;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The XOR n instruction.
		/// </summary>
		private void XOR_n()
        {
            var argument = Memory[PC++];
            var oldValue = A;
            var newValue = (byte)(oldValue ^ argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The OR n instruction.
		/// </summary>
		private void OR_n()
        {
            var argument = Memory[PC++];
            var oldValue = A;
            var newValue = (byte)(oldValue | argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The AND IXH instruction.
		/// </summary>
		private void AND_IXH()
        {
            var oldValue = A;
            var argument = IXH;
            var newValue = (byte)(oldValue & argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 1;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The XOR IXH instruction.
		/// </summary>
		private void XOR_IXH()
        {
            var oldValue = A;
            var argument = IXH;
            var newValue = (byte)(oldValue ^ argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The OR IXH instruction.
		/// </summary>
		private void OR_IXH()
        {
            var oldValue = A;
            var argument = IXH;
            var newValue = (byte)(oldValue | argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The AND IXL instruction.
		/// </summary>
		private void AND_IXL()
        {
            var oldValue = A;
            var argument = IXL;
            var newValue = (byte)(oldValue & argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 1;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The XOR IXL instruction.
		/// </summary>
		private void XOR_IXL()
        {
            var oldValue = A;
            var argument = IXL;
            var newValue = (byte)(oldValue ^ argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The OR IXL instruction.
		/// </summary>
		private void OR_IXL()
        {
            var oldValue = A;
            var argument = IXL;
            var newValue = (byte)(oldValue | argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The AND IYH instruction.
		/// </summary>
		private void AND_IYH()
        {
            var oldValue = A;
            var argument = IYH;
            var newValue = (byte)(oldValue & argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 1;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The XOR IYH instruction.
		/// </summary>
		private void XOR_IYH()
        {
            var oldValue = A;
            var argument = IYH;
            var newValue = (byte)(oldValue ^ argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The OR IYH instruction.
		/// </summary>
		private void OR_IYH()
        {
            var oldValue = A;
            var argument = IYH;
            var newValue = (byte)(oldValue | argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The AND IYL instruction.
		/// </summary>
		private void AND_IYL()
        {
            var oldValue = A;
            var argument = IYL;
            var newValue = (byte)(oldValue & argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 1;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The XOR IYL instruction.
		/// </summary>
		private void XOR_IYL()
        {
            var oldValue = A;
            var argument = IYL;
            var newValue = (byte)(oldValue ^ argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The OR IYL instruction.
		/// </summary>
		private void OR_IYL()
        {
            var oldValue = A;
            var argument = IYL;
            var newValue = (byte)(oldValue | argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The AND (IX+n) instruction.
		/// </summary>
		private void AND_aIX_plus_n()
        {
            var offset = Memory[PC++];
            var oldValue = A;
            var address = (ushort)(IX + (SByte)offset);
            var argument = Memory[address];
            var newValue = (byte)(oldValue & argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 1;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The XOR (IX+n) instruction.
		/// </summary>
		private void XOR_aIX_plus_n()
        {
            var offset = Memory[PC++];
            var oldValue = A;
            var address = (ushort)(IX + (SByte)offset);
            var argument = Memory[address];
            var newValue = (byte)(oldValue ^ argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The OR (IX+n) instruction.
		/// </summary>
		private void OR_aIX_plus_n()
        {
            var offset = Memory[PC++];
            var oldValue = A;
            var address = (ushort)(IX + (SByte)offset);
            var argument = Memory[address];
            var newValue = (byte)(oldValue | argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The AND (IY+n) instruction.
		/// </summary>
		private void AND_aIY_plus_n()
        {
            var offset = Memory[PC++];
            var oldValue = A;
            var address = (ushort)(IY + (SByte)offset);
            var argument = Memory[address];
            var newValue = (byte)(oldValue & argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 1;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The XOR (IY+n) instruction.
		/// </summary>
		private void XOR_aIY_plus_n()
        {
            var offset = Memory[PC++];
            var oldValue = A;
            var address = (ushort)(IY + (SByte)offset);
            var argument = Memory[address];
            var newValue = (byte)(oldValue ^ argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }

        /// The OR (IY+n) instruction.
		/// </summary>
		private void OR_aIY_plus_n()
        {
            var offset = Memory[PC++];
            var oldValue = A;
            var address = (ushort)(IY + (SByte)offset);
            var argument = Memory[address];
            var newValue = (byte)(oldValue | argument);
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = 0;
            PF = Parity[newValue];
            NF = 0;
            CF = 0;
        }
    }
}