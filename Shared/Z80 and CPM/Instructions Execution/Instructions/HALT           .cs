using System;

namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The HALT instruction.
        /// </summary>
        void HALT()
        {
            throw new Exception("HALT instruction executed, the Z80 execution is blocked");
        }
    }
}
