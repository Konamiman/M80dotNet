namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        /// <summary>
        /// The EXX instruction.
        /// </summary>
        void EXX()
        {
            var tempBC = BC;
            var tempDE = DE;
            var tempHL = HL;

            BC = AltBC;
            DE = AltDE;
            HL = AltHL;

            AltBC = tempBC;
            AltDE = tempDE;
            AltHL = tempHL;
        }
    }
}
