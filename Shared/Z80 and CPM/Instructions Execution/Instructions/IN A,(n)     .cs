namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The IN A,(n) instruction.
        /// </summary>
        void IN_A_n()
        {
            var portNumber = Memory[PC++];
            A = 0; //Port access is not supported
        }
    }
}
