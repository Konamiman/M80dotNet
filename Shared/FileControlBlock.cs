using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Konamiman.M80dotNet
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1, Size = 33)]
    struct FileControlBlock
    {
        public byte DriveNumber;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)]
        public byte[] FilenameBytes;

        public byte ExtentNumberLow;

        public byte S1;

        public byte ExtentNumberHigh;

        public byte RecordCount;

        [MarshalAs(UnmanagedType.U4)]
        public uint FileSize;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] Unused;

        public byte CurrentRecord;

        public string Filename
        {
            get => Encoding.ASCII.GetString(FilenameBytes);
        }

        public ushort ExtentNumber { get; set; }

        public static FileControlBlock FromByteArray(byte[] bytes)
        {
            FileControlBlock fcb;
            GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            try
            {
                fcb = (FileControlBlock)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(FileControlBlock));
            }
            finally
            {
                handle.Free();
            }

            fcb.ExtentNumber = BitConverter.ToUInt16(new[] { fcb.ExtentNumberLow, fcb.ExtentNumberHigh });

            return fcb;
        }

        public byte[] ToByteArray()
        {
            var extentNumberBytes = BitConverter.GetBytes(ExtentNumber);
            ExtentNumberLow = extentNumberBytes[0];
            ExtentNumberHigh = extentNumberBytes[1];

            var len = Marshal.SizeOf(this) - 2;
            var bytes = new byte[len];
            var ptr = Marshal.AllocHGlobal(len);
            try
            {
                Marshal.StructureToPtr(this, ptr, true);
                Marshal.Copy(ptr, bytes, 0, len);
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }

            return bytes;
        }

        public void IncreaseRecord()
        {
            CurrentRecord++;
            if (CurrentRecord == 0x80)
            {
                CurrentRecord = 0;
                ExtentNumber++;
            }
        }

        public int FilePointer => (ExtentNumber * 0x80 + CurrentRecord) * 128;
    }
}
