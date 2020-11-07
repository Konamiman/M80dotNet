namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The IN A,(C) instruction.
        /// </summary>
        void IN_A_C()
        {
            byte value = 0; //Port access is not supported
            A = value;

            SF = value.GetBit(7);
            ZF = (value == 0) ? 1 : 0;
            NF = 0;
            HF = 0;
            PF = Parity[value];
        }

        /// <summary>
        /// The IN B,(C) instruction.
        /// </summary>
        void IN_B_C()
        {
            byte value = 0; //Port access is not supported
            B = value;

            SF = value.GetBit(7);
            ZF = (value == 0) ? 1 : 0;
            NF = 0;
            HF = 0;
            PF = Parity[value];
        }

        /// <summary>
        /// The IN C,(C) instruction.
        /// </summary>
        void IN_C_C()
        {
            byte value = 0; //Port access is not supported
            C = value;

            SF = value.GetBit(7);
            ZF = (value == 0) ? 1 : 0;
            NF = 0;
            HF = 0;
            PF = Parity[value];
        }

        /// <summary>
        /// The IN D,(C) instruction.
        /// </summary>
        void IN_D_C()
        {
            byte value = 0; //Port access is not supported
            D = value;

            SF = value.GetBit(7);
            ZF = (value == 0) ? 1 : 0;
            NF = 0;
            HF = 0;
            PF = Parity[value];
        }

        /// <summary>
        /// The IN E,(C) instruction.
        /// </summary>
        void IN_E_C()
        {
            byte value = 0; //Port access is not supported
            E = value;

            SF = value.GetBit(7);
            ZF = (value == 0) ? 1 : 0;
            NF = 0;
            HF = 0;
            PF = Parity[value];
        }

        /// <summary>
        /// The IN H,(C) instruction.
        /// </summary>
        void IN_H_C()
        {
            byte value = 0; //Port access is not supported
            H = value;

            SF = value.GetBit(7);
            ZF = (value == 0) ? 1 : 0;
            NF = 0;
            HF = 0;
            PF = Parity[value];
        }

        /// <summary>
        /// The IN L,(C) instruction.
        /// </summary>
        void IN_L_C()
        {
            byte value = 0; //Port access is not supported
            L = value;

            SF = value.GetBit(7);
            ZF = (value == 0) ? 1 : 0;
            NF = 0;
            HF = 0;
            PF = Parity[value];
        }

        /// <summary>
        /// The IN F,(C) instruction.
        /// </summary>
        void IN_F_C()
        {
            byte value = 0; //Port access is not supported

            SF = value.GetBit(7);
            ZF = (value == 0) ? 1 : 0;
            NF = 0;
            HF = 0;
            PF = Parity[value];
        }
    }
}
