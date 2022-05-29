using System;
using System.Collections.Generic;

namespace Sample.Domain
{
    public class MineField
    {
        private MineField(int rows, int columns)
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

        internal Square GetSquare(int i, int j) => _sqaures[i, j];

        public void GetAdjacentMineSquares(SafeSquare safeSquare)
        {
            UpdateRowAdjacentMineSquares(safeSquare, safeSquare.Row - 1);
            UpdateRowAdjacentMineSquares(safeSquare, safeSquare.Row + 1);
            UpdateColumnAdjacentMineSquares(safeSquare, safeSquare.Column - 1);
            UpdateColumnAdjacentMineSquares(safeSquare, safeSquare.Column + 1);
        }

        private void UpdateColumnAdjacentMineSquares(SafeSquare safeSquare, int col)
        {
            if (col == -1 || col == Columns)
                return;

            if (_sqaures[safeSquare.Row, col] is MineSquare)
                safeSquare.InCreaseAdjacentMineSquares();
        }

        private void UpdateRowAdjacentMineSquares(SafeSquare safeSquare, int row)
        {
            if (row == -1 || row == Rows)
                return;

            for (int col = safeSquare.Column - 1; col <= safeSquare.Column + 1; col++)
            {
                if (_sqaures[row, col] is MineSquare)
                    safeSquare.InCreaseAdjacentMineSquares();
            }
        }

        public static MineField Add(Square[,] input)
        {
            var mineFiled = new MineField(input.GetLength(0), input.GetLength(1));
            for (int row = 0; row < mineFiled.Rows; row++)
            {
                for (int col = 0; col < mineFiled.Columns; col++)
                {
                    if (input[row, col] is MineSquare)
                        mineFiled.AddSquare(row, col, true);
                    else
                        mineFiled.AddSquare(row, col, false);
                }
            }
            return mineFiled;
        }
    }
}