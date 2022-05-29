using System;

namespace Sample.Domain
{
    public abstract class Square
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public Square(int row, int column)
        {
            Row = row;
            Column = column;
        }

    }
}