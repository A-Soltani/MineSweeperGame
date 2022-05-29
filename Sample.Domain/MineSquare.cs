using System;

namespace Sample.Domain
{
    public class MineSquare : Square
    {
        public MineSquare(int row, int column) : base(row, column)
        {
        }

        public static MineSquare Add(int row, int column) => new MineSquare(row, column);
    }
}