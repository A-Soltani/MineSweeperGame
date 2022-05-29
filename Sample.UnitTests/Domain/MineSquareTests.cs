using NUnit.Framework;
using Sample.Domain;

namespace Sample.UnitTests
{
    public class MineSquareTests
    {

        [Test]
        public void Add_ValidArgument_MineSquareShouldBeReturned()
        {
            // Arrange
            int row = 1;
            int column = 2;

            // Act
            MineSquare mineSquare = MineSquare.Add(row, column);

            // Assert
            Assert.NotNull(mineSquare);
            Assert.AreEqual(mineSquare.Row, row);
            Assert.AreEqual(mineSquare.Column, column);
        }

    }

}