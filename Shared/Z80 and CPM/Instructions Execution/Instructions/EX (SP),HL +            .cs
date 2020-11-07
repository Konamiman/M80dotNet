namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The EX (SP),HL instruction.
        /// </summary>
        void EX_aSP_HL()
        {
            var sp = (ushort)SP;

            var temp = ReadShortFromMemory(sp);
            WriteShortToMemory(sp, HL);
            HL = temp;
        }

        /// <summary>
        /// The EX (SP),IX instruction.
        /// </summary>
        void EX_aSP_IX()
        {
            var sp = (ushort)SP;

            var temp = ReadShortFromMemory(sp);
            WriteShortToMemory(sp, IX);
            IX = temp;
        }

        /// <summary>
        /// The EX (SP),IY instruction.
        /// </summary>
        void EX_aSP_IY()
        {
            var sp = (ushort)SP;

            var temp = ReadShortFromMemory(sp);
            WriteShortToMemory(sp, IY);
            IY = temp;
        }
    }
}
