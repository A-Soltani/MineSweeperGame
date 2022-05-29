using System;

namespace Sample.Domain
{
    public class Square
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public bool HasMine { get; set; }

        public Square(int row, int column, bool hasMine)
        {
            Row = row;
            Column = column;
            HasMine = hasMine;
        }

        public static Square Add(int row, int column, bool hasMine)
            => new Square(row, column, hasMine);
    }
}