namespace Konamiman.M80dotNet
{
    /// <summary>
    /// Implementation of the Z80 registers.
    /// </summary>
    public partial class Z80Processor
    {
        public short AltAF { get; set; }

        public short AltBC { get; set; }

        public short AltDE { get; set; }

        public short AltHL { get; set; }

        public short BC { get; set; }

        public short DE { get; set; }

        public short HL { get; set; }

        public byte A { get; set; }

        public byte F { get; set; }

        public short AF
        {
            get
            {
                var F = (byte)(CF | (NF << 1) | (PF << 2) | (HF << 4) | (ZF << 6) | (SF << 7));
                return (short)(F | (A << 8));
            }
            set
            {
                A = (byte)(value >> 8);
                CF = (value & 1);
                NF = ((value >> 1) & 1);
                PF = ((value >> 2) & 1);
                HF = ((value >> 4) & 1);
                ZF = ((value >> 6) & 1);
                SF = ((value >> 7) & 1);
            }
        }

        public byte B
        {
            get
            {
                return BC.GetHighByte();
            }
            set
            {
                BC = BC.SetHighByte(value);
            }
        }

        public byte C
        {
            get
            {
                return BC.GetLowByte();
            }
            set
            {
                BC = BC.SetLowByte(value);
            }
        }

        public byte D
        {
            get
            {
                return DE.GetHighByte();
            }
            set
            {
                DE = DE.SetHighByte(value);
            }
        }

        public byte E
        {
            get
            {
                return DE.GetLowByte();
            }
            set
            {
                DE = DE.SetLowByte(value);
            }
        }

        public byte H
        {
            get
            {
                return HL.GetHighByte();
            }
            set
            {
                HL = HL.SetHighByte(value);
            }
        }

        public byte L
        {
            get
            {
                return HL.GetLowByte();
            }
            set
            {
                HL = HL.SetLowByte(value);
            }
        }

        private int _CF;
        public int CF
        {
            get => _CF;
            set
            {
                _CF = value == 0 ? 0 : 1;
            }
        }

        private int _NF;
        public int NF
        {
            get => _NF;
            set
            {
                _NF = value == 0 ? 0 : 1;
            }
        }

        private int _PF;
        public int PF
        {
            get => _PF;
            set
            {
                _PF = value == 0 ? 0 : 1;
            }
        }

        private int _HF;
        public int HF
        {
            get => _HF;
            set
            {
                _HF = value == 0 ? 0 : 1;
            }
        }

        private int _ZF;
        public int ZF
        {
            get => _ZF;
            set
            {
                _ZF = value == 0 ? 0 : 1;
            }
        }

        private int _SF;
        public int SF
        {
            get => _SF;
            set
            {
                _SF = value == 0 ? 0 : 1;
            }
        }

        public short IX { get; set; }

        public short IY { get; set; }

        public ushort PC { get; set; }

        public short SP { get; set; }

        public int IFF1 { get; set; }

        public int IFF2 { get; set; }

        public byte IXH
        {
            get
            {
                return IX.GetHighByte();
            }
            set
            {
                IX = IX.SetHighByte(value);
            }
        }

        public byte IXL
        {
            get
            {
                return IX.GetLowByte();
            }
            set
            {
                IX = IX.SetLowByte(value);
            }
        }

        public byte IYH
        {
            get
            {
                return IY.GetHighByte();
            }
            set
            {
                IY = IY.SetHighByte(value);
            }
        }

        public byte IYL
        {
            get
            {
                return IY.GetLowByte();
            }
            set
            {
                IY = IY.SetLowByte(value);
            }
        }

        public byte I { get; set; }

        public byte R { get; set; }
    }
}
