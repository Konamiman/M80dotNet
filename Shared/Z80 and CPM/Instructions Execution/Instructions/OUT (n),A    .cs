namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The OUT (n),A instruction.
        /// </summary>
        void OUT_n_A()
        {
            var portNumber = Memory[PC++];
            //Port access is not supported
        }
    }
}
