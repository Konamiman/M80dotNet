namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The EI instruction.
        /// </summary>
        void EI()
        {
            IFF1 = 1;
            IFF2 = 1;
        }
    }
}
