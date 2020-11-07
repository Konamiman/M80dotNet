namespace Konamiman.M80dotNet
{
    /// <summary>
    /// Class with utility static and extension methods for manipulating numbers.
    /// </summary>
    public static class NumberUtils
    {
        /// <summary>
        /// Gets the high byte of a short value.
        /// </summary>
        /// <param name="value">Number to get the high byte from</param>
        /// <returns>High byte of the number</returns>
        public static byte GetHighByte(this short value)
        {
            return (byte)(value >> 8);
        }

        /// <summary>
        /// Gets the low byte of a short value.
        /// </summary>
        /// <param name="value">Number to get the low byte from</param>
        /// <returns>Loq byte of the number</returns>
        public static byte GetLowByte(this short value)
        {
            return (byte)(value & 0xFF);
        }

        /// <summary>
        /// Returns a modified version of a short number that has
        /// the specified value in the low byte.
        /// </summary>
        /// <param name="value">Original number</param>
        /// <param name="lowByte">New low byte</param>
        /// <returns>Number with the original high byte and the new low byte</returns>
        public static short SetLowByte(this short value, byte lowByte)
        {
            return (short)((value & 0xFF00) | lowByte);
        }

        /// <summary>
        /// Returns a modified version of a short number that has
        /// the specified value in the high byte.
        /// </summary>
        /// <param name="value">Original number</param>
        /// <param name="highByte">New high byte</param>
        /// <returns>Number with the original low byte and the new high byte</returns>
        public static short SetHighByte(this short value, byte highByte)
        {
            return (short)((value & 0x00FF) | (highByte << 8));
        }

        /// <summary>
        /// Generates a short number from two bytes.
        /// </summary>
        /// <param name="lowByte">Low byte of the new number</param>
        /// <param name="highByte">High byte of the new number</param>
        /// <returns>Generated number</returns>
        public static short CreateShort(byte lowByte, byte highByte)
        {
            return (short)((highByte << 8) | lowByte);
        }

        private readonly static int[] bitMasks = { 1, 2, 4, 8, 16, 32, 64, 128 };
        private readonly static int[] negBitMasks = { ~1, ~2, ~4, ~8, ~16, ~32, ~64, ~128 };

        /// <summary>
        /// Gets the value of a certain bit in a byte.
        /// The rightmost bit has position 0, the leftmost bit has position 7.
        /// </summary>
        /// <param name="value">Number to get the bit from</param>
        /// <param name="bitPosition">Bit position to retrieve</param>
        /// <returns>Retrieved bit value</returns>
        public static int GetBit(this byte value, int bitPosition)
        {
            return (value & bitMasks[bitPosition]); // == 0 ? 0 : 1;
        }

        /// <summary>
        /// Retuens a copy of the value that has a certain bit set or reset.
        /// The rightmost bit has position 0, the leftmost bit has position 7.
        /// </summary>
        /// <param name="number">The original number</param>
        /// <param name="bitPosition">The bit position to modify</param>
        /// <param name="value">The bit value</param>
        /// <returns>The original number with the bit appropriately modified</returns>
        public static byte WithBit(this byte number, int bitPosition, int value)
        {
            if (value != 0)
            {
                return (byte)(number | bitMasks[bitPosition]);
            }
            else
            {
                return (byte)(number & negBitMasks[bitPosition]);
            }
        }
    }
}
