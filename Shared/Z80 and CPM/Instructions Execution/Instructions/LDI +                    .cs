namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The LDI instruction.
        /// </summary>
        void LDI()
        {
            var sourceAddress = HL;
            var destAddress = DE;
            var counter = BC;
            var value = Memory[(ushort)sourceAddress];
            Memory[(ushort)destAddress] = value;

            HL = (short)(sourceAddress + 1);
            DE = (short)(destAddress + 1);
            counter--;
            BC = counter;

            HF = 0;
            NF = 0;
            PF = (counter != 0) ? 1 : 0;
        }

        /// <summary>
        /// The LDD instruction.
        /// </summary>
        void LDD()
        {
            var sourceAddress = HL;
            var destAddress = DE;
            var counter = BC;
            var value = Memory[(ushort)sourceAddress];
            Memory[(ushort)destAddress] = value;

            HL = (short)(sourceAddress - 1);
            DE = (short)(destAddress - 1);
            counter--;
            BC = counter;

            HF = 0;
            NF = 0;
            PF = (counter != 0) ? 1 : 0;
        }

        /// <summary>
        /// The LDIR instruction.
        /// </summary>
        void LDIR()
        {
            var sourceAddress = HL;
            var destAddress = DE;
            var counter = BC;
            var value = Memory[(ushort)sourceAddress];
            Memory[(ushort)destAddress] = value;

            HL = (short)(sourceAddress + 1);
            DE = (short)(destAddress + 1);
            counter--;
            BC = counter;

            HF = 0;
            NF = 0;
            PF = (counter != 0) ? 1 : 0;

            if (counter != 0)
            {
                PC = (ushort)(PC - 2);
            }
        }

        /// <summary>
        /// The LDDR instruction.
        /// </summary>
        void LDDR()
        {
            var sourceAddress = HL;
            var destAddress = DE;
            var counter = BC;
            var value = Memory[(ushort)sourceAddress];
            Memory[(ushort)destAddress] = value;

            HL = (short)(sourceAddress - 1);
            DE = (short)(destAddress - 1);
            counter--;
            BC = counter;

            HF = 0;
            NF = 0;
            PF = (counter != 0) ? 1 : 0;

            if (counter != 0)
            {
                PC = (ushort)(PC - 2);
            }
        }
    }
}
