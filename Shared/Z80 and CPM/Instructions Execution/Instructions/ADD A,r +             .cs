using System;

namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The ADC A,A instruction.
		/// </summary>
		private void ADC_A_A()
        {
            var oldValue = A;
            var valueToAdd = A;
            var newValueInt = (int)oldValue + (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SBC A,A instruction.
		/// </summary>
		private void SBC_A_A()
        {
            var oldValue = A;
            var valueToAdd = A;
            var newValueInt = (int)oldValue - (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The ADD A,A instruction.
		/// </summary>
		private void ADD_A_A()
        {
            var oldValue = A;
            var valueToAdd = A;
            var newValueInt = (int)oldValue + (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SUB A instruction.
		/// </summary>
		private void SUB_A()
        {
            var oldValue = A;
            var valueToAdd = A;
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The CP A instruction.
		/// </summary>
		private void CP_A()
        {
            var oldValue = A;
            var valueToAdd = A;
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
            //SetFlags3and5From(valueToAdd);
        }

        /// <summary>
		/// The CPI instruction.
        /// </summary>
		private void CPI()
        {
            var oldValue = A;
            var valueToAdd = Memory[(ushort)HL];
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            var counter = BC;
            HL++;
            counter--;
            BC = counter;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            PF = (BC != 0) ? 1 : 0;
            NF = 1;
        }

        /// <summary>
		/// The CPD instruction.
        /// </summary>
		private void CPD()
        {
            var oldValue = A;
            var valueToAdd = Memory[(ushort)HL];
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            var counter = BC;
            HL--;
            counter--;
            BC = counter;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            PF = (BC != 0) ? 1 : 0;
            NF = 1;
        }

        /// <summary>
		/// The CPIR instruction.
        /// </summary>
		private void CPIR()
        {
            var oldValue = A;
            var valueToAdd = Memory[(ushort)HL];
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            var counter = BC;
            HL++;
            counter--;
            BC = counter;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            PF = (BC != 0) ? 1 : 0;
            NF = 1;

            if (counter != 0 && ZF == 0)
            {
                PC = (ushort)(PC - 2);
            }
        }

        /// <summary>
		/// The CPDR instruction.
        /// </summary>
		private void CPDR()
        {
            var oldValue = A;
            var valueToAdd = Memory[(ushort)HL];
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            var counter = BC;
            HL--;
            counter--;
            BC = counter;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            PF = (BC != 0) ? 1 : 0;
            NF = 1;

            if (counter != 0 && ZF == 0)
            {
                PC = (ushort)(PC - 2);
            }
        }

        /// <summary>
        /// The ADC A,B instruction.
		/// </summary>
		private void ADC_A_B()
        {
            var oldValue = A;
            var valueToAdd = B;
            var newValueInt = (int)oldValue + (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SBC A,B instruction.
		/// </summary>
		private void SBC_A_B()
        {
            var oldValue = A;
            var valueToAdd = B;
            var newValueInt = (int)oldValue - (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The ADD A,B instruction.
		/// </summary>
		private void ADD_A_B()
        {
            var oldValue = A;
            var valueToAdd = B;
            var newValueInt = (int)oldValue + (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SUB B instruction.
		/// </summary>
		private void SUB_B()
        {
            var oldValue = A;
            var valueToAdd = B;
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The CP B instruction.
		/// </summary>
		private void CP_B()
        {
            var oldValue = A;
            var valueToAdd = B;
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
            //SetFlags3and5From(valueToAdd);
        }

        /// <summary>
        /// The ADC A,C instruction.
		/// </summary>
		private void ADC_A_C()
        {
            var oldValue = A;
            var valueToAdd = C;
            var newValueInt = (int)oldValue + (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SBC A,C instruction.
		/// </summary>
		private void SBC_A_C()
        {
            var oldValue = A;
            var valueToAdd = C;
            var newValueInt = (int)oldValue - (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The ADD A,C instruction.
		/// </summary>
		private void ADD_A_C()
        {
            var oldValue = A;
            var valueToAdd = C;
            var newValueInt = (int)oldValue + (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SUB C instruction.
		/// </summary>
		private void SUB_C()
        {
            var oldValue = A;
            var valueToAdd = C;
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The CP C instruction.
		/// </summary>
		private void CP_C()
        {
            var oldValue = A;
            var valueToAdd = C;
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
            //SetFlags3and5From(valueToAdd);
        }

        /// <summary>
        /// The ADC A,D instruction.
		/// </summary>
		private void ADC_A_D()
        {
            var oldValue = A;
            var valueToAdd = D;
            var newValueInt = (int)oldValue + (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SBC A,D instruction.
		/// </summary>
		private void SBC_A_D()
        {
            var oldValue = A;
            var valueToAdd = D;
            var newValueInt = (int)oldValue - (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The ADD A,D instruction.
		/// </summary>
		private void ADD_A_D()
        {
            var oldValue = A;
            var valueToAdd = D;
            var newValueInt = (int)oldValue + (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SUB D instruction.
		/// </summary>
		private void SUB_D()
        {
            var oldValue = A;
            var valueToAdd = D;
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The CP D instruction.
		/// </summary>
		private void CP_D()
        {
            var oldValue = A;
            var valueToAdd = D;
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
            //SetFlags3and5From(valueToAdd);
        }

        /// <summary>
        /// The ADC A,E instruction.
		/// </summary>
		private void ADC_A_E()
        {
            var oldValue = A;
            var valueToAdd = E;
            var newValueInt = (int)oldValue + (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SBC A,E instruction.
		/// </summary>
		private void SBC_A_E()
        {
            var oldValue = A;
            var valueToAdd = E;
            var newValueInt = (int)oldValue - (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The ADD A,E instruction.
		/// </summary>
		private void ADD_A_E()
        {
            var oldValue = A;
            var valueToAdd = E;
            var newValueInt = (int)oldValue + (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SUB E instruction.
		/// </summary>
		private void SUB_E()
        {
            var oldValue = A;
            var valueToAdd = E;
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The CP E instruction.
		/// </summary>
		private void CP_E()
        {
            var oldValue = A;
            var valueToAdd = E;
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
            //SetFlags3and5From(valueToAdd);
        }

        /// <summary>
        /// The ADC A,H instruction.
		/// </summary>
		private void ADC_A_H()
        {
            var oldValue = A;
            var valueToAdd = H;
            var newValueInt = (int)oldValue + (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SBC A,H instruction.
		/// </summary>
		private void SBC_A_H()
        {
            var oldValue = A;
            var valueToAdd = H;
            var newValueInt = (int)oldValue - (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The ADD A,H instruction.
		/// </summary>
		private void ADD_A_H()
        {
            var oldValue = A;
            var valueToAdd = H;
            var newValueInt = (int)oldValue + (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SUB H instruction.
		/// </summary>
		private void SUB_H()
        {
            var oldValue = A;
            var valueToAdd = H;
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The CP H instruction.
		/// </summary>
		private void CP_H()
        {
            var oldValue = A;
            var valueToAdd = H;
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
            //SetFlags3and5From(valueToAdd);
        }

        /// <summary>
        /// The ADC A,L instruction.
		/// </summary>
		private void ADC_A_L()
        {
            var oldValue = A;
            var valueToAdd = L;
            var newValueInt = (int)oldValue + (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SBC A,L instruction.
		/// </summary>
		private void SBC_A_L()
        {
            var oldValue = A;
            var valueToAdd = L;
            var newValueInt = (int)oldValue - (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The ADD A,L instruction.
		/// </summary>
		private void ADD_A_L()
        {
            var oldValue = A;
            var valueToAdd = L;
            var newValueInt = (int)oldValue + (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SUB L instruction.
		/// </summary>
		private void SUB_L()
        {
            var oldValue = A;
            var valueToAdd = L;
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The CP L instruction.
		/// </summary>
		private void CP_L()
        {
            var oldValue = A;
            var valueToAdd = L;
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
            //SetFlags3and5From(valueToAdd);
        }

        /// <summary>
        /// The ADC A,(HL) instruction.
		/// </summary>
		private void ADC_A_aHL()
        {
            var oldValue = A;
            var address = (ushort)HL;
            var valueToAdd = Memory[address];
            var newValueInt = (int)oldValue + (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SBC A,(HL) instruction.
		/// </summary>
		private void SBC_A_aHL()
        {
            var oldValue = A;
            var address = (ushort)HL;
            var valueToAdd = Memory[address];
            var newValueInt = (int)oldValue - (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The ADD A,(HL) instruction.
		/// </summary>
		private void ADD_A_aHL()
        {
            var oldValue = A;
            var address = (ushort)HL;
            var valueToAdd = Memory[address];
            var newValueInt = (int)oldValue + (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SUB (HL) instruction.
		/// </summary>
		private void SUB_aHL()
        {
            var oldValue = A;
            var address = (ushort)HL;
            var valueToAdd = Memory[address];
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The CP (HL) instruction.
		/// </summary>
		private void CP_aHL()
        {
            var oldValue = A;
            var address = (ushort)HL;
            var valueToAdd = Memory[address];
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
            //SetFlags3and5From(valueToAdd);
        }

        /// <summary>
        /// The ADC A,n instruction.
		/// </summary>
		private void ADC_A_n()
        {
            var valueToAdd = Memory[PC++];
            var oldValue = A;
            var newValueInt = (int)oldValue + (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SBC A,n instruction.
		/// </summary>
		private void SBC_A_n()
        {
            var valueToAdd = Memory[PC++];
            var oldValue = A;
            var newValueInt = (int)oldValue - (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The ADD A,n instruction.
		/// </summary>
		private void ADD_A_n()
        {
            var valueToAdd = Memory[PC++];
            var oldValue = A;
            var newValueInt = (int)oldValue + (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SUB n instruction.
		/// </summary>
		private void SUB_n()
        {
            var valueToAdd = Memory[PC++];
            var oldValue = A;
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The CP n instruction.
		/// </summary>
		private void CP_n()
        {
            var valueToAdd = Memory[PC++];
            var oldValue = A;
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
            //SetFlags3and5From(valueToAdd);
        }

        /// <summary>
        /// The ADC A,IXH instruction.
		/// </summary>
		private void ADC_A_IXH()
        {
            var oldValue = A;
            var valueToAdd = IXH;
            var newValueInt = (int)oldValue + (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SBC A,IXH instruction.
		/// </summary>
		private void SBC_A_IXH()
        {
            var oldValue = A;
            var valueToAdd = IXH;
            var newValueInt = (int)oldValue - (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The ADD A,IXH instruction.
		/// </summary>
		private void ADD_A_IXH()
        {
            var oldValue = A;
            var valueToAdd = IXH;
            var newValueInt = (int)oldValue + (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SUB IXH instruction.
		/// </summary>
		private void SUB_IXH()
        {
            var oldValue = A;
            var valueToAdd = IXH;
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The CP IXH instruction.
		/// </summary>
		private void CP_IXH()
        {
            var oldValue = A;
            var valueToAdd = IXH;
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
            //SetFlags3and5From(valueToAdd);
        }

        /// <summary>
        /// The ADC A,IXL instruction.
		/// </summary>
		private void ADC_A_IXL()
        {
            var oldValue = A;
            var valueToAdd = IXL;
            var newValueInt = (int)oldValue + (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SBC A,IXL instruction.
		/// </summary>
		private void SBC_A_IXL()
        {
            var oldValue = A;
            var valueToAdd = IXL;
            var newValueInt = (int)oldValue - (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The ADD A,IXL instruction.
		/// </summary>
		private void ADD_A_IXL()
        {
            var oldValue = A;
            var valueToAdd = IXL;
            var newValueInt = (int)oldValue + (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SUB IXL instruction.
		/// </summary>
		private void SUB_IXL()
        {
            var oldValue = A;
            var valueToAdd = IXL;
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The CP IXL instruction.
		/// </summary>
		private void CP_IXL()
        {
            var oldValue = A;
            var valueToAdd = IXL;
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
            //SetFlags3and5From(valueToAdd);
        }

        /// <summary>
        /// The ADC A,IYH instruction.
		/// </summary>
		private void ADC_A_IYH()
        {
            var oldValue = A;
            var valueToAdd = IYH;
            var newValueInt = (int)oldValue + (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SBC A,IYH instruction.
		/// </summary>
		private void SBC_A_IYH()
        {
            var oldValue = A;
            var valueToAdd = IYH;
            var newValueInt = (int)oldValue - (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The ADD A,IYH instruction.
		/// </summary>
		private void ADD_A_IYH()
        {
            var oldValue = A;
            var valueToAdd = IYH;
            var newValueInt = (int)oldValue + (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SUB IYH instruction.
		/// </summary>
		private void SUB_IYH()
        {
            var oldValue = A;
            var valueToAdd = IYH;
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The CP IYH instruction.
		/// </summary>
		private void CP_IYH()
        {
            var oldValue = A;
            var valueToAdd = IYH;
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
            //SetFlags3and5From(valueToAdd);
        }

        /// <summary>
        /// The ADC A,IYL instruction.
		/// </summary>
		private void ADC_A_IYL()
        {
            var oldValue = A;
            var valueToAdd = IYL;
            var newValueInt = (int)oldValue + (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SBC A,IYL instruction.
		/// </summary>
		private void SBC_A_IYL()
        {
            var oldValue = A;
            var valueToAdd = IYL;
            var newValueInt = (int)oldValue - (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The ADD A,IYL instruction.
		/// </summary>
		private void ADD_A_IYL()
        {
            var oldValue = A;
            var valueToAdd = IYL;
            var newValueInt = (int)oldValue + (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SUB IYL instruction.
		/// </summary>
		private void SUB_IYL()
        {
            var oldValue = A;
            var valueToAdd = IYL;
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The CP IYL instruction.
		/// </summary>
		private void CP_IYL()
        {
            var oldValue = A;
            var valueToAdd = IYL;
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
            //SetFlags3and5From(valueToAdd);
        }

        /// <summary>
        /// The ADC A,(IX+n) instruction.
		/// </summary>
		private void ADC_A_aIX_plus_n()
        {
            var offset = Memory[PC++];
            var oldValue = A;
            var address = (ushort)(IX + (SByte)offset);
            var valueToAdd = Memory[address];
            var newValueInt = (int)oldValue + (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SBC A,(IX+n) instruction.
		/// </summary>
		private void SBC_A_aIX_plus_n()
        {
            var offset = Memory[PC++];
            var oldValue = A;
            var address = (ushort)(IX + (SByte)offset);
            var valueToAdd = Memory[address];
            var newValueInt = (int)oldValue - (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The ADD A,(IX+n) instruction.
		/// </summary>
		private void ADD_A_aIX_plus_n()
        {
            var offset = Memory[PC++];
            var oldValue = A;
            var address = (ushort)(IX + (SByte)offset);
            var valueToAdd = Memory[address];
            var newValueInt = (int)oldValue + (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SUB (IX+n) instruction.
		/// </summary>
		private void SUB_aIX_plus_n()
        {
            var offset = Memory[PC++];
            var oldValue = A;
            var address = (ushort)(IX + (SByte)offset);
            var valueToAdd = Memory[address];
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The CP (IX+n) instruction.
		/// </summary>
		private void CP_aIX_plus_n()
        {
            var offset = Memory[PC++];
            var oldValue = A;
            var address = (ushort)(IX + (SByte)offset);
            var valueToAdd = Memory[address];
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
            //SetFlags3and5From(valueToAdd);
        }

        /// <summary>
        /// The ADC A,(IY+n) instruction.
		/// </summary>
		private void ADC_A_aIY_plus_n()
        {
            var offset = Memory[PC++];
            var oldValue = A;
            var address = (ushort)(IY + (SByte)offset);
            var valueToAdd = Memory[address];
            var newValueInt = (int)oldValue + (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SBC A,(IY+n) instruction.
		/// </summary>
		private void SBC_A_aIY_plus_n()
        {
            var offset = Memory[PC++];
            var oldValue = A;
            var address = (ushort)(IY + (SByte)offset);
            var valueToAdd = Memory[address];
            var newValueInt = (int)oldValue - (valueToAdd + CF);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The ADD A,(IY+n) instruction.
		/// </summary>
		private void ADD_A_aIY_plus_n()
        {
            var offset = Memory[PC++];
            var oldValue = A;
            var address = (ushort)(IY + (SByte)offset);
            var valueToAdd = Memory[address];
            var newValueInt = (int)oldValue + (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd ^ 0x80) & (valueToAdd ^ newValue) & 0x80;
            NF = 0;
        }

        /// <summary>
        /// The SUB (IY+n) instruction.
		/// </summary>
		private void SUB_aIY_plus_n()
        {
            var offset = Memory[PC++];
            var oldValue = A;
            var address = (ushort)(IY + (SByte)offset);
            var valueToAdd = Memory[address];
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);
            A = newValue;

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }

        /// <summary>
        /// The CP (IY+n) instruction.
		/// </summary>
		private void CP_aIY_plus_n()
        {
            var offset = Memory[PC++];
            var oldValue = A;
            var address = (ushort)(IY + (SByte)offset);
            var valueToAdd = Memory[address];
            var newValueInt = (int)oldValue - (valueToAdd);
            var newValue = (byte)(newValueInt & 0xFF);

            SF = newValue & 0x80;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x10;
            CF = (newValueInt & 0x100);
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x80;
            NF = 1;
        }
    }
}