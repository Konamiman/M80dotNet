namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The LD A,I instruction.
        /// </summary>
        void LD_A_I()
        {
            var value = I;
            A = value;

            SF = value.GetBit(7);
            ZF = (value == 0) ? 1 : 0;
            HF = 0;
            NF = 0;
            PF = IFF2;
        }

        /// <summary>
        /// The LD A,R instruction.
        /// </summary>
        void LD_A_R()
        {
            var value = R;
            A = value;

            SF = value.GetBit(7);
            ZF = (value == 0) ? 1 : 0;
            HF = 0;
            NF = 0;
            PF = IFF2;
        }
    }
}
