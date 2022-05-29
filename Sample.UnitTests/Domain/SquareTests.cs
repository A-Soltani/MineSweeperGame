using NUnit.Framework;
using Sample.Domain;

namespace Sample.UnitTests
{
    public class SquareTests
    {

        [Test]
        public void Add_ValidArgument_SquareShouldBeReturned()
        {
            // Arrange
            int row = 1;
            int column = 2;
            bool hasMine = false;

            // Act
            Square square = Square.Add(row, column, hasMine);

            // Assert
            Assert.NotNull(square);
            Assert.AreEqual(square.Row, row);
            Assert.AreEqual(square.Column, column);
            Assert.AreEqual(square.HasMine, hasMine);
        }

    }

}