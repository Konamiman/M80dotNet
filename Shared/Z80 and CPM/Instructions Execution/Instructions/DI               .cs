namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The DI instruction.
        /// </summary>
        void DI()
        {
            IFF1 = 0;
            IFF2 = 0;
        }
    }
}
