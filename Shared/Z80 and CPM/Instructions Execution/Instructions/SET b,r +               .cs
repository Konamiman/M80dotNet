using System;

namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The SET 0,A instruction
        /// </summary>
        void SET_0_A()
        {
            var oldValue = A;
            var newValue = oldValue.WithBit(0, 1);
            A = newValue;
        }

        /// <summary>
        /// The SET 1,A instruction
        /// </summary>
        void SET_1_A()
        {
            var oldValue = A;
            var newValue = oldValue.WithBit(1, 1);
            A = newValue;
        }

        /// <summary>
        /// The SET 2,A instruction
        /// </summary>
        void SET_2_A()
        {
            var oldValue = A;
            var newValue = oldValue.WithBit(2, 1);
            A = newValue;
        }

        /// <summary>
        /// The SET 3,A instruction
        /// </summary>
        void SET_3_A()
        {
            var oldValue = A;
            var newValue = oldValue.WithBit(3, 1);
            A = newValue;
        }

        /// <summary>
        /// The SET 4,A instruction
        /// </summary>
        void SET_4_A()
        {
            var oldValue = A;
            var newValue = oldValue.WithBit(4, 1);
            A = newValue;
        }

        /// <summary>
        /// The SET 5,A instruction
        /// </summary>
        void SET_5_A()
        {
            var oldValue = A;
            var newValue = oldValue.WithBit(5, 1);
            A = newValue;
        }

        /// <summary>
        /// The SET 6,A instruction
        /// </summary>
        void SET_6_A()
        {
            var oldValue = A;
            var newValue = oldValue.WithBit(6, 1);
            A = newValue;
        }

        /// <summary>
        /// The SET 7,A instruction
        /// </summary>
        void SET_7_A()
        {
            var oldValue = A;
            var newValue = oldValue.WithBit(7, 1);
            A = newValue;
        }

        /// <summary>
        /// The RES 0,A instruction
        /// </summary>
        void RES_0_A()
        {
            var oldValue = A;
            var newValue = oldValue.WithBit(0, 0);
            A = newValue;
        }

        /// <summary>
        /// The RES 1,A instruction
        /// </summary>
        void RES_1_A()
        {
            var oldValue = A;
            var newValue = oldValue.WithBit(1, 0);
            A = newValue;
        }

        /// <summary>
        /// The RES 2,A instruction
        /// </summary>
        void RES_2_A()
        {
            var oldValue = A;
            var newValue = oldValue.WithBit(2, 0);
            A = newValue;
        }

        /// <summary>
        /// The RES 3,A instruction
        /// </summary>
        void RES_3_A()
        {
            var oldValue = A;
            var newValue = oldValue.WithBit(3, 0);
            A = newValue;
        }

        /// <summary>
        /// The RES 4,A instruction
        /// </summary>
        void RES_4_A()
        {
            var oldValue = A;
            var newValue = oldValue.WithBit(4, 0);
            A = newValue;
        }

        /// <summary>
        /// The RES 5,A instruction
        /// </summary>
        void RES_5_A()
        {
            var oldValue = A;
            var newValue = oldValue.WithBit(5, 0);
            A = newValue;
        }

        /// <summary>
        /// The RES 6,A instruction
        /// </summary>
        void RES_6_A()
        {
            var oldValue = A;
            var newValue = oldValue.WithBit(6, 0);
            A = newValue;
        }

        /// <summary>
        /// The RES 7,A instruction
        /// </summary>
        void RES_7_A()
        {
            var oldValue = A;
            var newValue = oldValue.WithBit(7, 0);
            A = newValue;
        }

        /// <summary>
        /// The SET 0,B instruction
        /// </summary>
        void SET_0_B()
        {
            var oldValue = B;
            var newValue = oldValue.WithBit(0, 1);
            B = newValue;
        }

        /// <summary>
        /// The SET 1,B instruction
        /// </summary>
        void SET_1_B()
        {
            var oldValue = B;
            var newValue = oldValue.WithBit(1, 1);
            B = newValue;
        }

        /// <summary>
        /// The SET 2,B instruction
        /// </summary>
        void SET_2_B()
        {
            var oldValue = B;
            var newValue = oldValue.WithBit(2, 1);
            B = newValue;
        }

        /// <summary>
        /// The SET 3,B instruction
        /// </summary>
        void SET_3_B()
        {
            var oldValue = B;
            var newValue = oldValue.WithBit(3, 1);
            B = newValue;
        }

        /// <summary>
        /// The SET 4,B instruction
        /// </summary>
        void SET_4_B()
        {
            var oldValue = B;
            var newValue = oldValue.WithBit(4, 1);
            B = newValue;
        }

        /// <summary>
        /// The SET 5,B instruction
        /// </summary>
        void SET_5_B()
        {
            var oldValue = B;
            var newValue = oldValue.WithBit(5, 1);
            B = newValue;
        }

        /// <summary>
        /// The SET 6,B instruction
        /// </summary>
        void SET_6_B()
        {
            var oldValue = B;
            var newValue = oldValue.WithBit(6, 1);
            B = newValue;
        }

        /// <summary>
        /// The SET 7,B instruction
        /// </summary>
        void SET_7_B()
        {
            var oldValue = B;
            var newValue = oldValue.WithBit(7, 1);
            B = newValue;
        }

        /// <summary>
        /// The RES 0,B instruction
        /// </summary>
        void RES_0_B()
        {
            var oldValue = B;
            var newValue = oldValue.WithBit(0, 0);
            B = newValue;
        }

        /// <summary>
        /// The RES 1,B instruction
        /// </summary>
        void RES_1_B()
        {
            var oldValue = B;
            var newValue = oldValue.WithBit(1, 0);
            B = newValue;
        }

        /// <summary>
        /// The RES 2,B instruction
        /// </summary>
        void RES_2_B()
        {
            var oldValue = B;
            var newValue = oldValue.WithBit(2, 0);
            B = newValue;
        }

        /// <summary>
        /// The RES 3,B instruction
        /// </summary>
        void RES_3_B()
        {
            var oldValue = B;
            var newValue = oldValue.WithBit(3, 0);
            B = newValue;
        }

        /// <summary>
        /// The RES 4,B instruction
        /// </summary>
        void RES_4_B()
        {
            var oldValue = B;
            var newValue = oldValue.WithBit(4, 0);
            B = newValue;
        }

        /// <summary>
        /// The RES 5,B instruction
        /// </summary>
        void RES_5_B()
        {
            var oldValue = B;
            var newValue = oldValue.WithBit(5, 0);
            B = newValue;
        }

        /// <summary>
        /// The RES 6,B instruction
        /// </summary>
        void RES_6_B()
        {
            var oldValue = B;
            var newValue = oldValue.WithBit(6, 0);
            B = newValue;
        }

        /// <summary>
        /// The RES 7,B instruction
        /// </summary>
        void RES_7_B()
        {
            var oldValue = B;
            var newValue = oldValue.WithBit(7, 0);
            B = newValue;
        }

        /// <summary>
        /// The SET 0,C instruction
        /// </summary>
        void SET_0_C()
        {
            var oldValue = C;
            var newValue = oldValue.WithBit(0, 1);
            C = newValue;
        }

        /// <summary>
        /// The SET 1,C instruction
        /// </summary>
        void SET_1_C()
        {
            var oldValue = C;
            var newValue = oldValue.WithBit(1, 1);
            C = newValue;
        }

        /// <summary>
        /// The SET 2,C instruction
        /// </summary>
        void SET_2_C()
        {
            var oldValue = C;
            var newValue = oldValue.WithBit(2, 1);
            C = newValue;
        }

        /// <summary>
        /// The SET 3,C instruction
        /// </summary>
        void SET_3_C()
        {
            var oldValue = C;
            var newValue = oldValue.WithBit(3, 1);
            C = newValue;
        }

        /// <summary>
        /// The SET 4,C instruction
        /// </summary>
        void SET_4_C()
        {
            var oldValue = C;
            var newValue = oldValue.WithBit(4, 1);
            C = newValue;
        }

        /// <summary>
        /// The SET 5,C instruction
        /// </summary>
        void SET_5_C()
        {
            var oldValue = C;
            var newValue = oldValue.WithBit(5, 1);
            C = newValue;
        }

        /// <summary>
        /// The SET 6,C instruction
        /// </summary>
        void SET_6_C()
        {
            var oldValue = C;
            var newValue = oldValue.WithBit(6, 1);
            C = newValue;
        }

        /// <summary>
        /// The SET 7,C instruction
        /// </summary>
        void SET_7_C()
        {
            var oldValue = C;
            var newValue = oldValue.WithBit(7, 1);
            C = newValue;
        }

        /// <summary>
        /// The RES 0,C instruction
        /// </summary>
        void RES_0_C()
        {
            var oldValue = C;
            var newValue = oldValue.WithBit(0, 0);
            C = newValue;
        }

        /// <summary>
        /// The RES 1,C instruction
        /// </summary>
        void RES_1_C()
        {
            var oldValue = C;
            var newValue = oldValue.WithBit(1, 0);
            C = newValue;
        }

        /// <summary>
        /// The RES 2,C instruction
        /// </summary>
        void RES_2_C()
        {
            var oldValue = C;
            var newValue = oldValue.WithBit(2, 0);
            C = newValue;
        }

        /// <summary>
        /// The RES 3,C instruction
        /// </summary>
        void RES_3_C()
        {
            var oldValue = C;
            var newValue = oldValue.WithBit(3, 0);
            C = newValue;
        }

        /// <summary>
        /// The RES 4,C instruction
        /// </summary>
        void RES_4_C()
        {
            var oldValue = C;
            var newValue = oldValue.WithBit(4, 0);
            C = newValue;
        }

        /// <summary>
        /// The RES 5,C instruction
        /// </summary>
        void RES_5_C()
        {
            var oldValue = C;
            var newValue = oldValue.WithBit(5, 0);
            C = newValue;
        }

        /// <summary>
        /// The RES 6,C instruction
        /// </summary>
        void RES_6_C()
        {
            var oldValue = C;
            var newValue = oldValue.WithBit(6, 0);
            C = newValue;
        }

        /// <summary>
        /// The RES 7,C instruction
        /// </summary>
        void RES_7_C()
        {
            var oldValue = C;
            var newValue = oldValue.WithBit(7, 0);
            C = newValue;
        }

        /// <summary>
        /// The SET 0,D instruction
        /// </summary>
        void SET_0_D()
        {
            var oldValue = D;
            var newValue = oldValue.WithBit(0, 1);
            D = newValue;
        }

        /// <summary>
        /// The SET 1,D instruction
        /// </summary>
        void SET_1_D()
        {
            var oldValue = D;
            var newValue = oldValue.WithBit(1, 1);
            D = newValue;
        }

        /// <summary>
        /// The SET 2,D instruction
        /// </summary>
        void SET_2_D()
        {
            var oldValue = D;
            var newValue = oldValue.WithBit(2, 1);
            D = newValue;
        }

        /// <summary>
        /// The SET 3,D instruction
        /// </summary>
        void SET_3_D()
        {
            var oldValue = D;
            var newValue = oldValue.WithBit(3, 1);
            D = newValue;
        }

        /// <summary>
        /// The SET 4,D instruction
        /// </summary>
        void SET_4_D()
        {
            var oldValue = D;
            var newValue = oldValue.WithBit(4, 1);
            D = newValue;
        }

        /// <summary>
        /// The SET 5,D instruction
        /// </summary>
        void SET_5_D()
        {
            var oldValue = D;
            var newValue = oldValue.WithBit(5, 1);
            D = newValue;
        }

        /// <summary>
        /// The SET 6,D instruction
        /// </summary>
        void SET_6_D()
        {
            var oldValue = D;
            var newValue = oldValue.WithBit(6, 1);
            D = newValue;
        }

        /// <summary>
        /// The SET 7,D instruction
        /// </summary>
        void SET_7_D()
        {
            var oldValue = D;
            var newValue = oldValue.WithBit(7, 1);
            D = newValue;
        }

        /// <summary>
        /// The RES 0,D instruction
        /// </summary>
        void RES_0_D()
        {
            var oldValue = D;
            var newValue = oldValue.WithBit(0, 0);
            D = newValue;
        }

        /// <summary>
        /// The RES 1,D instruction
        /// </summary>
        void RES_1_D()
        {
            var oldValue = D;
            var newValue = oldValue.WithBit(1, 0);
            D = newValue;
        }

        /// <summary>
        /// The RES 2,D instruction
        /// </summary>
        void RES_2_D()
        {
            var oldValue = D;
            var newValue = oldValue.WithBit(2, 0);
            D = newValue;
        }

        /// <summary>
        /// The RES 3,D instruction
        /// </summary>
        void RES_3_D()
        {
            var oldValue = D;
            var newValue = oldValue.WithBit(3, 0);
            D = newValue;
        }

        /// <summary>
        /// The RES 4,D instruction
        /// </summary>
        void RES_4_D()
        {
            var oldValue = D;
            var newValue = oldValue.WithBit(4, 0);
            D = newValue;
        }

        /// <summary>
        /// The RES 5,D instruction
        /// </summary>
        void RES_5_D()
        {
            var oldValue = D;
            var newValue = oldValue.WithBit(5, 0);
            D = newValue;
        }

        /// <summary>
        /// The RES 6,D instruction
        /// </summary>
        void RES_6_D()
        {
            var oldValue = D;
            var newValue = oldValue.WithBit(6, 0);
            D = newValue;
        }

        /// <summary>
        /// The RES 7,D instruction
        /// </summary>
        void RES_7_D()
        {
            var oldValue = D;
            var newValue = oldValue.WithBit(7, 0);
            D = newValue;
        }

        /// <summary>
        /// The SET 0,E instruction
        /// </summary>
        void SET_0_E()
        {
            var oldValue = E;
            var newValue = oldValue.WithBit(0, 1);
            E = newValue;
        }

        /// <summary>
        /// The SET 1,E instruction
        /// </summary>
        void SET_1_E()
        {
            var oldValue = E;
            var newValue = oldValue.WithBit(1, 1);
            E = newValue;
        }

        /// <summary>
        /// The SET 2,E instruction
        /// </summary>
        void SET_2_E()
        {
            var oldValue = E;
            var newValue = oldValue.WithBit(2, 1);
            E = newValue;
        }

        /// <summary>
        /// The SET 3,E instruction
        /// </summary>
        void SET_3_E()
        {
            var oldValue = E;
            var newValue = oldValue.WithBit(3, 1);
            E = newValue;
        }

        /// <summary>
        /// The SET 4,E instruction
        /// </summary>
        void SET_4_E()
        {
            var oldValue = E;
            var newValue = oldValue.WithBit(4, 1);
            E = newValue;
        }

        /// <summary>
        /// The SET 5,E instruction
        /// </summary>
        void SET_5_E()
        {
            var oldValue = E;
            var newValue = oldValue.WithBit(5, 1);
            E = newValue;
        }

        /// <summary>
        /// The SET 6,E instruction
        /// </summary>
        void SET_6_E()
        {
            var oldValue = E;
            var newValue = oldValue.WithBit(6, 1);
            E = newValue;
        }

        /// <summary>
        /// The SET 7,E instruction
        /// </summary>
        void SET_7_E()
        {
            var oldValue = E;
            var newValue = oldValue.WithBit(7, 1);
            E = newValue;
        }

        /// <summary>
        /// The RES 0,E instruction
        /// </summary>
        void RES_0_E()
        {
            var oldValue = E;
            var newValue = oldValue.WithBit(0, 0);
            E = newValue;
        }

        /// <summary>
        /// The RES 1,E instruction
        /// </summary>
        void RES_1_E()
        {
            var oldValue = E;
            var newValue = oldValue.WithBit(1, 0);
            E = newValue;
        }

        /// <summary>
        /// The RES 2,E instruction
        /// </summary>
        void RES_2_E()
        {
            var oldValue = E;
            var newValue = oldValue.WithBit(2, 0);
            E = newValue;
        }

        /// <summary>
        /// The RES 3,E instruction
        /// </summary>
        void RES_3_E()
        {
            var oldValue = E;
            var newValue = oldValue.WithBit(3, 0);
            E = newValue;
        }

        /// <summary>
        /// The RES 4,E instruction
        /// </summary>
        void RES_4_E()
        {
            var oldValue = E;
            var newValue = oldValue.WithBit(4, 0);
            E = newValue;
        }

        /// <summary>
        /// The RES 5,E instruction
        /// </summary>
        void RES_5_E()
        {
            var oldValue = E;
            var newValue = oldValue.WithBit(5, 0);
            E = newValue;
        }

        /// <summary>
        /// The RES 6,E instruction
        /// </summary>
        void RES_6_E()
        {
            var oldValue = E;
            var newValue = oldValue.WithBit(6, 0);
            E = newValue;
        }

        /// <summary>
        /// The RES 7,E instruction
        /// </summary>
        void RES_7_E()
        {
            var oldValue = E;
            var newValue = oldValue.WithBit(7, 0);
            E = newValue;
        }

        /// <summary>
        /// The SET 0,H instruction
        /// </summary>
        void SET_0_H()
        {
            var oldValue = H;
            var newValue = oldValue.WithBit(0, 1);
            H = newValue;
        }

        /// <summary>
        /// The SET 1,H instruction
        /// </summary>
        void SET_1_H()
        {
            var oldValue = H;
            var newValue = oldValue.WithBit(1, 1);
            H = newValue;
        }

        /// <summary>
        /// The SET 2,H instruction
        /// </summary>
        void SET_2_H()
        {
            var oldValue = H;
            var newValue = oldValue.WithBit(2, 1);
            H = newValue;
        }

        /// <summary>
        /// The SET 3,H instruction
        /// </summary>
        void SET_3_H()
        {
            var oldValue = H;
            var newValue = oldValue.WithBit(3, 1);
            H = newValue;
        }

        /// <summary>
        /// The SET 4,H instruction
        /// </summary>
        void SET_4_H()
        {
            var oldValue = H;
            var newValue = oldValue.WithBit(4, 1);
            H = newValue;
        }

        /// <summary>
        /// The SET 5,H instruction
        /// </summary>
        void SET_5_H()
        {
            var oldValue = H;
            var newValue = oldValue.WithBit(5, 1);
            H = newValue;
        }

        /// <summary>
        /// The SET 6,H instruction
        /// </summary>
        void SET_6_H()
        {
            var oldValue = H;
            var newValue = oldValue.WithBit(6, 1);
            H = newValue;
        }

        /// <summary>
        /// The SET 7,H instruction
        /// </summary>
        void SET_7_H()
        {
            var oldValue = H;
            var newValue = oldValue.WithBit(7, 1);
            H = newValue;
        }

        /// <summary>
        /// The RES 0,H instruction
        /// </summary>
        void RES_0_H()
        {
            var oldValue = H;
            var newValue = oldValue.WithBit(0, 0);
            H = newValue;
        }

        /// <summary>
        /// The RES 1,H instruction
        /// </summary>
        void RES_1_H()
        {
            var oldValue = H;
            var newValue = oldValue.WithBit(1, 0);
            H = newValue;
        }

        /// <summary>
        /// The RES 2,H instruction
        /// </summary>
        void RES_2_H()
        {
            var oldValue = H;
            var newValue = oldValue.WithBit(2, 0);
            H = newValue;
        }

        /// <summary>
        /// The RES 3,H instruction
        /// </summary>
        void RES_3_H()
        {
            var oldValue = H;
            var newValue = oldValue.WithBit(3, 0);
            H = newValue;
        }

        /// <summary>
        /// The RES 4,H instruction
        /// </summary>
        void RES_4_H()
        {
            var oldValue = H;
            var newValue = oldValue.WithBit(4, 0);
            H = newValue;
        }

        /// <summary>
        /// The RES 5,H instruction
        /// </summary>
        void RES_5_H()
        {
            var oldValue = H;
            var newValue = oldValue.WithBit(5, 0);
            H = newValue;
        }

        /// <summary>
        /// The RES 6,H instruction
        /// </summary>
        void RES_6_H()
        {
            var oldValue = H;
            var newValue = oldValue.WithBit(6, 0);
            H = newValue;
        }

        /// <summary>
        /// The RES 7,H instruction
        /// </summary>
        void RES_7_H()
        {
            var oldValue = H;
            var newValue = oldValue.WithBit(7, 0);
            H = newValue;
        }

        /// <summary>
        /// The SET 0,L instruction
        /// </summary>
        void SET_0_L()
        {
            var oldValue = L;
            var newValue = oldValue.WithBit(0, 1);
            L = newValue;
        }

        /// <summary>
        /// The SET 1,L instruction
        /// </summary>
        void SET_1_L()
        {
            var oldValue = L;
            var newValue = oldValue.WithBit(1, 1);
            L = newValue;
        }

        /// <summary>
        /// The SET 2,L instruction
        /// </summary>
        void SET_2_L()
        {
            var oldValue = L;
            var newValue = oldValue.WithBit(2, 1);
            L = newValue;
        }

        /// <summary>
        /// The SET 3,L instruction
        /// </summary>
        void SET_3_L()
        {
            var oldValue = L;
            var newValue = oldValue.WithBit(3, 1);
            L = newValue;
        }

        /// <summary>
        /// The SET 4,L instruction
        /// </summary>
        void SET_4_L()
        {
            var oldValue = L;
            var newValue = oldValue.WithBit(4, 1);
            L = newValue;
        }

        /// <summary>
        /// The SET 5,L instruction
        /// </summary>
        void SET_5_L()
        {
            var oldValue = L;
            var newValue = oldValue.WithBit(5, 1);
            L = newValue;
        }

        /// <summary>
        /// The SET 6,L instruction
        /// </summary>
        void SET_6_L()
        {
            var oldValue = L;
            var newValue = oldValue.WithBit(6, 1);
            L = newValue;
        }

        /// <summary>
        /// The SET 7,L instruction
        /// </summary>
        void SET_7_L()
        {
            var oldValue = L;
            var newValue = oldValue.WithBit(7, 1);
            L = newValue;
        }

        /// <summary>
        /// The RES 0,L instruction
        /// </summary>
        void RES_0_L()
        {
            var oldValue = L;
            var newValue = oldValue.WithBit(0, 0);
            L = newValue;
        }

        /// <summary>
        /// The RES 1,L instruction
        /// </summary>
        void RES_1_L()
        {
            var oldValue = L;
            var newValue = oldValue.WithBit(1, 0);
            L = newValue;
        }

        /// <summary>
        /// The RES 2,L instruction
        /// </summary>
        void RES_2_L()
        {
            var oldValue = L;
            var newValue = oldValue.WithBit(2, 0);
            L = newValue;
        }

        /// <summary>
        /// The RES 3,L instruction
        /// </summary>
        void RES_3_L()
        {
            var oldValue = L;
            var newValue = oldValue.WithBit(3, 0);
            L = newValue;
        }

        /// <summary>
        /// The RES 4,L instruction
        /// </summary>
        void RES_4_L()
        {
            var oldValue = L;
            var newValue = oldValue.WithBit(4, 0);
            L = newValue;
        }

        /// <summary>
        /// The RES 5,L instruction
        /// </summary>
        void RES_5_L()
        {
            var oldValue = L;
            var newValue = oldValue.WithBit(5, 0);
            L = newValue;
        }

        /// <summary>
        /// The RES 6,L instruction
        /// </summary>
        void RES_6_L()
        {
            var oldValue = L;
            var newValue = oldValue.WithBit(6, 0);
            L = newValue;
        }

        /// <summary>
        /// The RES 7,L instruction
        /// </summary>
        void RES_7_L()
        {
            var oldValue = L;
            var newValue = oldValue.WithBit(7, 0);
            L = newValue;
        }

        /// <summary>
        /// The SET 0,(HL) instruction
        /// </summary>
        void SET_0_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 1);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The SET 1,(HL) instruction
        /// </summary>
        void SET_1_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 1);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The SET 2,(HL) instruction
        /// </summary>
        void SET_2_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 1);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The SET 3,(HL) instruction
        /// </summary>
        void SET_3_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 1);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The SET 4,(HL) instruction
        /// </summary>
        void SET_4_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 1);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The SET 5,(HL) instruction
        /// </summary>
        void SET_5_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 1);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The SET 6,(HL) instruction
        /// </summary>
        void SET_6_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 1);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The SET 7,(HL) instruction
        /// </summary>
        void SET_7_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 1);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The RES 0,(HL) instruction
        /// </summary>
        void RES_0_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 0);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The RES 1,(HL) instruction
        /// </summary>
        void RES_1_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 0);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The RES 2,(HL) instruction
        /// </summary>
        void RES_2_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 0);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The RES 3,(HL) instruction
        /// </summary>
        void RES_3_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 0);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The RES 4,(HL) instruction
        /// </summary>
        void RES_4_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 0);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The RES 5,(HL) instruction
        /// </summary>
        void RES_5_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 0);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The RES 6,(HL) instruction
        /// </summary>
        void RES_6_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 0);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The RES 7,(HL) instruction
        /// </summary>
        void RES_7_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 0);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The SET 0,(IX+n),A instruction
        /// </summary>
        void SET_0_aIX_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 1);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The SET 1,(IX+n),A instruction
        /// </summary>
        void SET_1_aIX_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 1);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The SET 2,(IX+n),A instruction
        /// </summary>
        void SET_2_aIX_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 1);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The SET 3,(IX+n),A instruction
        /// </summary>
        void SET_3_aIX_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 1);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The SET 4,(IX+n),A instruction
        /// </summary>
        void SET_4_aIX_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 1);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The SET 5,(IX+n),A instruction
        /// </summary>
        void SET_5_aIX_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 1);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The SET 6,(IX+n),A instruction
        /// </summary>
        void SET_6_aIX_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 1);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The SET 7,(IX+n),A instruction
        /// </summary>
        void SET_7_aIX_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 1);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The SET 0,(IX+n),B instruction
        /// </summary>
        void SET_0_aIX_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 1);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The SET 1,(IX+n),B instruction
        /// </summary>
        void SET_1_aIX_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 1);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The SET 2,(IX+n),B instruction
        /// </summary>
        void SET_2_aIX_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 1);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The SET 3,(IX+n),B instruction
        /// </summary>
        void SET_3_aIX_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 1);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The SET 4,(IX+n),B instruction
        /// </summary>
        void SET_4_aIX_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 1);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The SET 5,(IX+n),B instruction
        /// </summary>
        void SET_5_aIX_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 1);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The SET 6,(IX+n),B instruction
        /// </summary>
        void SET_6_aIX_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 1);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The SET 7,(IX+n),B instruction
        /// </summary>
        void SET_7_aIX_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 1);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The SET 0,(IX+n),C instruction
        /// </summary>
        void SET_0_aIX_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 1);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The SET 1,(IX+n),C instruction
        /// </summary>
        void SET_1_aIX_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 1);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The SET 2,(IX+n),C instruction
        /// </summary>
        void SET_2_aIX_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 1);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The SET 3,(IX+n),C instruction
        /// </summary>
        void SET_3_aIX_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 1);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The SET 4,(IX+n),C instruction
        /// </summary>
        void SET_4_aIX_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 1);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The SET 5,(IX+n),C instruction
        /// </summary>
        void SET_5_aIX_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 1);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The SET 6,(IX+n),C instruction
        /// </summary>
        void SET_6_aIX_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 1);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The SET 7,(IX+n),C instruction
        /// </summary>
        void SET_7_aIX_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 1);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The SET 0,(IX+n),D instruction
        /// </summary>
        void SET_0_aIX_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 1);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The SET 1,(IX+n),D instruction
        /// </summary>
        void SET_1_aIX_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 1);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The SET 2,(IX+n),D instruction
        /// </summary>
        void SET_2_aIX_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 1);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The SET 3,(IX+n),D instruction
        /// </summary>
        void SET_3_aIX_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 1);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The SET 4,(IX+n),D instruction
        /// </summary>
        void SET_4_aIX_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 1);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The SET 5,(IX+n),D instruction
        /// </summary>
        void SET_5_aIX_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 1);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The SET 6,(IX+n),D instruction
        /// </summary>
        void SET_6_aIX_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 1);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The SET 7,(IX+n),D instruction
        /// </summary>
        void SET_7_aIX_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 1);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The SET 0,(IX+n),E instruction
        /// </summary>
        void SET_0_aIX_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 1);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The SET 1,(IX+n),E instruction
        /// </summary>
        void SET_1_aIX_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 1);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The SET 2,(IX+n),E instruction
        /// </summary>
        void SET_2_aIX_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 1);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The SET 3,(IX+n),E instruction
        /// </summary>
        void SET_3_aIX_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 1);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The SET 4,(IX+n),E instruction
        /// </summary>
        void SET_4_aIX_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 1);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The SET 5,(IX+n),E instruction
        /// </summary>
        void SET_5_aIX_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 1);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The SET 6,(IX+n),E instruction
        /// </summary>
        void SET_6_aIX_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 1);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The SET 7,(IX+n),E instruction
        /// </summary>
        void SET_7_aIX_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 1);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The SET 0,(IX+n),H instruction
        /// </summary>
        void SET_0_aIX_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 1);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The SET 1,(IX+n),H instruction
        /// </summary>
        void SET_1_aIX_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 1);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The SET 2,(IX+n),H instruction
        /// </summary>
        void SET_2_aIX_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 1);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The SET 3,(IX+n),H instruction
        /// </summary>
        void SET_3_aIX_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 1);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The SET 4,(IX+n),H instruction
        /// </summary>
        void SET_4_aIX_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 1);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The SET 5,(IX+n),H instruction
        /// </summary>
        void SET_5_aIX_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 1);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The SET 6,(IX+n),H instruction
        /// </summary>
        void SET_6_aIX_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 1);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The SET 7,(IX+n),H instruction
        /// </summary>
        void SET_7_aIX_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 1);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The SET 0,(IX+n),L instruction
        /// </summary>
        void SET_0_aIX_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 1);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The SET 1,(IX+n),L instruction
        /// </summary>
        void SET_1_aIX_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 1);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The SET 2,(IX+n),L instruction
        /// </summary>
        void SET_2_aIX_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 1);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The SET 3,(IX+n),L instruction
        /// </summary>
        void SET_3_aIX_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 1);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The SET 4,(IX+n),L instruction
        /// </summary>
        void SET_4_aIX_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 1);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The SET 5,(IX+n),L instruction
        /// </summary>
        void SET_5_aIX_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 1);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The SET 6,(IX+n),L instruction
        /// </summary>
        void SET_6_aIX_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 1);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The SET 7,(IX+n),L instruction
        /// </summary>
        void SET_7_aIX_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 1);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The SET 0,(IX+n) instruction
        /// </summary>
        void SET_0_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 1);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The SET 1,(IX+n) instruction
        /// </summary>
        void SET_1_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 1);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The SET 2,(IX+n) instruction
        /// </summary>
        void SET_2_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 1);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The SET 3,(IX+n) instruction
        /// </summary>
        void SET_3_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 1);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The SET 4,(IX+n) instruction
        /// </summary>
        void SET_4_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 1);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The SET 5,(IX+n) instruction
        /// </summary>
        void SET_5_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 1);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The SET 6,(IX+n) instruction
        /// </summary>
        void SET_6_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 1);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The SET 7,(IX+n) instruction
        /// </summary>
        void SET_7_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 1);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The RES 0,(IX+n),A instruction
        /// </summary>
        void RES_0_aIX_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 0);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The RES 1,(IX+n),A instruction
        /// </summary>
        void RES_1_aIX_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 0);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The RES 2,(IX+n),A instruction
        /// </summary>
        void RES_2_aIX_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 0);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The RES 3,(IX+n),A instruction
        /// </summary>
        void RES_3_aIX_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 0);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The RES 4,(IX+n),A instruction
        /// </summary>
        void RES_4_aIX_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 0);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The RES 5,(IX+n),A instruction
        /// </summary>
        void RES_5_aIX_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 0);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The RES 6,(IX+n),A instruction
        /// </summary>
        void RES_6_aIX_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 0);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The RES 7,(IX+n),A instruction
        /// </summary>
        void RES_7_aIX_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 0);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The RES 0,(IX+n),B instruction
        /// </summary>
        void RES_0_aIX_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 0);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The RES 1,(IX+n),B instruction
        /// </summary>
        void RES_1_aIX_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 0);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The RES 2,(IX+n),B instruction
        /// </summary>
        void RES_2_aIX_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 0);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The RES 3,(IX+n),B instruction
        /// </summary>
        void RES_3_aIX_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 0);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The RES 4,(IX+n),B instruction
        /// </summary>
        void RES_4_aIX_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 0);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The RES 5,(IX+n),B instruction
        /// </summary>
        void RES_5_aIX_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 0);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The RES 6,(IX+n),B instruction
        /// </summary>
        void RES_6_aIX_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 0);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The RES 7,(IX+n),B instruction
        /// </summary>
        void RES_7_aIX_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 0);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The RES 0,(IX+n),C instruction
        /// </summary>
        void RES_0_aIX_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 0);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The RES 1,(IX+n),C instruction
        /// </summary>
        void RES_1_aIX_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 0);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The RES 2,(IX+n),C instruction
        /// </summary>
        void RES_2_aIX_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 0);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The RES 3,(IX+n),C instruction
        /// </summary>
        void RES_3_aIX_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 0);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The RES 4,(IX+n),C instruction
        /// </summary>
        void RES_4_aIX_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 0);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The RES 5,(IX+n),C instruction
        /// </summary>
        void RES_5_aIX_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 0);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The RES 6,(IX+n),C instruction
        /// </summary>
        void RES_6_aIX_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 0);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The RES 7,(IX+n),C instruction
        /// </summary>
        void RES_7_aIX_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 0);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The RES 0,(IX+n),D instruction
        /// </summary>
        void RES_0_aIX_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 0);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The RES 1,(IX+n),D instruction
        /// </summary>
        void RES_1_aIX_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 0);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The RES 2,(IX+n),D instruction
        /// </summary>
        void RES_2_aIX_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 0);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The RES 3,(IX+n),D instruction
        /// </summary>
        void RES_3_aIX_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 0);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The RES 4,(IX+n),D instruction
        /// </summary>
        void RES_4_aIX_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 0);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The RES 5,(IX+n),D instruction
        /// </summary>
        void RES_5_aIX_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 0);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The RES 6,(IX+n),D instruction
        /// </summary>
        void RES_6_aIX_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 0);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The RES 7,(IX+n),D instruction
        /// </summary>
        void RES_7_aIX_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 0);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The RES 0,(IX+n),E instruction
        /// </summary>
        void RES_0_aIX_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 0);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The RES 1,(IX+n),E instruction
        /// </summary>
        void RES_1_aIX_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 0);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The RES 2,(IX+n),E instruction
        /// </summary>
        void RES_2_aIX_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 0);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The RES 3,(IX+n),E instruction
        /// </summary>
        void RES_3_aIX_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 0);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The RES 4,(IX+n),E instruction
        /// </summary>
        void RES_4_aIX_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 0);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The RES 5,(IX+n),E instruction
        /// </summary>
        void RES_5_aIX_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 0);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The RES 6,(IX+n),E instruction
        /// </summary>
        void RES_6_aIX_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 0);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The RES 7,(IX+n),E instruction
        /// </summary>
        void RES_7_aIX_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 0);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The RES 0,(IX+n),H instruction
        /// </summary>
        void RES_0_aIX_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 0);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The RES 1,(IX+n),H instruction
        /// </summary>
        void RES_1_aIX_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 0);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The RES 2,(IX+n),H instruction
        /// </summary>
        void RES_2_aIX_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 0);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The RES 3,(IX+n),H instruction
        /// </summary>
        void RES_3_aIX_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 0);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The RES 4,(IX+n),H instruction
        /// </summary>
        void RES_4_aIX_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 0);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The RES 5,(IX+n),H instruction
        /// </summary>
        void RES_5_aIX_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 0);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The RES 6,(IX+n),H instruction
        /// </summary>
        void RES_6_aIX_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 0);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The RES 7,(IX+n),H instruction
        /// </summary>
        void RES_7_aIX_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 0);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The RES 0,(IX+n),L instruction
        /// </summary>
        void RES_0_aIX_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 0);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The RES 1,(IX+n),L instruction
        /// </summary>
        void RES_1_aIX_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 0);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The RES 2,(IX+n),L instruction
        /// </summary>
        void RES_2_aIX_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 0);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The RES 3,(IX+n),L instruction
        /// </summary>
        void RES_3_aIX_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 0);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The RES 4,(IX+n),L instruction
        /// </summary>
        void RES_4_aIX_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 0);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The RES 5,(IX+n),L instruction
        /// </summary>
        void RES_5_aIX_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 0);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The RES 6,(IX+n),L instruction
        /// </summary>
        void RES_6_aIX_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 0);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The RES 7,(IX+n),L instruction
        /// </summary>
        void RES_7_aIX_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 0);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The RES 0,(IX+n) instruction
        /// </summary>
        void RES_0_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 0);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The RES 1,(IX+n) instruction
        /// </summary>
        void RES_1_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 0);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The RES 2,(IX+n) instruction
        /// </summary>
        void RES_2_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 0);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The RES 3,(IX+n) instruction
        /// </summary>
        void RES_3_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 0);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The RES 4,(IX+n) instruction
        /// </summary>
        void RES_4_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 0);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The RES 5,(IX+n) instruction
        /// </summary>
        void RES_5_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 0);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The RES 6,(IX+n) instruction
        /// </summary>
        void RES_6_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 0);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The RES 7,(IX+n) instruction
        /// </summary>
        void RES_7_aIX_plus_n(byte offset)
        {
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 0);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The SET 0,(IY+n),A instruction
        /// </summary>
        void SET_0_aIY_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 1);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The SET 1,(IY+n),A instruction
        /// </summary>
        void SET_1_aIY_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 1);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The SET 2,(IY+n),A instruction
        /// </summary>
        void SET_2_aIY_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 1);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The SET 3,(IY+n),A instruction
        /// </summary>
        void SET_3_aIY_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 1);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The SET 4,(IY+n),A instruction
        /// </summary>
        void SET_4_aIY_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 1);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The SET 5,(IY+n),A instruction
        /// </summary>
        void SET_5_aIY_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 1);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The SET 6,(IY+n),A instruction
        /// </summary>
        void SET_6_aIY_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 1);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The SET 7,(IY+n),A instruction
        /// </summary>
        void SET_7_aIY_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 1);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The SET 0,(IY+n),B instruction
        /// </summary>
        void SET_0_aIY_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 1);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The SET 1,(IY+n),B instruction
        /// </summary>
        void SET_1_aIY_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 1);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The SET 2,(IY+n),B instruction
        /// </summary>
        void SET_2_aIY_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 1);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The SET 3,(IY+n),B instruction
        /// </summary>
        void SET_3_aIY_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 1);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The SET 4,(IY+n),B instruction
        /// </summary>
        void SET_4_aIY_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 1);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The SET 5,(IY+n),B instruction
        /// </summary>
        void SET_5_aIY_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 1);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The SET 6,(IY+n),B instruction
        /// </summary>
        void SET_6_aIY_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 1);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The SET 7,(IY+n),B instruction
        /// </summary>
        void SET_7_aIY_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 1);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The SET 0,(IY+n),C instruction
        /// </summary>
        void SET_0_aIY_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 1);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The SET 1,(IY+n),C instruction
        /// </summary>
        void SET_1_aIY_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 1);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The SET 2,(IY+n),C instruction
        /// </summary>
        void SET_2_aIY_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 1);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The SET 3,(IY+n),C instruction
        /// </summary>
        void SET_3_aIY_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 1);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The SET 4,(IY+n),C instruction
        /// </summary>
        void SET_4_aIY_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 1);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The SET 5,(IY+n),C instruction
        /// </summary>
        void SET_5_aIY_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 1);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The SET 6,(IY+n),C instruction
        /// </summary>
        void SET_6_aIY_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 1);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The SET 7,(IY+n),C instruction
        /// </summary>
        void SET_7_aIY_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 1);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The SET 0,(IY+n),D instruction
        /// </summary>
        void SET_0_aIY_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 1);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The SET 1,(IY+n),D instruction
        /// </summary>
        void SET_1_aIY_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 1);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The SET 2,(IY+n),D instruction
        /// </summary>
        void SET_2_aIY_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 1);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The SET 3,(IY+n),D instruction
        /// </summary>
        void SET_3_aIY_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 1);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The SET 4,(IY+n),D instruction
        /// </summary>
        void SET_4_aIY_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 1);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The SET 5,(IY+n),D instruction
        /// </summary>
        void SET_5_aIY_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 1);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The SET 6,(IY+n),D instruction
        /// </summary>
        void SET_6_aIY_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 1);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The SET 7,(IY+n),D instruction
        /// </summary>
        void SET_7_aIY_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 1);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The SET 0,(IY+n),E instruction
        /// </summary>
        void SET_0_aIY_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 1);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The SET 1,(IY+n),E instruction
        /// </summary>
        void SET_1_aIY_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 1);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The SET 2,(IY+n),E instruction
        /// </summary>
        void SET_2_aIY_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 1);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The SET 3,(IY+n),E instruction
        /// </summary>
        void SET_3_aIY_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 1);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The SET 4,(IY+n),E instruction
        /// </summary>
        void SET_4_aIY_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 1);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The SET 5,(IY+n),E instruction
        /// </summary>
        void SET_5_aIY_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 1);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The SET 6,(IY+n),E instruction
        /// </summary>
        void SET_6_aIY_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 1);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The SET 7,(IY+n),E instruction
        /// </summary>
        void SET_7_aIY_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 1);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The SET 0,(IY+n),H instruction
        /// </summary>
        void SET_0_aIY_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 1);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The SET 1,(IY+n),H instruction
        /// </summary>
        void SET_1_aIY_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 1);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The SET 2,(IY+n),H instruction
        /// </summary>
        void SET_2_aIY_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 1);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The SET 3,(IY+n),H instruction
        /// </summary>
        void SET_3_aIY_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 1);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The SET 4,(IY+n),H instruction
        /// </summary>
        void SET_4_aIY_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 1);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The SET 5,(IY+n),H instruction
        /// </summary>
        void SET_5_aIY_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 1);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The SET 6,(IY+n),H instruction
        /// </summary>
        void SET_6_aIY_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 1);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The SET 7,(IY+n),H instruction
        /// </summary>
        void SET_7_aIY_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 1);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The SET 0,(IY+n),L instruction
        /// </summary>
        void SET_0_aIY_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 1);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The SET 1,(IY+n),L instruction
        /// </summary>
        void SET_1_aIY_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 1);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The SET 2,(IY+n),L instruction
        /// </summary>
        void SET_2_aIY_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 1);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The SET 3,(IY+n),L instruction
        /// </summary>
        void SET_3_aIY_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 1);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The SET 4,(IY+n),L instruction
        /// </summary>
        void SET_4_aIY_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 1);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The SET 5,(IY+n),L instruction
        /// </summary>
        void SET_5_aIY_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 1);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The SET 6,(IY+n),L instruction
        /// </summary>
        void SET_6_aIY_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 1);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The SET 7,(IY+n),L instruction
        /// </summary>
        void SET_7_aIY_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 1);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The SET 0,(IY+n) instruction
        /// </summary>
        void SET_0_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 1);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The SET 1,(IY+n) instruction
        /// </summary>
        void SET_1_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 1);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The SET 2,(IY+n) instruction
        /// </summary>
        void SET_2_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 1);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The SET 3,(IY+n) instruction
        /// </summary>
        void SET_3_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 1);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The SET 4,(IY+n) instruction
        /// </summary>
        void SET_4_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 1);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The SET 5,(IY+n) instruction
        /// </summary>
        void SET_5_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 1);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The SET 6,(IY+n) instruction
        /// </summary>
        void SET_6_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 1);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The SET 7,(IY+n) instruction
        /// </summary>
        void SET_7_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 1);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The RES 0,(IY+n),A instruction
        /// </summary>
        void RES_0_aIY_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 0);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The RES 1,(IY+n),A instruction
        /// </summary>
        void RES_1_aIY_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 0);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The RES 2,(IY+n),A instruction
        /// </summary>
        void RES_2_aIY_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 0);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The RES 3,(IY+n),A instruction
        /// </summary>
        void RES_3_aIY_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 0);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The RES 4,(IY+n),A instruction
        /// </summary>
        void RES_4_aIY_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 0);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The RES 5,(IY+n),A instruction
        /// </summary>
        void RES_5_aIY_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 0);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The RES 6,(IY+n),A instruction
        /// </summary>
        void RES_6_aIY_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 0);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The RES 7,(IY+n),A instruction
        /// </summary>
        void RES_7_aIY_plus_n_and_load_A(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 0);
            Memory[address] = newValue;
            A = newValue;
        }

        /// <summary>
        /// The RES 0,(IY+n),B instruction
        /// </summary>
        void RES_0_aIY_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 0);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The RES 1,(IY+n),B instruction
        /// </summary>
        void RES_1_aIY_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 0);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The RES 2,(IY+n),B instruction
        /// </summary>
        void RES_2_aIY_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 0);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The RES 3,(IY+n),B instruction
        /// </summary>
        void RES_3_aIY_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 0);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The RES 4,(IY+n),B instruction
        /// </summary>
        void RES_4_aIY_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 0);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The RES 5,(IY+n),B instruction
        /// </summary>
        void RES_5_aIY_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address]


                ;
            var newValue = oldValue.WithBit(5, 0);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The RES 6,(IY+n),B instruction
        /// </summary>
        void RES_6_aIY_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 0);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The RES 7,(IY+n),B instruction
        /// </summary>
        void RES_7_aIY_plus_n_and_load_B(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address]


                ;
            var newValue = oldValue.WithBit(7, 0);
            Memory[address] = newValue;
            B = newValue;
        }

        /// <summary>
        /// The RES 0,(IY+n),C instruction
        /// </summary>
        void RES_0_aIY_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 0);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The RES 1,(IY+n),C instruction
        /// </summary>
        void RES_1_aIY_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address]


                ;
            var newValue = oldValue.WithBit(1, 0);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The RES 2,(IY+n),C instruction
        /// </summary>
        void RES_2_aIY_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 0);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The RES 3,(IY+n),C instruction
        /// </summary>
        void RES_3_aIY_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 0);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The RES 4,(IY+n),C instruction
        /// </summary>
        void RES_4_aIY_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 0);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The RES 5,(IY+n),C instruction
        /// </summary>
        void RES_5_aIY_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 0);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The RES 6,(IY+n),C instruction
        /// </summary>
        void RES_6_aIY_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 0);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The RES 7,(IY+n),C instruction
        /// </summary>
        void RES_7_aIY_plus_n_and_load_C(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 0);
            Memory[address] = newValue;
            C = newValue;
        }

        /// <summary>
        /// The RES 0,(IY+n),D instruction
        /// </summary>
        void RES_0_aIY_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 0);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The RES 1,(IY+n),D instruction
        /// </summary>
        void RES_1_aIY_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 0);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The RES 2,(IY+n),D instruction
        /// </summary>
        void RES_2_aIY_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 0);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The RES 3,(IY+n),D instruction
        /// </summary>
        void RES_3_aIY_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 0);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The RES 4,(IY+n),D instruction
        /// </summary>
        void RES_4_aIY_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 0);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The RES 5,(IY+n),D instruction
        /// </summary>
        void RES_5_aIY_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 0);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The RES 6,(IY+n),D instruction
        /// </summary>
        void RES_6_aIY_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 0);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The RES 7,(IY+n),D instruction
        /// </summary>
        void RES_7_aIY_plus_n_and_load_D(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 0);
            Memory[address] = newValue;
            D = newValue;
        }

        /// <summary>
        /// The RES 0,(IY+n),E instruction
        /// </summary>
        void RES_0_aIY_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 0);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The RES 1,(IY+n),E instruction
        /// </summary>
        void RES_1_aIY_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 0);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The RES 2,(IY+n),E instruction
        /// </summary>
        void RES_2_aIY_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 0);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The RES 3,(IY+n),E instruction
        /// </summary>
        void RES_3_aIY_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 0);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The RES 4,(IY+n),E instruction
        /// </summary>
        void RES_4_aIY_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 0);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The RES 5,(IY+n),E instruction
        /// </summary>
        void RES_5_aIY_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 0);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The RES 6,(IY+n),E instruction
        /// </summary>
        void RES_6_aIY_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 0);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The RES 7,(IY+n),E instruction
        /// </summary>
        void RES_7_aIY_plus_n_and_load_E(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 0);
            Memory[address] = newValue;
            E = newValue;
        }

        /// <summary>
        /// The RES 0,(IY+n),H instruction
        /// </summary>
        void RES_0_aIY_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 0);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The RES 1,(IY+n),H instruction
        /// </summary>
        void RES_1_aIY_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 0);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The RES 2,(IY+n),H instruction
        /// </summary>
        void RES_2_aIY_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 0);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The RES 3,(IY+n),H instruction
        /// </summary>
        void RES_3_aIY_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 0);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The RES 4,(IY+n),H instruction
        /// </summary>
        void RES_4_aIY_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 0);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The RES 5,(IY+n),H instruction
        /// </summary>
        void RES_5_aIY_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 0);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The RES 6,(IY+n),H instruction
        /// </summary>
        void RES_6_aIY_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 0);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The RES 7,(IY+n),H instruction
        /// </summary>
        void RES_7_aIY_plus_n_and_load_H(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 0);
            Memory[address] = newValue;
            H = newValue;
        }

        /// <summary>
        /// The RES 0,(IY+n),L instruction
        /// </summary>
        void RES_0_aIY_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 0);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The RES 1,(IY+n),L instruction
        /// </summary>
        void RES_1_aIY_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 0);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The RES 2,(IY+n),L instruction
        /// </summary>
        void RES_2_aIY_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 0);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The RES 3,(IY+n),L instruction
        /// </summary>
        void RES_3_aIY_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 0);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The RES 4,(IY+n),L instruction
        /// </summary>
        void RES_4_aIY_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 0);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The RES 5,(IY+n),L instruction
        /// </summary>
        void RES_5_aIY_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 0);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The RES 6,(IY+n),L instruction
        /// </summary>
        void RES_6_aIY_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 0);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The RES 7,(IY+n),L instruction
        /// </summary>
        void RES_7_aIY_plus_n_and_load_L(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 0);
            Memory[address] = newValue;
            L = newValue;
        }

        /// <summary>
        /// The RES 0,(IY+n) instruction
        /// </summary>
        void RES_0_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(0, 0);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The RES 1,(IY+n) instruction
        /// </summary>
        void RES_1_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(1, 0);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The RES 2,(IY+n) instruction
        /// </summary>
        void RES_2_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(2, 0);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The RES 3,(IY+n) instruction
        /// </summary>
        void RES_3_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(3, 0);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The RES 4,(IY+n) instruction
        /// </summary>
        void RES_4_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(4, 0);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The RES 5,(IY+n) instruction
        /// </summary>
        void RES_5_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(5, 0);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The RES 6,(IY+n) instruction
        /// </summary>
        void RES_6_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(6, 0);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The RES 7,(IY+n) instruction
        /// </summary>
        void RES_7_aIY_plus_n(byte offset)
        {
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            var newValue = oldValue.WithBit(7, 0);
            Memory[address] = newValue;
        }
    }
}
