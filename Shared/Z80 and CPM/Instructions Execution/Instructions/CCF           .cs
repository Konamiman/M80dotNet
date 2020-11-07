namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The CCF instruction.
        /// </summary>
        void CCF()
        {
            var oldCF = CF;
            NF = 0;
            HF = oldCF;
            CF = oldCF ^ 1;
        }
    }
}
