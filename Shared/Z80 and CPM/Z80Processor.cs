using System;
using System.IO;
using System.Linq;

namespace Konamiman.M80dotNet
{
    /// <summary>
    /// Z80 processor simulator with partial CP/M function call support.
    /// This is a simplified version of the processor class implemented as part of
    /// the Z80.NET project (https://github.com/Konamiman/Z80dotNet):
    /// - Port access is not supported
    /// - Interrupts are not supported
    /// - An undefined Z80 instruction will crash the application
    /// - HALT will crash the application
    /// - Registers and intruction executors are embedded instead of being separate classes
    /// - No events are triggered
    /// - The only supported execution stop condition is JP 0
    /// </summary>
    public partial class Z80Processor
    {
        public byte[] Memory { get; private set; } = new byte[65536];

        public Z80Processor(string workingDirectory, bool printInColor, bool convertCrToLf, string[] additionalSearchPaths, bool caseSensitiveFileSearch)
        {
            this.workingDirectory = Path.GetFullPath(workingDirectory);
            InitializeInstructionTables();
            DTA = 0x0080;
            defaultForegroundColor = Console.ForegroundColor;
            defaultBackgroundColor = Console.BackgroundColor;
            this.printInColor = printInColor;
            this.convertCrToLf = convertCrToLf;

            var searchPaths = additionalSearchPaths.Select(p => Path.GetFullPath(Path.Combine(workingDirectory, p))).ToList();
            searchPaths.Insert(0, workingDirectory);
            this.searchPaths = searchPaths.ToArray();

            this.fileSearchEnumerationOptions = new EnumerationOptions 
            { 
                MatchCasing = caseSensitiveFileSearch ? MatchCasing.CaseSensitive : MatchCasing.CaseInsensitive 
            };
        }

        public void Start(ushort address = 0)
        {
            Reset();
            PC = address;

            InstructionExecutionLoop();
        }

        private void InstructionExecutionLoop()
        {
            while (PC != 0)
            {
                if (PC == 5)
                {
                    HandleCpmFunctionCall();
                }

                Execute(Memory[PC++]);
            }
        }

        private void ExecuteRet()
        {
            var sp = (ushort)SP;
            var newPC = NumberUtils.CreateShort(Memory[sp], Memory[(ushort)(sp + 1)]);

            PC = (ushort)newPC;
            SP += 2;
        }

        private void Reset()
        {
            IFF1 = 0;
            IFF2 = 0;
            PC = 0;
            unchecked { AF = (short)0xFFFF; }
            unchecked { SP = (short)0xFFFF; }
        }
    }
}
