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

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Konamiman.M80dotNet.M80.M80.COM");
            byte[] program = null;
            using (var memoryStream = new MemoryStream())
            {
                stream.CopyTo(memoryStream);
                program = memoryStream.ToArray();
            }

            if (!RunInInteractiveMode)
            {
                //M80 jumps to interactive mode on fatal error (command error, file not found),
                //we need to apply a hack to make it terminate instead.

                //On fatal error, after printing the error, jump to 0xFF00 instead to going interactive.
                program[0x46EA - 0x100] = 0xF0;
                program[0x46EB - 0x100] = 0xFF;

                //In 0xFF00: increase error count (that's done by 0x1B21), then jump to 0 to terminate program.
                var hack = new byte[] {
                    0x1E, 10,   //ld e,10 (LF)
                    0x0E, 2,    //ld c,2 (.CONOUT)
                    0xCD, 5, 0, //call 5

                    0xCD, 0x21, 0x1B, //call 0x1B21 (increase error count)
                    0xC3, 0, 0        //jp 0
                };
                Array.Copy(hack, 0, z80.Memory, 0xFFF0, hack.Length);
            }

            Array.Copy(program, 0, z80.Memory, 0x100, program.Length);

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

            Environment.Exit(z80.Memory[0x3CED] == 0 ? 0 : 1);
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
