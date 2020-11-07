namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The JP (HL) instruction.
        /// </summary>
        void JP_aHL()
        {
            PC = (ushort)HL;
        }

        /// <summary>
        /// The JP (IX) instruction.
        /// </summary>
        void JP_aIX()
        {
            PC = (ushort)IX;
        }

        /// <summary>
        /// The JP (IY) instruction.
        /// </summary>
        void JP_aIY()
        {
            PC = (ushort)IY;
        }
    }
}
