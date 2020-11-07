namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The LD BC,nn instruction.
        /// </summary>
        void LD_BC_nn()
        {
            var value = FetchWord();
            BC = value;
        }

        /// <summary>
        /// The LD DE,nn instruction.
        /// </summary>
        void LD_DE_nn()
        {
            var value = FetchWord();
            DE = value;
        }

        /// <summary>
        /// The LD HL,nn instruction.
        /// </summary>
        void LD_HL_nn()
        {
            var value = FetchWord();
            HL = value;
        }

        /// <summary>
        /// The LD SP,nn instruction.
        /// </summary>
        void LD_SP_nn()
        {
            var value = FetchWord();
            //FetchFinished(isLdSp: true);
            SP = value;
        }

        /// <summary>
        /// The LD IX,nn instruction.
        /// </summary>
        void LD_IX_nn()
        {
            var value = FetchWord();
            IX = value;
        }

        /// <summary>
        /// The LD IY,nn instruction.
        /// </summary>
        void LD_IY_nn()
        {
            var value = FetchWord();
            IY = value;
        }
    }
}
