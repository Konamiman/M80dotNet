namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The INC BC instruction.
        /// </summary>
        void INC_BC()
        {
            BC++;
        }

        /// <summary>
        /// The DEC BC instruction.
        /// </summary>
        void DEC_BC()
        {
            BC--;
        }

        /// <summary>
        /// The INC DE instruction.
        /// </summary>
        void INC_DE()
        {
            DE++;
        }

        /// <summary>
        /// The DEC DE instruction.
        /// </summary>
        void DEC_DE()
        {
            DE--;
        }

        /// <summary>
        /// The INC HL instruction.
        /// </summary>
        void INC_HL()
        {
            HL++;
        }

        /// <summary>
        /// The DEC HL instruction.
        /// </summary>
        void DEC_HL()
        {
            HL--;
        }

        /// <summary>
        /// The INC SP instruction.
        /// </summary>
        void INC_SP()
        {
            SP++;
        }

        /// <summary>
        /// The DEC SP instruction.
        /// </summary>
        void DEC_SP()
        {
            SP--;
        }

        /// <summary>
        /// The INC IX instruction.
        /// </summary>
        void INC_IX()
        {
            IX++;
        }

        /// <summary>
        /// The DEC IX instruction.
        /// </summary>
        void DEC_IX()
        {
            IX--;
        }

        /// <summary>
        /// The INC IY instruction.
        /// </summary>
        void INC_IY()
        {
            IY++;
        }

        /// <summary>
        /// The DEC IY instruction.
        /// </summary>
        void DEC_IY()
        {
            IY--;
        }
    }
}
