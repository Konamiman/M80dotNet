namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The DAA instruction.
        /// </summary>
        void DAA()
        {
            //Algorithm borrowed from MAME:
            //https://github.com/mamedev/mame/blob/master/src/emu/cpu/z80/z80.c

            var oldValue = A;
            var newValue = oldValue;

            if (HF == 1 || (oldValue & 0x0F) > 9) newValue = (byte)(newValue + (NF == 1 ? -0x06 : 0x06)); //FA
            if (CF == 1 || oldValue > 0x99) newValue = (byte)(newValue + (NF == 1 ? -0x60 : 0x60)); //A0

            CF |= (oldValue > 0x99) ? 1 : 0;
            HF = ((oldValue ^ newValue) & 0x10);
            SF = (newValue & 0x80);
            ZF = (newValue == 0) ? 1 : 0;
            PF = Parity[newValue];
            A = newValue;
        }
    }
}
