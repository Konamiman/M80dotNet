﻿using System;
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

        private const byte DollarCode = 36;

        private ushort DTA;

        private readonly Dictionary<ushort, FileStream> OpenFiles = new Dictionary<ushort, FileStream>();

        private ushort fileIndex = 1;

        private readonly string workingDirectory;

        private void HandleCpmFunctionCall()
        {
            FileStream fcbFile;
            string filePath;

            var function = C;

            switch (function)
            {
                case 2:
                    // Console output
                    Console.Write(Convert.ToChar(E));

                    break;
                case 9:

                    // String output
                    var messageAddress = DE;
                    byte byteToPrint;

                    while ((byteToPrint = Memory[messageAddress++]) != DollarCode)
                    {
                        Console.Write(Convert.ToChar(byteToPrint));
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
                        var stream = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                        var index = SetFcbIndex();
                        OpenFiles[index] = stream;

                        var fileSize = (int)stream.Length;
                        var fileSizeBytes = BitConverter.GetBytes(fileSize);
                        Array.Copy(fileSizeBytes, 0, Memory, DE + 16, fileSizeBytes.Length);

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
                            for (var i = count; i < CpmRecordSize; i++)
                            {
                                Memory[DTA + i] = 0x1A; //EOF
                            }

                            L = A = 0;
                        }
                        else
                        {
                            L = A = 1;
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
                    File.Create(filePath).Close();

                    L = A = 0;

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

        private string GetFullPathFromFcb()
        {
            var fcbFileNameBytes = Memory.Skip(DE + 1).Take(11).ToArray();
            var fcbFileName = Encoding.ASCII.GetString(fcbFileNameBytes);
            var fileName = (fcbFileName.Substring(0, 8).TrimEnd() + "." + fcbFileName[8..].TrimEnd()).ToUpper();
            return Path.Combine(workingDirectory, fileName); // @"c:\code\fun\Nextor\source\kernel\bank0", fileName);
        }

        public void CloseFiles()
        {
            foreach (var file in OpenFiles.Values)
            {
                file.Close();
            }

            OpenFiles.Clear();
        }
    }
}