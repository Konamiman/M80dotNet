namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The INI instruction.
        /// </summary>
        void INI()
        {
            var portNumber = C;
            var address = HL;
            byte value = 0; //Port access is not supported
            Memory[(ushort)address] = value;

            HL++;
            var counter = B;
            counter = (byte)(counter - 1);
            B = counter;
            ZF = (counter == 0) ? 1 : 0;
            NF = 1;
            SF = counter.GetBit(7);
        }

        /// <summary>
        /// The IND instruction.
        /// </summary>
        void IND()
        {
            var portNumber = C;
            var address = HL;
            byte value = 0; //Port access is not supported
            Memory[(ushort)address] = value;

            HL--;
            var counter = B;
            counter = (byte)(counter - 1);
            B = counter;
            ZF = (counter == 0) ? 1 : 0;
            NF = 1;
            SF = counter.GetBit(7);
        }

        /// <summary>
        /// The INIR instruction.
        /// </summary>
        void INIR()
        {
            var portNumber = C;
            var address = HL;
            byte value = 0; //Port access is not supported
            Memory[(ushort)address] = value;

            HL++;
            var counter = B;
            counter = (byte)(counter - 1);
            B = counter;
            ZF = (counter == 0) ? 1 : 0;
            NF = 1;
            SF = counter.GetBit(7);

            if (counter != 0)
            {
                PC = (ushort)(PC - 2);
            }
        }

        /// <summary>
        /// The INDR instruction.
        /// </summary>
        void INDR()
        {
            var portNumber = C;
            var address = HL;
            byte value = 0; //Port access is not supported
            Memory[(ushort)address] = value;

            HL--;
            var counter = B;
            counter = (byte)(counter - 1);
            B = counter;
            ZF = (counter == 0) ? 1 : 0;
            NF = 1;
            SF = counter.GetBit(7);

            if (counter != 0)
            {
                PC = (ushort)(PC - 2);
            }
        }

        /// <summary>
        /// The OUTI instruction.
        /// </summary>
        void OUTI()
        {
            var portNumber = C;
            var address = HL;
            var value = Memory[(ushort)address];
            //Port writing is not supported

            HL++;
            var counter = B;
            counter = (byte)(counter - 1);
            B = counter;
            ZF = (counter == 0) ? 1 : 0;
            NF = 1;
            SF = counter.GetBit(7);
        }

        /// <summary>
        /// The OUTD instruction.
        /// </summary>
        void OUTD()
        {
            var portNumber = C;
            var address = HL;
            var value = Memory[(ushort)address];
            //Port writing is not supported

            HL--;
            var counter = B;
            counter = (byte)(counter - 1);
            B = counter;
            ZF = (counter == 0) ? 1 : 0;
            NF = 1;
            SF = counter.GetBit(7);
        }

        /// <summary>
        /// The OTIR instruction.
        /// </summary>
        void OTIR()
        {
            var portNumber = C;
            var address = HL;
            var value = Memory[(ushort)address];
            //Port writing is not supported

            HL++;
            var counter = B;
            counter = (byte)(counter - 1);
            B = counter;
            ZF = (counter == 0) ? 1 : 0;
            NF = 1;
            SF = counter.GetBit(7);

            if (counter != 0)
            {
                PC = (ushort)(PC - 2);
            }
        }

        /// <summary>
        /// The OTDR instruction.
        /// </summary>
        void OTDR()
        {
            var portNumber = C;
            var address = HL;
            var value = Memory[(ushort)address];
            //Port writing is not supported

            HL--;
            var counter = B;
            counter = (byte)(counter - 1);
            B = counter;
            ZF = (counter == 0) ? 1 : 0;
            NF = 1;
            SF = counter.GetBit(7);

            if (counter != 0)
            {
                PC = (ushort)(PC - 2);
            }
        }
    }
}
