namespace Konamiman.M80dotNet
{
    public partial class Z80Processor
    {
        private int[] Parity;

        private void GenerateParityTable()
        {
            Parity = new int[256];

            for (var result = 0; result <= 255; result++)
            {
                var ones = 0;
                var temp = result;
                for (var i = 0; i <= 7; i++)
                {
                    ones += (temp & 1);
                    temp >>= 1;
                }
                Parity[result] = (ones & 1) ^ 1;
            }
        }
    }
}