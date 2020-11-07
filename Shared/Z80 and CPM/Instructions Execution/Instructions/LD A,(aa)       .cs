namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The LD A,(nn) instruction.
        /// </summary>
        private void LD_A_aa()
        {
            var address = (ushort)FetchWord();
            A = Memory[address];
        }
    }
}
