using System;

namespace Sample.Domain
{
    public class SafeSquare : Square
    {
        private int _adjacentMineSquares;
        public SafeSquare(int row, int column) : base(row, column)
        {

        }

        public static SafeSquare Add(int row, int column) => new SafeSquare(row, column);
        public void InCreaseAdjacentMineSquares() => ++_adjacentMineSquares;
        public int GetAdjacentMineSquares() => _adjacentMineSquares;
    }
}