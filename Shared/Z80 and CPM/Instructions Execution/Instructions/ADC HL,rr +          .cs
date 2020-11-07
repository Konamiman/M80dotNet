namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The ADC HL,BC instruction
        /// </summary>
        void ADC_HL_BC()
        {
            var oldValue = HL;
            var valueToAdd = BC;
            var newValueInt = (ushort)oldValue + (ushort)valueToAdd + CF;
            var newValue = (short)(newValueInt & 0xFFFF);
            HL = newValue;

            SF = newValue & 0x8000;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x1000;
            CF = newValueInt & 0x10000;
            PF = (oldValue ^ valueToAdd ^ 0x8000) & (valueToAdd ^ newValue) & 0x8000;

            NF = 0;
        }

        /// <summary>
        /// The SBC HL,BC instruction
        /// </summary>
        void SBC_HL_BC()
        {
            var oldValue = HL;
            var valueToAdd = BC;
            var newValueInt = (ushort)oldValue - (ushort)valueToAdd - CF;
            var newValue = (short)(newValueInt & 0xFFFF);
            HL = newValue;

            SF = newValue & 0x8000;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x1000;
            CF = newValueInt & 0x10000;
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x8000;

            NF = 1;
        }

        /// <summary>
        /// The ADC HL,DE instruction
        /// </summary>
        void ADC_HL_DE()
        {
            var oldValue = HL;
            var valueToAdd = DE;
            var newValueInt = (ushort)oldValue + (ushort)valueToAdd + CF;
            var newValue = (short)(newValueInt & 0xFFFF);
            HL = newValue;

            SF = newValue & 0x8000;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x1000;
            CF = newValueInt & 0x10000;
            PF = (oldValue ^ valueToAdd ^ 0x8000) & (valueToAdd ^ newValue) & 0x8000;

            NF = 0;
        }

        /// <summary>
        /// The SBC HL,DE instruction
        /// </summary>
        void SBC_HL_DE()
        {
            var oldValue = HL;
            var valueToAdd = DE;
            var newValueInt = (ushort)oldValue - (ushort)valueToAdd - CF;
            var newValue = (short)(newValueInt & 0xFFFF);
            HL = newValue;

            SF = newValue & 0x8000;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x1000;
            CF = newValueInt & 0x10000;
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x8000;

            NF = 1;
        }

        /// <summary>
        /// The ADC HL,HL instruction
        /// </summary>
        void ADC_HL_HL()
        {
            var oldValue = HL;
            var valueToAdd = HL;
            var newValueInt = (ushort)oldValue + (ushort)valueToAdd + CF;
            var newValue = (short)(newValueInt & 0xFFFF);
            HL = newValue;

            SF = newValue & 0x8000;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x1000;
            CF = newValueInt & 0x10000;
            PF = (oldValue ^ valueToAdd ^ 0x8000) & (valueToAdd ^ newValue) & 0x8000;

            NF = 0;
        }

        /// <summary>
        /// The SBC HL,HL instruction
        /// </summary>
        void SBC_HL_HL()
        {
            var oldValue = HL;
            var valueToAdd = HL;
            var newValueInt = (ushort)oldValue - (ushort)valueToAdd - CF;
            var newValue = (short)(newValueInt & 0xFFFF);
            HL = newValue;

            SF = newValue & 0x8000;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x1000;
            CF = newValueInt & 0x10000;
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x8000;

            NF = 1;
        }

        /// <summary>
        /// The ADC HL,SP instruction
        /// </summary>
        void ADC_HL_SP()
        {
            var oldValue = HL;
            var valueToAdd = SP;
            var newValueInt = (ushort)oldValue + (ushort)valueToAdd + CF;
            var newValue = (short)(newValueInt & 0xFFFF);
            HL = newValue;

            SF = newValue & 0x8000;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x1000;
            CF = newValueInt & 0x10000;
            PF = (oldValue ^ valueToAdd ^ 0x8000) & (valueToAdd ^ newValue) & 0x8000;

            NF = 0;
        }

        /// <summary>
        /// The SBC HL,SP instruction
        /// </summary>
        void SBC_HL_SP()
        {
            var oldValue = HL;
            var valueToAdd = SP;
            var newValueInt = (ushort)oldValue - (ushort)valueToAdd - CF;
            var newValue = (short)(newValueInt & 0xFFFF);
            HL = newValue;

            SF = newValue & 0x8000;
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue ^ valueToAdd) & 0x1000;
            CF = newValueInt & 0x10000;
            PF = (oldValue ^ valueToAdd) & (oldValue ^ newValue) & 0x8000;

            NF = 1;
        }
    }
}
