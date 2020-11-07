namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The ADD HL,BC instruction
        /// </summary>
        void ADD_HL_BC()
        {
            var oldValue = HL;
            var valueToAdd = BC;
            var newValueInt = (ushort)oldValue + (ushort)valueToAdd;
            var newValue = (short)(newValueInt & 0xFFFF);
            HL = newValue;

            HF = (oldValue ^ newValue ^ valueToAdd) & 0x1000;
            CF = newValueInt & 0x10000;
            NF = 0;
        }

        /// <summary>
        /// The ADD HL,DE instruction
        /// </summary>
        void ADD_HL_DE()
        {
            var oldValue = HL;
            var valueToAdd = DE;
            var newValueInt = (ushort)oldValue + (ushort)valueToAdd;
            var newValue = (short)(newValueInt & 0xFFFF);
            HL = newValue;

            HF = (oldValue ^ newValue ^ valueToAdd) & 0x1000;
            CF = newValueInt & 0x10000;
            NF = 0;
        }

        /// <summary>
        /// The ADD HL,HL instruction
        /// </summary>
        void ADD_HL_HL()
        {
            var oldValue = HL;
            var valueToAdd = HL;
            var newValueInt = (ushort)oldValue + (ushort)valueToAdd;
            var newValue = (short)(newValueInt & 0xFFFF);
            HL = newValue;

            HF = (oldValue ^ newValue ^ valueToAdd) & 0x1000;
            CF = newValueInt & 0x10000;
            NF = 0;
        }

        /// <summary>
        /// The ADD HL,SP instruction
        /// </summary>
        void ADD_HL_SP()
        {
            var oldValue = HL;
            var valueToAdd = SP;
            var newValueInt = (ushort)oldValue + (ushort)valueToAdd;
            var newValue = (short)(newValueInt & 0xFFFF);
            HL = newValue;

            HF = (oldValue ^ newValue ^ valueToAdd) & 0x1000;
            CF = newValueInt & 0x10000;
            NF = 0;
        }

        /// <summary>
        /// The ADD IX,BC instruction
        /// </summary>
        void ADD_IX_BC()
        {
            var oldValue = IX;
            var valueToAdd = BC;
            var newValueInt = (ushort)oldValue + (ushort)valueToAdd;
            var newValue = (short)(newValueInt & 0xFFFF);
            IX = newValue;

            HF = (oldValue ^ newValue ^ valueToAdd) & 0x1000;
            CF = newValueInt & 0x10000;
            NF = 0;
        }

        /// <summary>
        /// The ADD IX,DE instruction
        /// </summary>
        void ADD_IX_DE()
        {
            var oldValue = IX;
            var valueToAdd = DE;
            var newValueInt = (ushort)oldValue + (ushort)valueToAdd;
            var newValue = (short)(newValueInt & 0xFFFF);
            IX = newValue;

            HF = (oldValue ^ newValue ^ valueToAdd) & 0x1000;
            CF = newValueInt & 0x10000;
            NF = 0;
        }

        /// <summary>
        /// The ADD IX,IX instruction
        /// </summary>
        void ADD_IX_IX()
        {
            var oldValue = IX;
            var valueToAdd = IX;
            var newValueInt = (ushort)oldValue + (ushort)valueToAdd;
            var newValue = (short)(newValueInt & 0xFFFF);
            IX = newValue;

            HF = (oldValue ^ newValue ^ valueToAdd) & 0x1000;
            CF = newValueInt & 0x10000;
            NF = 0;
        }

        /// <summary>
        /// The ADD IX,SP instruction
        /// </summary>
        void ADD_IX_SP()
        {
            var oldValue = IX;
            var valueToAdd = SP;
            var newValueInt = (ushort)oldValue + (ushort)valueToAdd;
            var newValue = (short)(newValueInt & 0xFFFF);
            IX = newValue;

            HF = (oldValue ^ newValue ^ valueToAdd) & 0x1000;
            CF = newValueInt & 0x10000;
            NF = 0;
        }

        /// <summary>
        /// The ADD IY,BC instruction
        /// </summary>
        void ADD_IY_BC()
        {
            var oldValue = IY;
            var valueToAdd = BC;
            var newValueInt = (ushort)oldValue + (ushort)valueToAdd;
            var newValue = (short)(newValueInt & 0xFFFF);
            IY = newValue;

            HF = (oldValue ^ newValue ^ valueToAdd) & 0x1000;
            CF = newValueInt & 0x10000;
            NF = 0;
        }

        /// <summary>
        /// The ADD IY,DE instruction
        /// </summary>
        void ADD_IY_DE()
        {
            var oldValue = IY;
            var valueToAdd = DE;
            var newValueInt = (ushort)oldValue + (ushort)valueToAdd;
            var newValue = (short)(newValueInt & 0xFFFF);
            IY = newValue;

            HF = (oldValue ^ newValue ^ valueToAdd) & 0x1000;
            CF = newValueInt & 0x10000;
            NF = 0;
        }

        /// <summary>
        /// The ADD IY,IY instruction
        /// </summary>
        void ADD_IY_IY()
        {
            var oldValue = IY;
            var valueToAdd = IY;
            var newValueInt = (ushort)oldValue + (ushort)valueToAdd;
            var newValue = (short)(newValueInt & 0xFFFF);
            IY = newValue;

            HF = (oldValue ^ newValue ^ valueToAdd) & 0x1000;
            CF = newValueInt & 0x10000;
            NF = 0;
        }

        /// <summary>
        /// The ADD IY,SP instruction
        /// </summary>
        void ADD_IY_SP()
        {
            var oldValue = IY;
            var valueToAdd = SP;
            var newValueInt = (ushort)oldValue + (ushort)valueToAdd;
            var newValue = (short)(newValueInt & 0xFFFF);
            IY = newValue;

            HF = (oldValue ^ newValue ^ valueToAdd) & 0x1000;
            CF = newValueInt & 0x10000;
            NF = 0;
        }
    }
}
