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
            _sqaures = new List<Square>();
        }
        private List<Square> _sqaures;
        public int Rows { get; set; }
        public int Columns { get; set; }

        public static MineField Add(int rows, int columns)
        {
            return new MineField(rows, columns);
        }

        public void AddSquare(int squareRow, int sqaureColumn, bool sqaureHasMine)
        {
            _sqaures.Add(Square.Add(squareRow, sqaureColumn, sqaureHasMine));
        }

        public List<Square> GetSquares() => _sqaures;
    }
}