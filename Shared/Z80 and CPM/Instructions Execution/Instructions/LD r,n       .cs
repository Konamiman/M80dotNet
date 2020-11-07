namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The LD A,n instruction.
        /// </summary>
        void LD_A_n()
        {
            var value = Memory[PC++];
            A = value;
        }

        /// <summary>
        /// The LD B,n instruction.
        /// </summary>
        void LD_B_n()
        {
            var value = Memory[PC++];
            B = value;
        }

        /// <summary>
        /// The LD C,n instruction.
        /// </summary>
        void LD_C_n()
        {
            var value = Memory[PC++];
            C = value;
        }

        /// <summary>
        /// The LD D,n instruction.
        /// </summary>
        void LD_D_n()
        {
            var value = Memory[PC++];
            D = value;
        }

        /// <summary>
        /// The LD E,n instruction.
        /// </summary>
        void LD_E_n()
        {
            var value = Memory[PC++];
            E = value;
        }

        /// <summary>
        /// The LD H,n instruction.
        /// </summary>
        void LD_H_n()
        {
            var value = Memory[PC++];
            H = value;
        }

        /// <summary>
        /// The LD L,n instruction.
        /// </summary>
        void LD_L_n()
        {
            var value = Memory[PC++];
            L = value;
        }

        /// <summary>
        /// The LD IXH,n instruction.
        /// </summary>
        void LD_IXH_n()
        {
            var value = Memory[PC++];
            IXH = value;
        }

        /// <summary>
        /// The LD IXL,n instruction.
        /// </summary>
        void LD_IXL_n()
        {
            var value = Memory[PC++];
            IXL = value;
        }

        /// <summary>
        /// The LD IYH,n instruction.
        /// </summary>
        void LD_IYH_n()
        {
            var value = Memory[PC++];
            IYH = value;
        }

        /// <summary>
        /// The LD IYL,n instruction.
        /// </summary>
        void LD_IYL_n()
        {
            var value = Memory[PC++];
            IYL = value;
        }
    }
}
