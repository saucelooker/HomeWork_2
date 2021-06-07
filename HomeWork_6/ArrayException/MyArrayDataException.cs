using System;
namespace ArrayException
{   [Serializable]
    public class MyArrayDataException : Exception
    {
        int row { get; set; }
        int column { get; set; }

        public MyArrayDataException(int _row, int _column)
            {
            _column = column;
            _row = row;
            }
    }
}
