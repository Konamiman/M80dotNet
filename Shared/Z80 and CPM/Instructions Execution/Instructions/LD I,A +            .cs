namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The LD I,A instruction.
        /// </summary>
        void LD_I_A()
        {
            I = A;
        }

        /// <summary>
        /// The LD R,A instruction.
        /// </summary>
        void LD_R_A()
        {
            R = A;
        }
    }
}
