namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The RETN instruction.
        /// </summary>
        private void RETN()
        {
            var sp = (ushort)SP;
            var newPC = NumberUtils.CreateShort(
                Memory[sp],
                Memory[(ushort)(sp + 1)]);
            PC = (ushort)newPC;

            SP += 2;

            IFF1 = IFF2;
        }
    }
}