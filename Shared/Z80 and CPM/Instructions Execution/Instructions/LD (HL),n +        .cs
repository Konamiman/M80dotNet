using System;

namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The LD (HL),n instruction.
        /// </summary>
        private void LD_aHL_N()
        {
            var newValue = Memory[PC++];
            var address = (ushort)HL;
            Memory[address] = newValue;
        }

        /// <summary>
        /// The LD (IX+n),n instruction.
        /// </summary>
        private void LD_aIX_plus_n_N()
        {
            var offset = Memory[PC++];
            var newValue = Memory[PC++];
            var address = (ushort)(IX + (SByte)offset);
            Memory[address] = newValue;
        }

        /// <summary>
        /// The LD (IY+n),n instruction.
        /// </summary>
        private void LD_aIY_plus_n_N()
        {
            var offset = Memory[PC++];
            var newValue = Memory[PC++];
            var address = (ushort)(IY + (SByte)offset);
            Memory[address] = newValue;
        }
    }
}
