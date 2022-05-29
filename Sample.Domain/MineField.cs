using System;
using System.Collections.Generic;

namespace Sample.Domain
{
    public class MineField
    {
        public MineField(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            _sqaures = new Square[Rows, Columns];
        }
        private Square[,] _sqaures;
        public int Rows { get; set; }
        public int Columns { get; set; }

        public static MineField Add(int rows, int columns)
        {
            return new MineField(rows, columns);
        }

        public void AddSquare(int squareRow, int sqaureColumn, bool sqaureHasMine)
        {
            if (sqaureHasMine)
                _sqaures[squareRow, sqaureColumn] = MineSquare.Add(squareRow, sqaureColumn);
            else
                _sqaures[squareRow, sqaureColumn] = SafeSquare.Add(squareRow, sqaureColumn);
        }

        public Square[,] GetSquares() => _sqaures;
    }
}