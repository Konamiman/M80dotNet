using System;

namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The JR d instruction.
        /// </summary>
        void JR_d()
        {
            var offset = Memory[PC++];
            PC = (ushort)(PC + (SByte)offset);
        }
    }
}
