using System;
using System.Collections.Generic;

namespace Sample.Domain
{
    public class MineSweeperService
    {
        public static List<Square> GetAdjacentMineSquares(MineField mineField)
        {
            List<Square> adjacentMineSquares = null;
            var squares = mineField.GetSquares();
            if (mineField.Rows > 0 && mineField.Columns > 0)
            {
                adjacentMineSquares = new List<Square>();
                if (mineField.Rows == 1 && mineField.Columns == 1)
                {
                    if (squares[0, 0] is MineSquare)
                        adjacentMineSquares.Add(new MineSquare(0, 0));
                }
            }
            return adjacentMineSquares;
        }
    }
}