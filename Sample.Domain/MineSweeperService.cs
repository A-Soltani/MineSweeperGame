using System;
using System.Collections.Generic;

namespace Sample.Domain
{
    public class MineSweeperService
    {
        public static Square[,] GetAdjacentMineSquares(MineField mineField)
        {
            Square[,] adjacentMineSquares = null;
            var squares = mineField.GetSquares();
            if (mineField.Rows > 0 && mineField.Columns > 0)
            {
                adjacentMineSquares = new Square[mineField.Rows, mineField.Columns];
                if (mineField.Rows == 1 && mineField.Columns == 1)
                {
                    if (squares[0, 0] is MineSquare)
                        adjacentMineSquares[0, 0] = new MineSquare(0, 0);
                }
            }
            return adjacentMineSquares;
        }
    }
}