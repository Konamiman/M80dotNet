using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Konamiman.M80dotNet
{
    /// <summary>
    /// Class to run M80/L80/LIB80, includes:
    /// 
    /// - Handling command line arguments
    /// - Running the Z80 simulator
    /// - Handling exit codes
    /// </summary>
    public class ProgramRunner
    {
        private Z80Processor z80;

        private bool RunInInteractiveMode;

        private bool MustShowBanner;

        private string WorkingDirectory;

        private bool MeasureExecutionTime;

        private readonly string ProgramName;

        private bool PrintInColor;

        private bool CaseSensitiveFileSearch;

        // Yes I know, I should use subclassing for that stuff.
        // But this is a small project, so let's just move on, mkay?
        private readonly bool IsM80;

        private bool Allow8Bit;

        private bool ConvertCrToLf;

        private string[] AdditionalSearchPaths;

        // Extra variables used by M80/L80/LIB80,
        // they are also defined in Shared/MACRO80_Sources/XX80.LIB
        private const ushort Mem_InteractiveMode = 0x7C;
        private const ushort Mem_Allow8bit = 0x7D;
        private const ushort Mem_CurrentPrMode = 0x7E;
        private const ushort Mem_ExitCode = 0x7F;

        public ProgramRunner(string programName)
        {
            this.ProgramName = programName;
            this.IsM80 = programName == "M80";
        }

        public void Run(string[] args)
        {
            ProcessArguments(args);

            if (MustShowBanner)
            {
                ShowBanner();
                if (IsM80 && !RunInInteractiveMode)
                {
                    Console.WriteLine();
                }
            }

            z80 = new Z80Processor(WorkingDirectory, PrintInColor, ConvertCrToLf, AdditionalSearchPaths, CaseSensitiveFileSearch);

            z80.Memory[6] = 0xFF; //End of TPA
            z80.Memory[7] = 0xFF;

            var applicationCommandLine = args[args.Length - 1];

            if (RunInInteractiveMode)
            {
                z80.Memory[0x80] = 0;
            }
            else
            {
                var commandLineBytes = Encoding.ASCII.GetBytes(applicationCommandLine);
                if (commandLineBytes.Length > 127)
                {
                    z80.PrintFatalError("*** The maximum length of the command line is 127 bytes.");
                    Environment.Exit(3);
                }
                z80.Memory[0x80] = (byte)commandLineBytes.Length;
                Array.Copy(commandLineBytes, 0, z80.Memory, 0x81, commandLineBytes.Length);
            }

            var stream = Assembly.GetCallingAssembly().GetManifestResourceStream($"Konamiman.M80dotNet.{ProgramName}.{ProgramName}.COM");
            byte[] program = null;
            using (var memoryStream = new MemoryStream())
            {
                stream.CopyTo(memoryStream);
                program = memoryStream.ToArray();
            }

            Array.Copy(program, 0, z80.Memory, 0x100, program.Length);
            z80.Memory[Mem_InteractiveMode] = (byte)(RunInInteractiveMode ? 1 : 0);
            if (IsM80)
            {
                z80.Memory[Mem_Allow8bit] = (byte)(Allow8Bit ? 1 : 0);
            }
            z80.Memory[Mem_CurrentPrMode] = 0;
            z80.Memory[Mem_ExitCode] = 0;

            if (MeasureExecutionTime && !RunInInteractiveMode)
            {
                var sw = new Stopwatch();
                sw.Start();
                z80.Start(0x100);
                sw.Stop();
                z80.PrintExtraInfo($"{Environment.NewLine}{ProgramName} {applicationCommandLine} - Execution time: {sw.Elapsed}");
            }
            else
            {
                z80.Start(0x100);
            }

            z80.CloseFiles();

            if(z80.Memory[Mem_ExitCode] == 3)
            {
                //Fatal errors are printed without line termination
                Console.WriteLine();
            }
            Environment.Exit(z80.Memory[Mem_ExitCode]);
        }

        private void ProcessArguments(string[] args)
        {
            WorkingDirectory = Directory.GetCurrentDirectory();
            MustShowBanner = true;
            RunInInteractiveMode = false;
            MeasureExecutionTime = false;
            PrintInColor = true;
            Allow8Bit = false;
            ConvertCrToLf = IsM80;
            AdditionalSearchPaths = new string[0];
            CaseSensitiveFileSearch = false;

            var envCommandLine = Environment.GetEnvironmentVariable($"X80_COMMAND_LINE") ?? "";
            envCommandLine += " " + (Environment.GetEnvironmentVariable($"{ProgramName}_COMMAND_LINE") ?? "");
            if (!string.IsNullOrWhiteSpace(envCommandLine))
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
                else if (args[i] == "-p")
                {
                    if (i == args.Length - 1)
                    {
                        ShowHelpAndExit();
                    }

                    AdditionalSearchPaths = AdditionalSearchPaths.Concat(args[i + 1].Split(',')).ToArray();
                    i++;
                }
                else if (args[i] == "-np")
                {
                    AdditionalSearchPaths = new string[0];
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
                else if (args[i] == "-a")
                {
                    PrintInColor = true;
                }
                else if (args[i] == "-na")
                {
                    PrintInColor = false;
                }
                else if (IsM80 && args[i] == "-8")
                {
                    Allow8Bit = true;
                }
                else if (IsM80 && args[i] == "-n8")
                {
                    Allow8Bit = false;
                }
                else if (IsM80 && args[i] == "-l")
                {
                    ConvertCrToLf = true;
                }
                else if (IsM80 && args[i] == "-nl")
                {
                    ConvertCrToLf = false;
                }
                else if (args[i] == "-c")
                {
                    CaseSensitiveFileSearch = true;
                }
                else if (args[i] == "-nc")
                {
                    CaseSensitiveFileSearch = false;
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
            // Version number is specified in Shared/AssemblyInfo.cs (and linked in the other projects)
            var version = Assembly.GetExecutingAssembly().GetName().Version.ToString(2);

            Console.WriteLine(
@$"{ProgramName} .NET wrapper {version}
By Konamiman, 2023");
        }

        private void ShowUsageHelp()
        {
            var extra = "";
            var extraCmd = "";
            if(IsM80)
            {
                extra =
@"-8: Allow 8 bit characters (with MSB set) in source
-n8: Don't allow 8 bit characters in source (default)
-l: Convert CR characters to spaces and LF characters to CR 
    in source files before processing (default)
-nl: Don't change CR nor LF characters in source files
";
                extraCmd = "[-8|-n8] [-l|-nl] ";
            }

            Console.WriteLine(
@$"https://github.com/Konamiman/M80dotNet

Usage: {ProgramName} [-w <working dir>] [-p <path>[,<path>...]] 
           [-i|-ni] [-b|-nb] [-t|-nt] [-a|-na] [-c|-nc] {extraCmd}<command line for {ProgramName}>

-w: Set working directory (default: current working directory)
-p: Additional paths to search for files (comma separated list)
-np: Forget any additional search paths previously specified with -p
-i: Run in interactive mode
-ni: Don't run in interactive mode (default)
-b: Show program banner (default)
-nb: Don't show program banner
-t: Measure execution time
-nt: Don't measure execution time (default)
-a: Print in console using ANSI colors (default)
-na: Don't print in console using ANSI colors
-c: Do case-sensitive file searches
-nc: Do case-insensitive file searches (default)
{extra}
Command line for {ProgramName} is required when not running in interactive move.

Arguments can also be specified in X80_COMMAND_LINE and {ProgramName}_COMMAND_LINE environment variables.
");
        }
    }
}

