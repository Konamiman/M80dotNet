using System;

namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The LD A,(BC) instruction.
        /// </summary>
        void LD_A_aBC()
        {
            var address = (ushort)BC;
            var oldValue = Memory[address];
            A = oldValue;
        }

        /// <summary>
        /// The LD (BC),A instruction.
        /// </summary>
        void LD_aBC_A()
        {
            var newValue = A;
            var address = (ushort)BC;
            Memory[address] = newValue;
        }

        /// <summary>
        /// The LD A,(DE) instruction.
        /// </summary>
        void LD_A_aDE()
        {
            var address = (ushort)DE;
            var oldValue = Memory[address];
            A = oldValue;
        }

        /// <summary>
        /// The LD (DE),A instruction.
        /// </summary>
        void LD_aDE_A()
        {
            var newValue = A;
            var address = (ushort)DE;
            Memory[address] = newValue;
        }

        /// <summary>
        /// The LD A,(HL) instruction.
        /// </summary>
        void LD_A_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            A = oldValue;
        }

        /// <summary>
        /// The LD (HL),A instruction.
        /// </summary>
        void LD_aHL_A()
        {
            var newValue = A;
            var address = (ushort)HL;
            Memory[address] = newValue;
        }

        /// <summary>
        /// The LD B,(HL) instruction.
        /// </summary>
        void LD_B_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            B = oldValue;
        }

        /// <summary>
        /// The LD (HL),B instruction.
        /// </summary>
        void LD_aHL_B()
        {
            var newValue = B;
            var address = (ushort)HL;
            Memory[address] = newValue;
        }

        /// <summary>
        /// The LD C,(HL) instruction.
        /// </summary>
        void LD_C_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            C = oldValue;
        }

        /// <summary>
        /// The LD (HL),C instruction.
        /// </summary>
        void LD_aHL_C()
        {
            var newValue = C;
            var address = (ushort)HL;
            Memory[address] = newValue;
        }

        /// <summary>
        /// The LD D,(HL) instruction.
        /// </summary>
        void LD_D_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            D = oldValue;
        }

        /// <summary>
        /// The LD (HL),D instruction.
        /// </summary>
        void LD_aHL_D()
        {
            var newValue = D;
            var address = (ushort)HL;
            Memory[address] = newValue;
        }

        /// <summary>
        /// The LD E,(HL) instruction.
        /// </summary>
        void LD_E_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            E = oldValue;
        }

        /// <summary>
        /// The LD (HL),E instruction.
        /// </summary>
        void LD_aHL_E()
        {
            var newValue = E;
            var address = (ushort)HL;
            Memory[address] = newValue;
        }

        /// <summary>
        /// The LD H,(HL) instruction.
        /// </summary>
        void LD_H_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            H = oldValue;
        }

        /// <summary>
        /// The LD (HL),H instruction.
        /// </summary>
        void LD_aHL_H()
        {
            var newValue = H;
            var address = (ushort)HL;
            Memory[address] = newValue;
        }

        /// <summary>
        /// The LD L,(HL) instruction.
        /// </summary>
        void LD_L_aHL()
        {
            var address = (ushort)HL;
            var oldValue = Memory[address];
            L = oldValue;
        }

        /// <summary>
        /// The LD (HL),L instruction.
        /// </summary>
        void LD_aHL_L()
        {
            var newValue = L;
            var address = (ushort)HL;
            Memory[address] = newValue;
        }

        /// <summary>
        /// The LD A,(IX+n) instruction.
        /// </summary>
        void LD_A_aIX_plus_n()
        {
            var offset = Memory[PC++];
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            A = oldValue;
        }

        /// <summary>
        /// The LD (IX+n),A instruction.
        /// </summary>
        void LD_aIX_plus_n_A()
        {
            var offset = Memory[PC++];
            var newValue = A;
            var address = (ushort)(IX + (SByte)offset);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The LD B,(IX+n) instruction.
        /// </summary>
        void LD_B_aIX_plus_n()
        {
            var offset = Memory[PC++];
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            B = oldValue;
        }

        /// <summary>
        /// The LD (IX+n),B instruction.
        /// </summary>
        void LD_aIX_plus_n_B()
        {
            var offset = Memory[PC++];
            var newValue = B;
            var address = (ushort)(IX + (SByte)offset);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The LD C,(IX+n) instruction.
        /// </summary>
        void LD_C_aIX_plus_n()
        {
            var offset = Memory[PC++];
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            C = oldValue;
        }

        /// <summary>
        /// The LD (IX+n),C instruction.
        /// </summary>
        void LD_aIX_plus_n_C()
        {
            var offset = Memory[PC++];
            var newValue = C;
            var address = (ushort)(IX + (SByte)offset);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The LD D,(IX+n) instruction.
        /// </summary>
        void LD_D_aIX_plus_n()
        {
            var offset = Memory[PC++];
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            D = oldValue;
        }

        /// <summary>
        /// The LD (IX+n),D instruction.
        /// </summary>
        void LD_aIX_plus_n_D()
        {
            var offset = Memory[PC++];
            var newValue = D;
            var address = (ushort)(IX + (SByte)offset);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The LD E,(IX+n) instruction.
        /// </summary>
        void LD_E_aIX_plus_n()
        {
            var offset = Memory[PC++];
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            E = oldValue;
        }

        /// <summary>
        /// The LD (IX+n),E instruction.
        /// </summary>
        void LD_aIX_plus_n_E()
        {
            var offset = Memory[PC++];
            var newValue = E;
            var address = (ushort)(IX + (SByte)offset);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The LD H,(IX+n) instruction.
        /// </summary>
        void LD_H_aIX_plus_n()
        {
            var offset = Memory[PC++];
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            H = oldValue;
        }

        /// <summary>
        /// The LD (IX+n),H instruction.
        /// </summary>
        void LD_aIX_plus_n_H()
        {
            var offset = Memory[PC++];
            var newValue = H;
            var address = (ushort)(IX + (SByte)offset);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The LD L,(IX+n) instruction.
        /// </summary>
        void LD_L_aIX_plus_n()
        {
            var offset = Memory[PC++];
            var address = (ushort)(IX + (SByte)offset);
            var oldValue = Memory[address];
            L = oldValue;
        }

        /// <summary>
        /// The LD (IX+n),L instruction.
        /// </summary>
        void LD_aIX_plus_n_L()
        {
            var offset = Memory[PC++];
            var newValue = L;
            var address = (ushort)(IX + (SByte)offset);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The LD A,(IY+n) instruction.
        /// </summary>
        void LD_A_aIY_plus_n()
        {
            var offset = Memory[PC++];
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            A = oldValue;
        }

        /// <summary>
        /// The LD (IY+n),A instruction.
        /// </summary>
        void LD_aIY_plus_n_A()
        {
            var offset = Memory[PC++];
            var newValue = A;
            var address = (ushort)(IY + (SByte)offset);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The LD B,(IY+n) instruction.
        /// </summary>
        void LD_B_aIY_plus_n()
        {
            var offset = Memory[PC++];
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            B = oldValue;
        }

        /// <summary>
        /// The LD (IY+n),B instruction.
        /// </summary>
        void LD_aIY_plus_n_B()
        {
            var offset = Memory[PC++];
            var newValue = B;
            var address = (ushort)(IY + (SByte)offset);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The LD C,(IY+n) instruction.
        /// </summary>
        void LD_C_aIY_plus_n()
        {
            var offset = Memory[PC++];
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            C = oldValue;
        }

        /// <summary>
        /// The LD (IY+n),C instruction.
        /// </summary>
        void LD_aIY_plus_n_C()
        {
            var offset = Memory[PC++];
            var newValue = C;
            var address = (ushort)(IY + (SByte)offset);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The LD D,(IY+n) instruction.
        /// </summary>
        void LD_D_aIY_plus_n()
        {
            var offset = Memory[PC++];
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            D = oldValue;
        }

        /// <summary>
        /// The LD (IY+n),D instruction.
        /// </summary>
        void LD_aIY_plus_n_D()
        {
            var offset = Memory[PC++];
            var newValue = D;
            var address = (ushort)(IY + (SByte)offset);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The LD E,(IY+n) instruction.
        /// </summary>
        void LD_E_aIY_plus_n()
        {
            var offset = Memory[PC++];
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            E = oldValue;
        }

        /// <summary>
        /// The LD (IY+n),E instruction.
        /// </summary>
        void LD_aIY_plus_n_E()
        {
            var offset = Memory[PC++];
            var newValue = E;
            var address = (ushort)(IY + (SByte)offset);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The LD H,(IY+n) instruction.
        /// </summary>
        void LD_H_aIY_plus_n()
        {
            var offset = Memory[PC++];
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            H = oldValue;
        }

        /// <summary>
        /// The LD (IY+n),H instruction.
        /// </summary>
        void LD_aIY_plus_n_H()
        {
            var offset = Memory[PC++];
            var newValue = H;
            var address = (ushort)(IY + (SByte)offset);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The LD L,(IY+n) instruction.
        /// </summary>
        void LD_L_aIY_plus_n()
        {
            var offset = Memory[PC++];
            var address = (ushort)(IY + (SByte)offset);
            var oldValue = Memory[address];
            L = oldValue;
        }

        /// <summary>
        /// The LD (IY+n),L instruction.
        /// </summary>
        void LD_aIY_plus_n_L()
        {
            var offset = Memory[PC++];
            var newValue = L;
            var address = (ushort)(IY + (SByte)offset);
            Memory[address] = newValue;
        }
    }
}
