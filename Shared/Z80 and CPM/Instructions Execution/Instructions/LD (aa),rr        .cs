namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The LD (aa),HL instruction.
        /// </summary>
        void LD_aa_HL()
        {
            var address = (ushort)FetchWord();

            WriteShortToMemory(address, HL);
        }

        /// <summary>
        /// The LD (aa),DE instruction.
        /// </summary>
        void LD_aa_DE()
        {
            var address = (ushort)FetchWord();

            WriteShortToMemory(address, DE);
        }

        /// <summary>
        /// The LD (aa),BC instruction.
        /// </summary>
        void LD_aa_BC()
        {
            var address = (ushort)FetchWord();

            WriteShortToMemory(address, BC);
        }

        /// <summary>
        /// The LD (aa),SP instruction.
        /// </summary>
        void LD_aa_SP()
        {
            var address = (ushort)FetchWord();

            WriteShortToMemory(address, SP);
        }

        /// <summary>
        /// The LD (aa),IX instruction.
        /// </summary>
        void LD_aa_IX()
        {
            var address = (ushort)FetchWord();

            WriteShortToMemory(address, IX);
        }

        /// <summary>
        /// The LD (aa),IY instruction.
        /// </summary>
        void LD_aa_IY()
        {
            var address = (ushort)FetchWord();

            WriteShortToMemory(address, IY);
        }
    }
}
