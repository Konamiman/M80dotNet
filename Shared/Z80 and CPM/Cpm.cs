using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Konamiman.M80dotNet
{
    /// <summary>
    /// Partial implementation of the CP/M function calls.
    /// Only the calls needed to run M80/L80/LIB80 are implemented.
    /// </summary>
    partial class Z80Processor
    {
        private const int CpmRecordSize = 128;
        private const int Char_CR = 13;
        private const int Char_LF = 10;
        private const int Char_Space = 32;
        private const int Char_EOF = 0x1A;

        private ushort DTA;

        private readonly Dictionary<ushort, FileStream> OpenFiles = new Dictionary<ushort, FileStream>();

        private ushort fileIndex = 1;

        private readonly string workingDirectory;

        private readonly ConsoleColor defaultForegroundColor;

        private readonly ConsoleColor defaultBackgroundColor;

        private readonly bool printInColor;

        private readonly bool convertCrToLf;

        private void HandleCpmFunctionCall()
        {
            try
            {
                HandleCpmFunctionCallCore();
            }
            catch(Exception ex)
            {
                PrintFatalError($"*** {ex.GetType().Name}: {ex.Message}");
                Memory[0x7F] = 3;
                PC = 0xFFFF; //Upon return, PC will be increased; on PC=0 program terminates.
            }
        }

        private void HandleCpmFunctionCallCore()
        {
            FileStream fcbFile;
            string filePath;

            var function = C;
            
            switch (function)
            {
                case 2:
                    // Console output
                    if (printInColor)
                    {
                        if (Memory[0x007E] == 0)
                        {
                            //Normal text
                            Console.ForegroundColor = defaultForegroundColor;
                            Console.BackgroundColor = defaultBackgroundColor;
                            Console.Write(Convert.ToChar(E));
                        }
                        else if (Memory[0x007E] == 1)
                        {
                            //Warning
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.BackgroundColor = defaultBackgroundColor;
                            Console.Error.Write(Convert.ToChar(E));
                            Console.ForegroundColor = defaultForegroundColor;
                        }
                        else if (Memory[0x007E] == 2)
                        {
                            //Error
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = defaultBackgroundColor;
                            Console.Error.Write(Convert.ToChar(E));
                            Console.ForegroundColor = defaultForegroundColor;
                        }
                        else
                        {
                            //Fatal error
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Error.Write(Convert.ToChar(E));
                            Console.ForegroundColor = defaultForegroundColor;
                            Console.BackgroundColor = defaultBackgroundColor;
                        }
                    }
                    else
                    {
                        (Memory[0x007E] == 0 ? Console.Out : Console.Error).Write(Convert.ToChar(E));
                    }

                    break;
                case 10:
                    // Buffered line input
                    var bufferAddress = DE;
                    var bufferSize = Memory[bufferAddress];
                    var commandLine = Console.ReadLine().TrimEnd('\n');
                    var commandBytes = Encoding.ASCII.GetBytes(commandLine);
                    Memory[bufferAddress + 1] = (byte)commandBytes.Length;
                    Array.Copy(commandBytes, 0, Memory, bufferAddress + 2, Math.Min(bufferSize, commandBytes.Length));

                    break;
                case 13:
                    // Disk reset
                    DTA = 0x0080;

                    break;
                case 14:
                    // Select disk
                    Memory[4] = E;

                    A = L = 1;  //Number of available drives

                    break;
                case 15:
                    // Open file
                    filePath = GetFullPathFromFcb();
                    if (File.Exists(filePath))
                    {
                        DoOpenFile(filePath);

                        L = A = 0;
                    }
                    else
                    {
                        L = A = 0xFF;
                    }

                    break;
                case 16:
                    // Close file
                    fcbFile = GetCurrentFcbStream();
                    if (fcbFile != null)
                    {
                        var index = GetCurrentFcbIndex();
                        OpenFiles[index].Dispose();
                        OpenFiles.Remove(index);
                        L = A = 0;
                    }
                    else
                    {
                        L = A = 0xFF;
                    }

                    break;
                case 19:
                    // Delete file
                    fcbFile = GetCurrentFcbStream();
                    if (fcbFile != null)
                    {
                        var index = GetCurrentFcbIndex();
                        OpenFiles[index].Dispose();
                        OpenFiles.Remove(index);
                    }

                    filePath = GetFullPathFromFcb();
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                        L = A = 0;
                    }
                    else
                    {
                        L = A = 0xFF;
                    }

                    break;
                case 20:
                    // Sequential read
                    fcbFile = GetCurrentFcbStream();
                    if (fcbFile != null)
                    {
                        var index = GetCurrentFcbIndex();
                        var count = OpenFiles[index].Read(Memory, DTA, CpmRecordSize);
                        if (count > 0)
                        {
                            if (convertCrToLf)
                            {
                                for (var i = 0; i < count; i++)
                                {
                                    if (Memory[DTA + i] == Char_CR)
                                    {
                                        Memory[DTA + i] = Char_Space;
                                    }
                                    else if (Memory[DTA + i] == Char_LF)
                                    {
                                        Memory[DTA + i] = Char_CR;
                                    }
                                }
                            }

                            for (var i = count; i < CpmRecordSize; i++)
                            {
                                Memory[DTA + i] = Char_EOF;
                            }

                            L = A = 0;
                        }
                        else
                        {
                            L = A = 0xFF;
                        }
                    }
                    else
                    {
                        L = A = 0xFF;
                    }

                    break;
                case 21:
                    // Sequential write
                    fcbFile = GetCurrentFcbStream();
                    if (fcbFile != null)
                    {
                        var index = GetCurrentFcbIndex();
                        OpenFiles[index].Write(Memory, DTA, CpmRecordSize);
                        L = A = 0;
                    }
                    else
                    {
                        L = A = 0xFF;
                    }

                    break;
                case 22:
                    // Create file
                    fcbFile = GetCurrentFcbStream();
                    if (fcbFile != null)
                    {
                        var index = GetCurrentFcbIndex();
                        OpenFiles[index].Dispose();
                        OpenFiles.Remove(index);
                    }

                    filePath = GetFullPathFromFcb();
                    File.Create(filePath).Close(); //WIP: keep open

                    DoOpenFile(filePath);

                    L = A = 0;

                    break;
                case 23:
                    // Rename file
                    var oldName = GetFullPathFromFcb();
                    var newName = GetFullPathFromFcb(17);

                    // We need to do this weird stuff because LIB80 renames files while they're open!
                    var openFiles = OpenFiles.Where(fs => fs.Value.Name == oldName).ToArray();
                    foreach(var fileEntry in openFiles)
                    {
                        var position = fileEntry.Value.Position;
                        fileEntry.Value.Close();
                        File.Move(oldName, newName, true);
                        var newStream = File.Open(newName, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                        newStream.Seek(position, SeekOrigin.Begin);
                        OpenFiles[fileEntry.Key] = newStream;
                    }

                    break;
                case 25:
                    // Get current drive
                    A = L = 0;

                    break;
                case 26:
                    // Set disk transfer address
                    DTA = (ushort)DE;

                    break;
                default:
                    throw new NotImplementedException($"Unimplemented CP/M function call invoked: {function}");
            }

            ExecuteRet();
        }

        private ushort GetCurrentFcbIndex()
        {
            return (ushort)((Memory[DE + 0x19] << 8) | Memory[DE + 0x18]);
        }

        private FileStream GetCurrentFcbStream()
        {
            var fcbIndex = GetCurrentFcbIndex();
            if (OpenFiles.ContainsKey(fcbIndex))
            {
                return OpenFiles[fcbIndex];
            }
            else
            {
                return null;
            }
        }

        private ushort SetFcbIndex()
        {
            var fcbAddress = DE;
            Memory[fcbAddress + 0x18] = (byte)(fileIndex & 0xFF);
            Memory[fcbAddress + 0x19] = (byte)(fileIndex >> 8);
            var assignedIndex = fileIndex;
            fileIndex++;
            return assignedIndex;
        }

        private string GetFullPathFromFcb(byte offset = 1)
        {
            var fcbFileNameBytes = Memory.Skip(DE + offset).Take(11).ToArray();
            var fcbFileName = Encoding.ASCII.GetString(fcbFileNameBytes);
            var fileName = (fcbFileName.Substring(0, 8).TrimEnd() + "." + fcbFileName[8..].TrimEnd()).ToUpper();
            return Path.Combine(workingDirectory, fileName);
        }

        public void CloseFiles()
        {
            foreach (var file in OpenFiles.Values)
            {
                file.Close();
            }

            OpenFiles.Clear();
        }

        private void DoOpenFile(string filePath)
        {
            var stream = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            var index = SetFcbIndex();
            OpenFiles[index] = stream;

            var fileSize = (int)stream.Length;
            var fileSizeBytes = BitConverter.GetBytes(fileSize);
            Array.Copy(fileSizeBytes, 0, Memory, DE + 16, fileSizeBytes.Length);
        }

        public void PrintFatalError(string message)
        {
            if(printInColor)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Error.WriteLine(message);
                Console.ForegroundColor = defaultForegroundColor;
                Console.BackgroundColor = defaultBackgroundColor;
            }
            else
            {
                Console.Error.WriteLine(message);
            }
        }

        public void PrintExtraInfo(string message)
        {
            if (printInColor)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(message);
                Console.ForegroundColor = defaultForegroundColor;
                Console.BackgroundColor = defaultBackgroundColor;
            }
            else
            {
                Console.WriteLine(message);
            }
        }
    }
}
