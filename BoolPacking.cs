using System;

namespace NekroExtensions
{
    // this sh*t was brain cancer but didnt even take that long
    /// <summary>
    ///     A more memory efficient way to store multiple bool values.
    ///     This is achieved by being able to store 8 bool values in one byte.
    ///     A bool should normally only use one bit but actually takes up 8 bits when just normally using it.
    ///     By combining multiple bools into one byte we can read and write them using bit shifting.
    ///     This technique is also known as as bitpacking.
    /// </summary>
    public class BoolPacking
    {
        private byte _b = byte.MinValue;

        public BoolPacking()
        {
        }

        public BoolPacking(bool[] input)
        {
            if (input.Length > 8) throw new ArgumentException("The amount of bools must not exceed 8 values.");
            for (var i = 0; i < input.Length; i++) SetPos(i, input[i]);
        }

        public BoolPacking(string input)
        {
            if (input.Length > 8) throw new ArgumentException("The amount of input values can not exceed 8 values.");
            for (var i = 0; i < input.Length; i++) SetPos(i, input[i].Equals('1'));
        }

        public bool this[int pos]
        {
            get => GetPos(pos);
            set => SetPos(pos, value);
        }

        public int Length => 8;

        private void SetPos(int pos, bool value)
        {
            _b = value ? (byte) (_b | (1 << pos)) : (byte) (_b & ~(1 << pos));
        }

        private bool GetPos(int pos)
        {
            return (_b & (1 << pos)) != 0;
        }
    }
}