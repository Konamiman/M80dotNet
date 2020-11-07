namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The LD (nn),A instruction.
        /// </summary>
        private void LD_aa_A()
        {
            var address = (ushort)FetchWord();
            Memory[address] = A;
        }
    }
}
