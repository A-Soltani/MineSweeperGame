
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Sample.Domain;

namespace Sample.UnitTests
{
    public class MineSweeperServiceTests
    {
        [Test]
        public void GetAdjacentMineSquares_MineFieldHasNoSquare_NullShouldBeReturned()
        {
            // Arrange
            MineField mineField = new MineField(0, 0);

            // Act
            Square[,] adjacentMineSquares = MineSweeperService.GetAdjacentMineSquares(mineField);

            // Assert
            Assert.IsNull(adjacentMineSquares);
        }

        [Test]
        public void GetAdjacentMineSquares_MineFieldIsOneByOneIncludingMine_OneMineSquareShouldBeReturned()
        {
            // Arrange
            MineField mineField = new MineField(1, 1);
            var sqaureRow = 0;
            var squareColumn = 0;
            var sqaureHasMine = true;
            mineField.AddSquare(sqaureRow, squareColumn, sqaureHasMine);

            // Act
            var adjacentMineSquares = MineSweeperService.GetAdjacentMineSquares(mineField);

            // Assert
            Assert.NotNull(adjacentMineSquares);
            Assert.IsInstanceOf<MineSquare>(adjacentMineSquares[0, 0]);
        }
    }
}