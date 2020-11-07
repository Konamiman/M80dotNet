namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The NEG instruction.
        /// </summary>
        void NEG()
        {
            var oldValue = A;
            var newValue = (byte)-oldValue;
            A = newValue;

            SF = newValue.GetBit(7);
            ZF = (newValue == 0) ? 1 : 0;
            HF = (oldValue ^ newValue) & 0x10;
            PF = (oldValue == 0x80) ? 1 : 0;
            NF = 1;
            CF = (oldValue != 0) ? 1 : 0;
        }
    }
}
