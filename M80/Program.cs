using Konamiman.M80dotNet;

namespace Konamiman.Z80dotNet.M80
{
    class Program
    {
        static void Main(string[] args)
        {
            new ProgramRunner("M80").Run(args);
        }
    }
}
