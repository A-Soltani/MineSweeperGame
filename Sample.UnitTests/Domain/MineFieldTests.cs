using System.Collections.Generic;
using NUnit.Framework;
using Sample.Domain;

namespace Sample.UnitTests
{
    public class MineFieldTests
    {
        [Test]
        public void Add_ValidArguments_MineFieldShouldBeReturned()
        {
            // Arrange
            int rows = 2;
            int columns = 3;

            // Act
            MineField mineField = MineField.Add(rows, columns);

            // Assert
            Assert.AreEqual(mineField.Rows, rows);
            Assert.AreEqual(mineField.Columns, columns);
        }

        [Test]
        public void GetSquares_MineFieldHasNoSquare_ListOfSquaresIncludingNoSqaureShouldBeReturned()
        {
            // Arrange
            // Arrange
            int rows = 1;
            int columns = 1;
            MineField mineField = MineField.Add(rows, columns);

            // Act
            var squares = mineField.GetSquares();

            // Assert
            Assert.NotNull(squares);
        }

        [Test]
        public void AddSquare_FirstSquareIsAddedToEmptyMineField_MineFieldHavingOneSquareShouldBeReturned()
        {
            // Arrange
            int mineFiledRows = 1;
            int mineFiledRColumns = 1;
            var mineField = MineField.Add(mineFiledRows, mineFiledRColumns);

            int squareRow = 0;
            int sqaureColumn = 0;
            bool sqaureHasMine = true;

            // Act
            mineField.AddSquare(squareRow, sqaureColumn, sqaureHasMine);
            var squares = mineField.GetSquares();

            // Assert
            Assert.NotNull(squares[0, 0]);
        }
    }
}