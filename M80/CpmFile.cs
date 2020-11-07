using Konamiman.Z80dotNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Linq;
using System.Text;

namespace Konamiman.M80dotNet.M80
{
    class CpmFile
    {
        const int RECORDS_PER_EXTENT = 128;
        public const int BYTES_PER_RECORD = 128;

        private byte[] fileContents;

        private uint filePointer;

        private string filePath;

        private FileControlBlock fcb;

        private bool hasWrites;

        private bool isOpen;

        public FileControlBlock FCB
        {
            get => fcb;
            set
            {
                fcb = value;
                UpdateFilePointer();
            }
        }

        public CpmFile(string workingDirectory, FileControlBlock fcb)
        {
            this.fcb = fcb;
            var fileName = (fcb.Filename.Substring(0, 8).TrimEnd() + "." + fcb.Filename.Substring(8).TrimEnd()).ToUpper();
            filePath = Path.Combine(workingDirectory, fileName);
            fileContents = null;
            isOpen = false;
        }

        public bool Open()
        {
            if(!File.Exists(filePath))
            {
                return false;
            }

            fileContents = File.ReadAllBytes(filePath);
            fcb.FileSize = (uint)fileContents.Length;
            fcb.ExtentNumber = 0;
            fcb.CurrentRecord = 0;
            fcb.RecordCount = 0;

            isOpen = true;
            return true;
        }

        public void Flush()
        {
            if (!isOpen || !hasWrites)
            {
                return;
            }

            File.WriteAllBytes(filePath, fileContents.Take((int)fcb.FileSize).ToArray());

            hasWrites = false;
        }

        public void Create()
        {
            File.Create(filePath).Close();
            fileContents = new byte[0];
            
            fcb.FileSize = 0;

            isOpen = true;
        }

        public bool Delete()
        {
            bool result;
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                result = true;
            }
            else
            {
                result = false;
            }

            isOpen = false;
            return result;
        }

        public bool SequentialRead(IMemory memory, ushort destinationIndex)
        {
            if (!isOpen || filePointer >= fcb.FileSize)
            {
                return false;
            }
            Console.Write("-");
            var bytesToCopyCount = (int)Math.Min(fcb.FileSize - filePointer, BYTES_PER_RECORD);
            memory.SetContents(destinationIndex, fileContents, (int)filePointer, bytesToCopyCount);
            for(int i = bytesToCopyCount; i < BYTES_PER_RECORD; i++)
            {
                memory[destinationIndex + i] = 0;
            }

            //Array.Copy(fileContents, filePointer, destination, destinationIndex, bytesToCopyCount);
            /*if (bytesToCopyCount != BYTES_PER_RECORD)
            {
                Array.Fill<byte>(destination, 0, destinationIndex + bytesToCopyCount, BYTES_PER_RECORD - bytesToCopyCount);
            }*/

            IncreaseFcbRecordNumber();
            UpdateFilePointer();

            return true;
        }

        public bool SequentialWrite(IMemory source, ushort sourceIndex)
        {
            if (!isOpen)
            {
                return false;
            }
            Console.Write("+");
            var oldFileSize = fcb.FileSize;

            if (fcb.FileSize - filePointer < BYTES_PER_RECORD)
            {
                Array.Resize(ref fileContents, (int)(filePointer + RECORDS_PER_EXTENT * BYTES_PER_RECORD));
            }

            var dataToWrite = source.GetContents(sourceIndex, BYTES_PER_RECORD);
            Array.Copy(dataToWrite, 0, fileContents, filePointer, BYTES_PER_RECORD);
            ////Array.Copy(source, sourceIndex, fileContents, filePointer, BYTES_PER_RECORD);

            IncreaseFcbRecordNumber();
            UpdateFilePointer();

            if(filePointer > oldFileSize)
            {
                fcb.FileSize = filePointer + 1;
            }

            hasWrites = true;

            return true;
        }

        private void IncreaseFcbRecordNumber()
        {
            fcb.CurrentRecord++;
            if (fcb.CurrentRecord == BYTES_PER_RECORD)
            {
                fcb.CurrentRecord = 0;
                fcb.ExtentNumber++;
            }
        }

        private void UpdateFilePointer()
        {
            filePointer = (uint)((fcb.ExtentNumber * RECORDS_PER_EXTENT * BYTES_PER_RECORD) + (fcb.CurrentRecord * BYTES_PER_RECORD));
        }
    }
}
