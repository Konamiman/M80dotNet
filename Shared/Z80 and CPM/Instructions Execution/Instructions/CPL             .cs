namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The CPL instruction.
        /// </summary>
        void CPL()
        {
            A = (byte)(A ^ 0xFF);

            HF = 1;
            NF = 1;
        }
    }
}
