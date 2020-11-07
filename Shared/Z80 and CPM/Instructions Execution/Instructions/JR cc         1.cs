using System;

namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The JR C,d instruction.
        /// </summary>
        void JR_C_d()
        {
            var offset = Memory[PC++];
            if (CF == 0)
                return;

            PC = (ushort)(PC + (SByte)offset);
        }

        /// <summary>
        /// The JR NC,d instruction.
        /// </summary>
        void JR_NC_d()
        {
            var offset = Memory[PC++];
            if (CF == 1)
                return;

            PC = (ushort)(PC + (SByte)offset);
        }

        /// <summary>
        /// The JR Z,d instruction.
        /// </summary>
        void JR_Z_d()
        {
            var offset = Memory[PC++];
            if (ZF == 0)
                return;

            PC = (ushort)(PC + (SByte)offset);
        }

        /// <summary>
        /// The JR NZ,d instruction.
        /// </summary>
        void JR_NZ_d()
        {
            var offset = Memory[PC++];
            if (ZF == 1)
                return;

            PC = (ushort)(PC + (SByte)offset);
        }
    }
}
