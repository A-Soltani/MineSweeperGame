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
            int rows = 2;
            int columns = 3;
            MineField mineField = MineField.Add(rows, columns);

            // Act
            List<Square> squares = mineField.GetSquares();

            // Assert
            Assert.NotNull(squares);
        }

        [Test]
        public void AddSquare_FirstSquareIsAddedToEmptyMineField_MineFieldHavingOneSquareShouldBeReturned()
        {
            // Arrange
            int mineFiledRows = 2;
            int mineFiledRColumns = 3;
            var mineField = MineField.Add(mineFiledRows, mineFiledRColumns);

            int squareRow = 0;
            int sqaureColumn = 1;
            bool sqaureHasMine = true;
            var expectedSquareCount = 1;

            // Act
            mineField.AddSquare(squareRow, sqaureColumn, sqaureHasMine);
            var squares = mineField.GetSquares();

            // Assert
            Assert.That(squares, Has.Count.EqualTo(expectedSquareCount));

        }
    }
}