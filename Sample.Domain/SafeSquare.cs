using System;

namespace Sample.Domain
{
    public class SafeSquare : Square
    {
        public SafeSquare(int row, int column) : base(row, column)
        {
        }

        public static SafeSquare Add(int row, int column) => new SafeSquare(row, column);
    }
}