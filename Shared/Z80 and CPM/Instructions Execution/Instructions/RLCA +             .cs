using System;

namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The RLC A instruction
        /// </summary>
        void RLC_A()
        {
            var oldValue = A;
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            A = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RLC B instruction
        /// </summary>
        void RLC_B()
        {
            var oldValue = B;
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            B = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RLC C instruction
        /// </summary>
        void RLC_C()
        {
            var oldValue = C;
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            C = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RLC D instruction
        /// </summary>
        void RLC_D()
        {
            var oldValue = D;
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            D = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RLC E instruction
        /// </summary>
        void RLC_E()
        {
            var oldValue = E;
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            E = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RLC H instruction
        /// </summary>
        void RLC_H()
        {
            var oldValue = H;
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            H = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RLC L instruction
        /// </summary>
        void RLC_L()
        {
            var oldValue = L;
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            L = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RLC (HL) instruction
        /// </summary>
        void RLC_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Memory[address] = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RLCA instruction
        /// </summary>
        void RLCA()
        {
            var oldValue = A;
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            A = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
        }

        /// <summary>
        /// The RLC (IX+n),A instruction
        /// </summary>
        void RLC_aIX_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Memory[address] = newValue;
            A = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RLC (IX+n),B instruction
        /// </summary>
        void RLC_aIX_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Memory[address] = newValue;
            B = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RLC (IX+n),C instruction
        /// </summary>
        void RLC_aIX_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Memory[address] = newValue;
            C = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RLC (IX+n),D instruction
        /// </summary>
        void RLC_aIX_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Memory[address] = newValue;
            D = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RLC (IX+n),E instruction
        /// </summary>
        void RLC_aIX_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Memory[address] = newValue;
            E = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RLC (IX+n),H instruction
        /// </summary>
        void RLC_aIX_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Memory[address] = newValue;
            H = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RLC (IX+n),L instruction
        /// </summary>
        void RLC_aIX_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Memory[address] = newValue;
            L = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RLC (IX+n) instruction
        /// </summary>
        void RLC_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Memory[address] = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RLC (IY+n),A instruction
        /// </summary>
        void RLC_aIY_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Memory[address] = newValue;
            A = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RLC (IY+n),B instruction
        /// </summary>
        void RLC_aIY_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Memory[address] = newValue;
            B = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RLC (IY+n),C instruction
        /// </summary>
        void RLC_aIY_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Memory[address] = newValue;
            C = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RLC (IY+n),D instruction
        /// </summary>
        void RLC_aIY_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Memory[address] = newValue;
            D = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RLC (IY+n),E instruction
        /// </summary>
        void RLC_aIY_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Memory[address] = newValue;
            E = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RLC (IY+n),H instruction
        /// </summary>
        void RLC_aIY_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Memory[address] = newValue;
            H = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RLC (IY+n),L instruction
        /// </summary>
        void RLC_aIY_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Memory[address] = newValue;
            L = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RLC (IY+n) instruction
        /// </summary>
        void RLC_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Memory[address] = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRC A instruction
        /// </summary>
        void RRC_A()
        {
            var oldValue = A;
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            A = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRC B instruction
        /// </summary>
        void RRC_B()
        {
            var oldValue = B;
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            B = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRC C instruction
        /// </summary>
        void RRC_C()
        {
            var oldValue = C;
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            C = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRC D instruction
        /// </summary>
        void RRC_D()
        {
            var oldValue = D;
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            D = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRC E instruction
        /// </summary>
        void RRC_E()
        {
            var oldValue = E;
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            E = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRC H instruction
        /// </summary>
        void RRC_H()
        {
            var oldValue = H;
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            H = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRC L instruction
        /// </summary>
        void RRC_L()
        {
            var oldValue = L;
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            L = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRC (HL) instruction
        /// </summary>
        void RRC_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            Memory[address] = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRCA instruction
        /// </summary>
        void RRCA()
        {
            var oldValue = A;
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            A = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
        }

        /// <summary>
        /// The RRC (IX+n),A instruction
        /// </summary>
        void RRC_aIX_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            Memory[address] = newValue;
            A = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRC (IX+n),B instruction
        /// </summary>
        void RRC_aIX_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            Memory[address] = newValue;
            B = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRC (IX+n),C instruction
        /// </summary>
        void RRC_aIX_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            Memory[address] = newValue;
            C = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRC (IX+n),D instruction
        /// </summary>
        void RRC_aIX_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            Memory[address] = newValue;
            D = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRC (IX+n),E instruction
        /// </summary>
        void RRC_aIX_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            Memory[address] = newValue;
            E = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRC (IX+n),H instruction
        /// </summary>
        void RRC_aIX_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            Memory[address] = newValue;
            H = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRC (IX+n),L instruction
        /// </summary>
        void RRC_aIX_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            Memory[address] = newValue;
            L = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRC (IX+n) instruction
        /// </summary>
        void RRC_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            Memory[address] = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRC (IY+n),A instruction
        /// </summary>
        void RRC_aIY_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            Memory[address] = newValue;
            A = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRC (IY+n),B instruction
        /// </summary>
        void RRC_aIY_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            Memory[address] = newValue;
            B = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRC (IY+n),C instruction
        /// </summary>
        void RRC_aIY_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            Memory[address] = newValue;
            C = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRC (IY+n),D instruction
        /// </summary>
        void RRC_aIY_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            Memory[address] = newValue;
            D = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRC (IY+n),E instruction
        /// </summary>
        void RRC_aIY_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            Memory[address] = newValue;
            E = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRC (IY+n),H instruction
        /// </summary>
        void RRC_aIY_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            Memory[address] = newValue;
            H = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRC (IY+n),L instruction
        /// </summary>
        void RRC_aIY_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            Memory[address] = newValue;
            L = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRC (IY+n) instruction
        /// </summary>
        void RRC_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
            Memory[address] = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RL A instruction
        /// </summary>
        void RL_A()
        {
            var oldValue = A;
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            A = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RL B instruction
        /// </summary>
        void RL_B()
        {
            var oldValue = B;
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            B = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RL C instruction
        /// </summary>
        void RL_C()
        {
            var oldValue = C;
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            C = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RL D instruction
        /// </summary>
        void RL_D()
        {
            var oldValue = D;
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            D = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RL E instruction
        /// </summary>
        void RL_E()
        {
            var oldValue = E;
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            E = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RL H instruction
        /// </summary>
        void RL_H()
        {
            var oldValue = H;
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            H = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RL L instruction
        /// </summary>
        void RL_L()
        {
            var oldValue = L;
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            L = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RL (HL) instruction
        /// </summary>
        void RL_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            Memory[address] = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RLA instruction
        /// </summary>
        void RLA()
        {
            var oldValue = A;
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            A = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
        }

        /// <summary>
        /// The RL (IX+n),A instruction
        /// </summary>
        void RL_aIX_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            Memory[address] = newValue;
            A = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RL (IX+n),B instruction
        /// </summary>
        void RL_aIX_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            Memory[address] = newValue;
            B = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RL (IX+n),C instruction
        /// </summary>
        void RL_aIX_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            Memory[address] = newValue;
            C = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RL (IX+n),D instruction
        /// </summary>
        void RL_aIX_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            Memory[address] = newValue;
            D = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RL (IX+n),E instruction
        /// </summary>
        void RL_aIX_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            Memory[address] = newValue;
            E = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RL (IX+n),H instruction
        /// </summary>
        void RL_aIX_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            Memory[address] = newValue;
            H = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RL (IX+n),L instruction
        /// </summary>
        void RL_aIX_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            Memory[address] = newValue;
            L = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RL (IX+n) instruction
        /// </summary>
        void RL_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            Memory[address] = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RL (IY+n),A instruction
        /// </summary>
        void RL_aIY_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            Memory[address] = newValue;
            A = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RL (IY+n),B instruction
        /// </summary>
        void RL_aIY_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            Memory[address] = newValue;
            B = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RL (IY+n),C instruction
        /// </summary>
        void RL_aIY_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            Memory[address] = newValue;
            C = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RL (IY+n),D instruction
        /// </summary>
        void RL_aIY_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            Memory[address] = newValue;
            D = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RL (IY+n),E instruction
        /// </summary>
        void RL_aIY_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            Memory[address] = newValue;
            E = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RL (IY+n),H instruction
        /// </summary>
        void RL_aIY_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            Memory[address] = newValue;
            H = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RL (IY+n),L instruction
        /// </summary>
        void RL_aIY_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            Memory[address] = newValue;
            L = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RL (IY+n) instruction
        /// </summary>
        void RL_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | (byte)CF);
            Memory[address] = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RR A instruction
        /// </summary>
        void RR_A()
        {
            var oldValue = A;
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            A = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RR B instruction
        /// </summary>
        void RR_B()
        {
            var oldValue = B;
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            B = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RR C instruction
        /// </summary>
        void RR_C()
        {
            var oldValue = C;
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            C = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RR D instruction
        /// </summary>
        void RR_D()
        {
            var oldValue = D;
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            D = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RR E instruction
        /// </summary>
        void RR_E()
        {
            var oldValue = E;
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            E = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RR H instruction
        /// </summary>
        void RR_H()
        {
            var oldValue = H;
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            H = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RR L instruction
        /// </summary>
        void RR_L()
        {
            var oldValue = L;
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            L = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RR (HL) instruction
        /// </summary>
        void RR_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            Memory[address] = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RRA instruction
        /// </summary>
        void RRA()
        {
            var oldValue = A;
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            A = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
        }

        /// <summary>
        /// The RR (IX+n),A instruction
        /// </summary>
        void RR_aIX_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            Memory[address] = newValue;
            A = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RR (IX+n),B instruction
        /// </summary>
        void RR_aIX_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            Memory[address] = newValue;
            B = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RR (IX+n),C instruction
        /// </summary>
        void RR_aIX_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            Memory[address] = newValue;
            C = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RR (IX+n),D instruction
        /// </summary>
        void RR_aIX_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            Memory[address] = newValue;
            D = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RR (IX+n),E instruction
        /// </summary>
        void RR_aIX_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            Memory[address] = newValue;
            E = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RR (IX+n),H instruction
        /// </summary>
        void RR_aIX_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            Memory[address] = newValue;
            H = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RR (IX+n),L instruction
        /// </summary>
        void RR_aIX_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            Memory[address] = newValue;
            L = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RR (IX+n) instruction
        /// </summary>
        void RR_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            Memory[address] = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RR (IY+n),A instruction
        /// </summary>
        void RR_aIY_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            Memory[address] = newValue;
            A = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RR (IY+n),B instruction
        /// </summary>
        void RR_aIY_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            Memory[address] = newValue;
            B = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RR (IY+n),C instruction
        /// </summary>
        void RR_aIY_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            Memory[address] = newValue;
            C = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RR (IY+n),D instruction
        /// </summary>
        void RR_aIY_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            Memory[address] = newValue;
            D = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RR (IY+n),E instruction
        /// </summary>
        void RR_aIY_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            Memory[address] = newValue;
            E = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RR (IY+n),H instruction
        /// </summary>
        void RR_aIY_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            Memory[address] = newValue;
            H = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RR (IY+n),L instruction
        /// </summary>
        void RR_aIY_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            Memory[address] = newValue;
            L = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The RR (IY+n) instruction
        /// </summary>
        void RR_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (CF == 1 ? 0x80 : 0));
            Memory[address] = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLA A instruction
        /// </summary>
        void SLA_A()
        {
            var oldValue = A;
            var newValue = (byte)(oldValue << 1);
            A = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLA B instruction
        /// </summary>
        void SLA_B()
        {
            var oldValue = B;
            var newValue = (byte)(oldValue << 1);
            B = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLA C instruction
        /// </summary>
        void SLA_C()
        {
            var oldValue = C;
            var newValue = (byte)(oldValue << 1);
            C = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLA D instruction
        /// </summary>
        void SLA_D()
        {
            var oldValue = D;
            var newValue = (byte)(oldValue << 1);
            D = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLA E instruction
        /// </summary>
        void SLA_E()
        {
            var oldValue = E;
            var newValue = (byte)(oldValue << 1);
            E = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLA H instruction
        /// </summary>
        void SLA_H()
        {
            var oldValue = H;
            var newValue = (byte)(oldValue << 1);
            H = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLA L instruction
        /// </summary>
        void SLA_L()
        {
            var oldValue = L;
            var newValue = (byte)(oldValue << 1);
            L = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLA (HL) instruction
        /// </summary>
        void SLA_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue << 1);
            Memory[address] = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLA (IX+n),A instruction
        /// </summary>
        void SLA_aIX_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue << 1);
            Memory[address] = newValue;
            A = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLA (IX+n),B instruction
        /// </summary>
        void SLA_aIX_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue << 1);
            Memory[address] = newValue;
            B = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLA (IX+n),C instruction
        /// </summary>
        void SLA_aIX_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue << 1);
            Memory[address] = newValue;
            C = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLA (IX+n),D instruction
        /// </summary>
        void SLA_aIX_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue << 1);
            Memory[address] = newValue;
            D = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLA (IX+n),E instruction
        /// </summary>
        void SLA_aIX_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue << 1);
            Memory[address] = newValue;
            E = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLA (IX+n),H instruction
        /// </summary>
        void SLA_aIX_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue << 1);
            Memory[address] = newValue;
            H = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLA (IX+n),L instruction
        /// </summary>
        void SLA_aIX_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue << 1);
            Memory[address] = newValue;
            L = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLA (IX+n) instruction
        /// </summary>
        void SLA_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue << 1);
            Memory[address] = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLA (IY+n),A instruction
        /// </summary>
        void SLA_aIY_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue << 1);
            Memory[address] = newValue;
            A = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLA (IY+n),B instruction
        /// </summary>
        void SLA_aIY_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue << 1);
            Memory[address] = newValue;
            B = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLA (IY+n),C instruction
        /// </summary>
        void SLA_aIY_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue << 1);
            Memory[address] = newValue;
            C = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLA (IY+n),D instruction
        /// </summary>
        void SLA_aIY_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue << 1);
            Memory[address] = newValue;
            D = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLA (IY+n),E instruction
        /// </summary>
        void SLA_aIY_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue << 1);
            Memory[address] = newValue;
            E = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLA (IY+n),H instruction
        /// </summary>
        void SLA_aIY_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue << 1);
            Memory[address] = newValue;
            H = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLA (IY+n),L instruction
        /// </summary>
        void SLA_aIY_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue << 1);
            Memory[address] = newValue;
            L = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLA (IY+n) instruction
        /// </summary>
        void SLA_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue << 1);
            Memory[address] = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRA A instruction
        /// </summary>
        void SRA_A()
        {
            var oldValue = A;
            var newValue = (byte)((oldValue >> 1) | (oldValue & 0x80));
            A = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRA B instruction
        /// </summary>
        void SRA_B()
        {
            var oldValue = B;
            var newValue = (byte)((oldValue >> 1) | (oldValue & 0x80));
            B = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRA C instruction
        /// </summary>
        void SRA_C()
        {
            var oldValue = C;
            var newValue = (byte)((oldValue >> 1) | (oldValue & 0x80));
            C = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRA D instruction
        /// </summary>
        void SRA_D()
        {
            var oldValue = D;
            var newValue = (byte)((oldValue >> 1) | (oldValue & 0x80));
            D = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRA E instruction
        /// </summary>
        void SRA_E()
        {
            var oldValue = E;
            var newValue = (byte)((oldValue >> 1) | (oldValue & 0x80));
            E = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRA H instruction
        /// </summary>
        void SRA_H()
        {
            var oldValue = H;
            var newValue = (byte)((oldValue >> 1) | (oldValue & 0x80));
            H = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRA L instruction
        /// </summary>
        void SRA_L()
        {
            var oldValue = L;
            var newValue = (byte)((oldValue >> 1) | (oldValue & 0x80));
            L = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRA (HL) instruction
        /// </summary>
        void SRA_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue & 0x80));
            Memory[address] = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRA (IX+n),A instruction
        /// </summary>
        void SRA_aIX_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue & 0x80));
            Memory[address] = newValue;
            A = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRA (IX+n),B instruction
        /// </summary>
        void SRA_aIX_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue & 0x80));
            Memory[address] = newValue;
            B = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRA (IX+n),C instruction
        /// </summary>
        void SRA_aIX_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue & 0x80));
            Memory[address] = newValue;
            C = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRA (IX+n),D instruction
        /// </summary>
        void SRA_aIX_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue & 0x80));
            Memory[address] = newValue;
            D = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRA (IX+n),E instruction
        /// </summary>
        void SRA_aIX_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue & 0x80));
            Memory[address] = newValue;
            E = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRA (IX+n),H instruction
        /// </summary>
        void SRA_aIX_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue & 0x80));
            Memory[address] = newValue;
            H = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRA (IX+n),L instruction
        /// </summary>
        void SRA_aIX_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue & 0x80));
            Memory[address] = newValue;
            L = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRA (IX+n) instruction
        /// </summary>
        void SRA_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue & 0x80));
            Memory[address] = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRA (IY+n),A instruction
        /// </summary>
        void SRA_aIY_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue & 0x80));
            Memory[address] = newValue;
            A = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRA (IY+n),B instruction
        /// </summary>
        void SRA_aIY_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue & 0x80));
            Memory[address] = newValue;
            B = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRA (IY+n),C instruction
        /// </summary>
        void SRA_aIY_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue & 0x80));
            Memory[address] = newValue;
            C = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRA (IY+n),D instruction
        /// </summary>
        void SRA_aIY_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue & 0x80));
            Memory[address] = newValue;
            D = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRA (IY+n),E instruction
        /// </summary>
        void SRA_aIY_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue & 0x80));
            Memory[address] = newValue;
            E = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRA (IY+n),H instruction
        /// </summary>
        void SRA_aIY_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue & 0x80));
            Memory[address] = newValue;
            H = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRA (IY+n),L instruction
        /// </summary>
        void SRA_aIY_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue & 0x80));
            Memory[address] = newValue;
            L = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRA (IY+n) instruction
        /// </summary>
        void SRA_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue >> 1) | (oldValue & 0x80));
            Memory[address] = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLL A instruction
        /// </summary>
        void SLL_A()
        {
            var oldValue = A;
            var newValue = (byte)((oldValue << 1) | 1);
            A = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLL B instruction
        /// </summary>
        void SLL_B()
        {
            var oldValue = B;
            var newValue = (byte)((oldValue << 1) | 1);
            B = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLL C instruction
        /// </summary>
        void SLL_C()
        {
            var oldValue = C;
            var newValue = (byte)((oldValue << 1) | 1);
            C = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLL D instruction
        /// </summary>
        void SLL_D()
        {
            var oldValue = D;
            var newValue = (byte)((oldValue << 1) | 1);
            D = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLL E instruction
        /// </summary>
        void SLL_E()
        {
            var oldValue = E;
            var newValue = (byte)((oldValue << 1) | 1);
            E = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLL H instruction
        /// </summary>
        void SLL_H()
        {
            var oldValue = H;
            var newValue = (byte)((oldValue << 1) | 1);
            H = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLL L instruction
        /// </summary>
        void SLL_L()
        {
            var oldValue = L;
            var newValue = (byte)((oldValue << 1) | 1);
            L = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLL (HL) instruction
        /// </summary>
        void SLL_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | 1);
            Memory[address] = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLL (IX+n),A instruction
        /// </summary>
        void SLL_aIX_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | 1);
            Memory[address] = newValue;
            A = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLL (IX+n),B instruction
        /// </summary>
        void SLL_aIX_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | 1);
            Memory[address] = newValue;
            B = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLL (IX+n),C instruction
        /// </summary>
        void SLL_aIX_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | 1);
            Memory[address] = newValue;
            C = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLL (IX+n),D instruction
        /// </summary>
        void SLL_aIX_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | 1);
            Memory[address] = newValue;
            D = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLL (IX+n),E instruction
        /// </summary>
        void SLL_aIX_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | 1);
            Memory[address] = newValue;
            E = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLL (IX+n),H instruction
        /// </summary>
        void SLL_aIX_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | 1);
            Memory[address] = newValue;
            H = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLL (IX+n),L instruction
        /// </summary>
        void SLL_aIX_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | 1);
            Memory[address] = newValue;
            L = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLL (IX+n) instruction
        /// </summary>
        void SLL_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | 1);
            Memory[address] = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLL (IY+n),A instruction
        /// </summary>
        void SLL_aIY_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | 1);
            Memory[address] = newValue;
            A = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLL (IY+n),B instruction
        /// </summary>
        void SLL_aIY_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | 1);
            Memory[address] = newValue;
            B = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLL (IY+n),C instruction
        /// </summary>
        void SLL_aIY_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | 1);
            Memory[address] = newValue;
            C = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLL (IY+n),D instruction
        /// </summary>
        void SLL_aIY_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | 1);
            Memory[address] = newValue;
            D = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLL (IY+n),E instruction
        /// </summary>
        void SLL_aIY_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | 1);
            Memory[address] = newValue;
            E = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLL (IY+n),H instruction
        /// </summary>
        void SLL_aIY_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | 1);
            Memory[address] = newValue;
            H = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLL (IY+n),L instruction
        /// </summary>
        void SLL_aIY_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | 1);
            Memory[address] = newValue;
            L = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SLL (IY+n) instruction
        /// </summary>
        void SLL_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)((oldValue << 1) | 1);
            Memory[address] = newValue;

            CF = oldValue.GetBit(7);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRL A instruction
        /// </summary>
        void SRL_A()
        {
            var oldValue = A;
            var newValue = (byte)(oldValue >> 1);
            A = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRL B instruction
        /// </summary>
        void SRL_B()
        {
            var oldValue = B;
            var newValue = (byte)(oldValue >> 1);
            B = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRL C instruction
        /// </summary>
        void SRL_C()
        {
            var oldValue = C;
            var newValue = (byte)(oldValue >> 1);
            C = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRL D instruction
        /// </summary>
        void SRL_D()
        {
            var oldValue = D;
            var newValue = (byte)(oldValue >> 1);
            D = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRL E instruction
        /// </summary>
        void SRL_E()
        {
            var oldValue = E;
            var newValue = (byte)(oldValue >> 1);
            E = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRL H instruction
        /// </summary>
        void SRL_H()
        {
            var oldValue = H;
            var newValue = (byte)(oldValue >> 1);
            H = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRL L instruction
        /// </summary>
        void SRL_L()
        {
            var oldValue = L;
            var newValue = (byte)(oldValue >> 1);
            L = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRL (HL) instruction
        /// </summary>
        void SRL_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue >> 1);
            Memory[address] = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRL (IX+n),A instruction
        /// </summary>
        void SRL_aIX_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue >> 1);
            Memory[address] = newValue;
            A = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRL (IX+n),B instruction
        /// </summary>
        void SRL_aIX_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue >> 1);
            Memory[address] = newValue;
            B = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRL (IX+n),C instruction
        /// </summary>
        void SRL_aIX_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue >> 1);
            Memory[address] = newValue;
            C = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRL (IX+n),D instruction
        /// </summary>
        void SRL_aIX_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue >> 1);
            Memory[address] = newValue;
            D = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRL (IX+n),E instruction
        /// </summary>
        void SRL_aIX_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue >> 1);
            Memory[address] = newValue;
            E = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRL (IX+n),H instruction
        /// </summary>
        void SRL_aIX_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue >> 1);
            Memory[address] = newValue;
            H = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRL (IX+n),L instruction
        /// </summary>
        void SRL_aIX_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue >> 1);
            Memory[address] = newValue;
            L = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRL (IX+n) instruction
        /// </summary>
        void SRL_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue >> 1);
            Memory[address] = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRL (IY+n),A instruction
        /// </summary>
        void SRL_aIY_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue >> 1);
            Memory[address] = newValue;
            A = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRL (IY+n),B instruction
        /// </summary>
        void SRL_aIY_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue >> 1);
            Memory[address] = newValue;
            B = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRL (IY+n),C instruction
        /// </summary>
        void SRL_aIY_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue >> 1);
            Memory[address] = newValue;
            C = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRL (IY+n),D instruction
        /// </summary>
        void SRL_aIY_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue >> 1);
            Memory[address] = newValue;
            D = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRL (IY+n),E instruction
        /// </summary>
        void SRL_aIY_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue >> 1);
            Memory[address] = newValue;
            E = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRL (IY+n),H instruction
        /// </summary>
        void SRL_aIY_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue >> 1);
            Memory[address] = newValue;
            H = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRL (IY+n),L instruction
        /// </summary>
        void SRL_aIY_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue >> 1);
            Memory[address] = newValue;
            L = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }

        /// <summary>
        /// The SRL (IY+n) instruction
        /// </summary>
        void SRL_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = (byte)(oldValue >> 1);
            Memory[address] = newValue;

            CF = oldValue.GetBit(0);
            HF = 0;
            NF = 0;
            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
        }
    }
}
