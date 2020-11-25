using Konamiman.M80dotNet;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Konamiman.Z80dotNet.M80
{
    class Program
    {
        private Z80Processor z80;

        private bool RunInInteractiveMode;

        private bool MustShowBanner;

        private string WorkingDirectory;

        private bool MeasureExecutionTime;

        static void Main(string[] args)
        {
            (new Program()).Run(args);
        }

        private void Run(string[] args)
        {
            ProcessArguments(args);

            if (MustShowBanner)
            {
                ShowBanner();
                if (!RunInInteractiveMode)
                {
                    Console.WriteLine();
                }
            }

            z80 = new Z80Processor(WorkingDirectory);

            z80.Memory[4] = 0; //Current drive
            z80.Memory[6] = 0xF0; //End of TPA
            z80.Memory[7] = 0xFF;

            if (RunInInteractiveMode)
            {
                z80.Memory[0x80] = 0;
            }
            else
            {
                var commandLineBytes = Encoding.ASCII.GetBytes(args[args.Length - 1]);
                if (commandLineBytes.Length > 127)
                {
                    Console.WriteLine("*** The maximum length of the command line for M80 is 127 bytes.");
                    Environment.Exit(1);
                }
                z80.Memory[0x80] = (byte)commandLineBytes.Length;
                Array.Copy(commandLineBytes, 0, z80.Memory, 0x81, commandLineBytes.Length);
            }

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Konamiman.M80dotNet.M80.M80P.COM");
            byte[] program = null;
            using (var memoryStream = new MemoryStream())
            {
                stream.CopyTo(memoryStream);
                program = memoryStream.ToArray();
            }

            Array.Copy(program, 0, z80.Memory, 0x100, program.Length);
            z80.Memory[0x007E] = 0;
            z80.Memory[0x007F] = 0;

            if (MeasureExecutionTime && !RunInInteractiveMode)
            {
                var sw = new Stopwatch();
                sw.Start();
                z80.Start(0x100);
                sw.Stop();
                Console.WriteLine($"{Environment.NewLine}Execution time: {sw.Elapsed}");
            }
            else
            {
                z80.Start(0x100);
            }

            z80.CloseFiles();

            Environment.Exit(z80.Memory[0x007F]);
        }

        private void ProcessArguments(string[] args)
        {
            WorkingDirectory = Directory.GetCurrentDirectory();
            MustShowBanner = true;
            RunInInteractiveMode = false;
            MeasureExecutionTime = false;

            var envCommandLine = Environment.GetEnvironmentVariable("M80_COMMAND_LINE");
            if (envCommandLine != null)
            {
                args = envCommandLine.Split(' ', StringSplitOptions.RemoveEmptyEntries).Concat(args).ToArray();
            }

            int i = 0;
            while (i < args.Length && args[i].StartsWith("-"))
            {
                if (args[i] == "-w")
                {
                    if (i == args.Length - 1)
                    {
                        ShowHelpAndExit();
                    }

                    WorkingDirectory = args[i + 1];
                    i++;
                }
                else if (args[i] == "-i")
                {
                    RunInInteractiveMode = true;
                }
                else if (args[i] == "-ni")
                {
                    RunInInteractiveMode = false;
                }
                else if (args[i] == "-b")
                {
                    MustShowBanner = true;
                }
                else if (args[i] == "-nb")
                {
                    MustShowBanner = false;
                }
                else if (args[i] == "-t")
                {
                    MeasureExecutionTime = true;
                }
                else if (args[i] == "-nt")
                {
                    MeasureExecutionTime = false;
                }
                else
                {
                    ShowHelpAndExit();
                }
                i++;
            }

            if (!RunInInteractiveMode && i > args.Length - 1)
            {
                ShowHelpAndExit();
            }
        }

        private void ShowHelpAndExit()
        {
            ShowBanner();
            ShowUsageHelp();
            Environment.Exit(0);
        }


        private void ShowBanner()
        {
            Console.WriteLine(
@"M80 .NET wrapper 1.0
By Konamiman, 2020");
        }

        private void ShowUsageHelp()
        {
            Console.WriteLine(
@"https://github.com/Konamiman/M80dotNet

Usage: M80 [-w <working dir>] [-i|-ni] [-b|-nb] <command line for M80>

-w: Set working directory (default: current working directory)
-i: Run in interactive mode
-ni: Don't run in interactive mode (default)
-b: Show program banner (default)
-nb: Don't show program banner
-t: Measure execution time
-nt: Don't measure execution time (default)

Command line for M80 is required when not running in interactive move.

Arguments can also be specified in a M80_COMMAND_LINE environment variable.
");
        }
    }
}
