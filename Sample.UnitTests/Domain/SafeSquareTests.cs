using NUnit.Framework;
using Sample.Domain;

namespace Sample.UnitTests
{
    public class SafeSquareTests
    {

        [Test]
        public void Add_ValidArgument_SafeSquareShouldBeReturned()
        {
            // Arrange
            int row = 1;
            int column = 2;

            // Act
            SafeSquare safeSquare = SafeSquare.Add(row, column);

            // Assert
            Assert.NotNull(safeSquare);
            Assert.AreEqual(safeSquare.Row, row);
            Assert.AreEqual(safeSquare.Column, column);
        }

    }

}