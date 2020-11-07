namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The EX AF,AF' instruction
        /// </summary>
        void EX_AF_AF()
        {
            var temp = AF;
            AF = AltAF;
            AltAF = temp;
        }
    }
}
