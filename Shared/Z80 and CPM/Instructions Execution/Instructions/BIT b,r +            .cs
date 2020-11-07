using System;

namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The BIT 0,A instruction
        /// </summary>
        void BIT_0_A()
        {
            var oldValue = A;
            var bitValue = oldValue.GetBit(0);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 1,A instruction
        /// </summary>
        void BIT_1_A()
        {
            var oldValue = A;
            var bitValue = oldValue.GetBit(1);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 2,A instruction
        /// </summary>
        void BIT_2_A()
        {
            var oldValue = A;
            var bitValue = oldValue.GetBit(2);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 3,A instruction
        /// </summary>
        void BIT_3_A()
        {
            var oldValue = A;
            var bitValue = oldValue.GetBit(3);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 4,A instruction
        /// </summary>
        void BIT_4_A()
        {
            var oldValue = A;
            var bitValue = oldValue.GetBit(4);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 5,A instruction
        /// </summary>
        void BIT_5_A()
        {
            var oldValue = A;
            var bitValue = oldValue.GetBit(5);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 6,A instruction
        /// </summary>
        void BIT_6_A()
        {
            var oldValue = A;
            var bitValue = oldValue.GetBit(6);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 7,A instruction
        /// </summary>
        void BIT_7_A()
        {
            var oldValue = A;
            var bitValue = oldValue.GetBit(7);
            ZF = PF = bitValue ^ 1;
            SF = bitValue;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 0,B instruction
        /// </summary>
        void BIT_0_B()
        {
            var oldValue = B;
            var bitValue = oldValue.GetBit(0);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 1,B instruction
        /// </summary>
        void BIT_1_B()
        {
            var oldValue = B;
            var bitValue = oldValue.GetBit(1);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 2,B instruction
        /// </summary>
        void BIT_2_B()
        {
            var oldValue = B;
            var bitValue = oldValue.GetBit(2);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 3,B instruction
        /// </summary>
        void BIT_3_B()
        {
            var oldValue = B;
            var bitValue = oldValue.GetBit(3);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 4,B instruction
        /// </summary>
        void BIT_4_B()
        {
            var oldValue = B;
            var bitValue = oldValue.GetBit(4);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 5,B instruction
        /// </summary>
        void BIT_5_B()
        {
            var oldValue = B;
            var bitValue = oldValue.GetBit(5);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 6,B instruction
        /// </summary>
        void BIT_6_B()
        {
            var oldValue = B;
            var bitValue = oldValue.GetBit(6);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 7,B instruction
        /// </summary>
        void BIT_7_B()
        {
            var oldValue = B;
            var bitValue = oldValue.GetBit(7);
            ZF = PF = bitValue ^ 1;
            SF = bitValue;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 0,C instruction
        /// </summary>
        void BIT_0_C()
        {
            var oldValue = C;
            var bitValue = oldValue.GetBit(0);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 1,C instruction
        /// </summary>
        void BIT_1_C()
        {
            var oldValue = C;
            var bitValue = oldValue.GetBit(1);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 2,C instruction
        /// </summary>
        void BIT_2_C()
        {
            var oldValue = C;
            var bitValue = oldValue.GetBit(2);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 3,C instruction
        /// </summary>
        void BIT_3_C()
        {
            var oldValue = C;
            var bitValue = oldValue.GetBit(3);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 4,C instruction
        /// </summary>
        void BIT_4_C()
        {
            var oldValue = C;
            var bitValue = oldValue.GetBit(4);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 5,C instruction
        /// </summary>
        void BIT_5_C()
        {
            var oldValue = C;
            var bitValue = oldValue.GetBit(5);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 6,C instruction
        /// </summary>
        void BIT_6_C()
        {
            var oldValue = C;
            var bitValue = oldValue.GetBit(6);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 7,C instruction
        /// </summary>
        void BIT_7_C()
        {
            var oldValue = C;
            var bitValue = oldValue.GetBit(7);
            ZF = PF = bitValue ^ 1;
            SF = bitValue;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 0,D instruction
        /// </summary>
        void BIT_0_D()
        {
            var oldValue = D;
            var bitValue = oldValue.GetBit(0);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 1,D instruction
        /// </summary>
        void BIT_1_D()
        {
            var oldValue = D;
            var bitValue = oldValue.GetBit(1);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 2,D instruction
        /// </summary>
        void BIT_2_D()
        {
            var oldValue = D;
            var bitValue = oldValue.GetBit(2);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 3,D instruction
        /// </summary>
        void BIT_3_D()
        {
            var oldValue = D;
            var bitValue = oldValue.GetBit(3);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 4,D instruction
        /// </summary>
        void BIT_4_D()
        {
            var oldValue = D;
            var bitValue = oldValue.GetBit(4);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 5,D instruction
        /// </summary>
        void BIT_5_D()
        {
            var oldValue = D;
            var bitValue = oldValue.GetBit(5);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 6,D instruction
        /// </summary>
        void BIT_6_D()
        {
            var oldValue = D;
            var bitValue = oldValue.GetBit(6);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 7,D instruction
        /// </summary>
        void BIT_7_D()
        {
            var oldValue = D;
            var bitValue = oldValue.GetBit(7);
            ZF = PF = bitValue ^ 1;
            SF = bitValue;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 0,E instruction
        /// </summary>
        void BIT_0_E()
        {
            var oldValue = E;
            var bitValue = oldValue.GetBit(0);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 1,E instruction
        /// </summary>
        void BIT_1_E()
        {
            var oldValue = E;
            var bitValue = oldValue.GetBit(1);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 2,E instruction
        /// </summary>
        void BIT_2_E()
        {
            var oldValue = E;
            var bitValue = oldValue.GetBit(2);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 3,E instruction
        /// </summary>
        void BIT_3_E()
        {
            var oldValue = E;
            var bitValue = oldValue.GetBit(3);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 4,E instruction
        /// </summary>
        void BIT_4_E()
        {
            var oldValue = E;
            var bitValue = oldValue.GetBit(4);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 5,E instruction
        /// </summary>
        void BIT_5_E()
        {
            var oldValue = E;
            var bitValue = oldValue.GetBit(5);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 6,E instruction
        /// </summary>
        void BIT_6_E()
        {
            var oldValue = E;
            var bitValue = oldValue.GetBit(6);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 7,E instruction
        /// </summary>
        void BIT_7_E()
        {
            var oldValue = E;
            var bitValue = oldValue.GetBit(7);
            ZF = PF = bitValue ^ 1;
            SF = bitValue;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 0,H instruction
        /// </summary>
        void BIT_0_H()
        {
            var oldValue = H;
            var bitValue = oldValue.GetBit(0);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 1,H instruction
        /// </summary>
        void BIT_1_H()
        {
            var oldValue = H;
            var bitValue = oldValue.GetBit(1);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 2,H instruction
        /// </summary>
        void BIT_2_H()
        {
            var oldValue = H;
            var bitValue = oldValue.GetBit(2);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 3,H instruction
        /// </summary>
        void BIT_3_H()
        {
            var oldValue = H;
            var bitValue = oldValue.GetBit(3);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 4,H instruction
        /// </summary>
        void BIT_4_H()
        {
            var oldValue = H;
            var bitValue = oldValue.GetBit(4);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 5,H instruction
        /// </summary>
        void BIT_5_H()
        {
            var oldValue = H;
            var bitValue = oldValue.GetBit(5);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 6,H instruction
        /// </summary>
        void BIT_6_H()
        {
            var oldValue = H;
            var bitValue = oldValue.GetBit(6);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 7,H instruction
        /// </summary>
        void BIT_7_H()
        {
            var oldValue = H;
            var bitValue = oldValue.GetBit(7);
            ZF = PF = bitValue ^ 1;
            SF = bitValue;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 0,L instruction
        /// </summary>
        void BIT_0_L()
        {
            var oldValue = L;
            var bitValue = oldValue.GetBit(0);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 1,L instruction
        /// </summary>
        void BIT_1_L()
        {
            var oldValue = L;
            var bitValue = oldValue.GetBit(1);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 2,L instruction
        /// </summary>
        void BIT_2_L()
        {
            var oldValue = L;
            var bitValue = oldValue.GetBit(2);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 3,L instruction
        /// </summary>
        void BIT_3_L()
        {
            var oldValue = L;
            var bitValue = oldValue.GetBit(3);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 4,L instruction
        /// </summary>
        void BIT_4_L()
        {
            var oldValue = L;
            var bitValue = oldValue.GetBit(4);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 5,L instruction
        /// </summary>
        void BIT_5_L()
        {
            var oldValue = L;
            var bitValue = oldValue.GetBit(5);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 6,L instruction
        /// </summary>
        void BIT_6_L()
        {
            var oldValue = L;
            var bitValue = oldValue.GetBit(6);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 7,L instruction
        /// </summary>
        void BIT_7_L()
        {
            var oldValue = L;
            var bitValue = oldValue.GetBit(7);
            ZF = PF = bitValue ^ 1;
            SF = bitValue;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 0,(HL) instruction
        /// </summary>
        void BIT_0_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var bitValue = oldValue.GetBit(0);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 1,(HL) instruction
        /// </summary>
        void BIT_1_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var bitValue = oldValue.GetBit(1);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 2,(HL) instruction
        /// </summary>
        void BIT_2_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var bitValue = oldValue.GetBit(2);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 3,(HL) instruction
        /// </summary>
        void BIT_3_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var bitValue = oldValue.GetBit(3);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 4,(HL) instruction
        /// </summary>
        void BIT_4_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var bitValue = oldValue.GetBit(4);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 5,(HL) instruction
        /// </summary>
        void BIT_5_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var bitValue = oldValue.GetBit(5);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 6,(HL) instruction
        /// </summary>
        void BIT_6_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var bitValue = oldValue.GetBit(6);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 7,(HL) instruction
        /// </summary>
        void BIT_7_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var bitValue = oldValue.GetBit(7);
            ZF = PF = bitValue ^ 1;
            SF = bitValue;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 0,(IX+n) instruction
        /// </summary>
        void BIT_0_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var bitValue = oldValue.GetBit(0);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 1,(IX+n) instruction
        /// </summary>
        void BIT_1_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var bitValue = oldValue.GetBit(1);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 2,(IX+n) instruction
        /// </summary>
        void BIT_2_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var bitValue = oldValue.GetBit(2);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 3,(IX+n) instruction
        /// </summary>
        void BIT_3_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var bitValue = oldValue.GetBit(3);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 4,(IX+n) instruction
        /// </summary>
        void BIT_4_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var bitValue = oldValue.GetBit(4);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 5,(IX+n) instruction
        /// </summary>
        void BIT_5_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var bitValue = oldValue.GetBit(5);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 6,(IX+n) instruction
        /// </summary>
        void BIT_6_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var bitValue = oldValue.GetBit(6);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 7,(IX+n) instruction
        /// </summary>
        void BIT_7_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var bitValue = oldValue.GetBit(7);
            ZF = PF = bitValue ^ 1;
            SF = bitValue;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 0,(IY+n) instruction
        /// </summary>
        void BIT_0_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var bitValue = oldValue.GetBit(0);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 1,(IY+n) instruction
        /// </summary>
        void BIT_1_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var bitValue = oldValue.GetBit(1);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 2,(IY+n) instruction
        /// </summary>
        void BIT_2_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var bitValue = oldValue.GetBit(2);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 3,(IY+n) instruction
        /// </summary>
        void BIT_3_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var bitValue = oldValue.GetBit(3);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 4,(IY+n) instruction
        /// </summary>
        void BIT_4_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var bitValue = oldValue.GetBit(4);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;
        }

        /// <summary>
        /// The BIT 5,(IY+n) instruction
        /// </summary>
        void BIT_5_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var bitValue = oldValue.GetBit(5);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 6,(IY+n) instruction
        /// </summary>
        void BIT_6_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var bitValue = oldValue.GetBit(6);
            ZF = PF = bitValue ^ 1;
            SF = 0;
            HF = 1;
            NF = 0;

        }

        /// <summary>
        /// The BIT 7,(IY+n) instruction
        /// </summary>
        void BIT_7_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var bitValue = oldValue.GetBit(7);
            ZF = PF = bitValue ^ 1;
            SF = bitValue;
            HF = 1;
            NF = 0;

        }

    }
}
