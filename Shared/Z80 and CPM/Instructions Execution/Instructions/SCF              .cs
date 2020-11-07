namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        private const int HF_NF_reset = 0xED;
        private const int CF_set = 1;

        /// <summary>
        /// The SCF instruction.
        /// </summary>
        void SCF()
        {
            HF = 0;
            NF = 0;
            CF = 1;
        }
    }
}
