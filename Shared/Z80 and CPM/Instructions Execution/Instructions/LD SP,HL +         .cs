namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The LD SP,HL instruction.
        /// </summary>
        void LD_SP_HL()
        {
            SP = HL;
        }

        /// <summary>
        /// The LD SP,IX instruction.
        /// </summary>
        void LD_SP_IX()
        {
            SP = IX;
        }

        /// <summary>
        /// The LD SP,IY instruction.
        /// </summary>
        void LD_SP_IY()
        {
            SP = IY;
        }
    }
}
