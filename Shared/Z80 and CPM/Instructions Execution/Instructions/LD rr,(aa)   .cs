namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The LD HL,(aa) instruction.
        /// </summary>
        void LD_HL_aa()
        {
            var address = (ushort)FetchWord();
            HL = ReadShortFromMemory(address);
        }

        /// <summary>
        /// The LD DE,(aa) instruction.
        /// </summary>
        void LD_DE_aa()
        {
            var address = (ushort)FetchWord();
            DE = ReadShortFromMemory(address);
        }

        /// <summary>
        /// The LD BC,(aa) instruction.
        /// </summary>
        void LD_BC_aa()
        {
            var address = (ushort)FetchWord();
            BC = ReadShortFromMemory(address);
        }

        /// <summary>
        /// The LD SP,(aa) instruction.
        /// </summary>
        void LD_SP_aa()
        {
            var address = (ushort)FetchWord();
            SP = ReadShortFromMemory(address);
        }

        /// <summary>
        /// The LD IX,(aa) instruction.
        /// </summary>
        void LD_IX_aa()
        {
            var address = (ushort)FetchWord();
            IX = ReadShortFromMemory(address);
        }

        /// <summary>
        /// The LD IY,(aa) instruction.
        /// </summary>
        void LD_IY_aa()
        {
            var address = (ushort)FetchWord();
            IY = ReadShortFromMemory(address);
        }
    }
}
