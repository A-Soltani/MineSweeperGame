
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
            MineField mineField = MineField.Add(0, 0);

            // Act
            Square[,] adjacentMineSquares = MineSweeperService.GetAdjacentMineSquares(mineField);

            // Assert
            Assert.IsNull(adjacentMineSquares);
        }

        [Test]
        public void GetAdjacentMineSquares_MineFieldIsOneByOneIncludingMine_OneMineSquareShouldBeReturned()
        {
            // Arrange
            MineField mineField = MineField.Add(1, 1);
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

        [Test]
        public void GetAdjacentMineSquares_MineFieldIsOneDimentionIncludingOneMineAndOneSafeSquare_OneMineAndOneSafeSquaresShouldBeReturned()
        {
            // Arrange
            MineField mineField = MineField.Add(1, 2);
            var mineSqaureRow = 0;
            var mineSquareColumn = 0;
            mineField.AddSquare(mineSqaureRow, mineSquareColumn, true);

            var safeSqaureRow = 0;
            var safeSquareColumn = 1;
            mineField.AddSquare(safeSqaureRow, safeSquareColumn, false);

            // Act
            var adjacentMineSquares = MineSweeperService.GetAdjacentMineSquares(mineField);

            // Assert
            Assert.IsInstanceOf<MineSquare>(adjacentMineSquares[mineSqaureRow, mineSquareColumn]);
            Assert.IsInstanceOf<SafeSquare>(adjacentMineSquares[safeSqaureRow, safeSquareColumn]);
        }

        [Test]
        public void GetAdjacentMineSquares_MineFieldIsMultiDimentions_MultiDimentionsSquaresShouldBeReturned()
        {
            // Arrange
            Square[,] input = {
                { MineSquare.Add(0,0), SafeSquare.Add(0,1), SafeSquare.Add(0,2), SafeSquare.Add(0,3) },
                { SafeSquare.Add(1,0), SafeSquare.Add(1,1), MineSquare.Add(1,2), SafeSquare.Add(1,3) },
                { SafeSquare.Add(2,0), SafeSquare.Add(2,1), SafeSquare.Add(2,2), SafeSquare.Add(2,3) }
            };
            MineField mineField = MineField.Add(input);

            // Act
            var adjacentMineSquares = MineSweeperService.GetAdjacentMineSquares(mineField);

            // Assert
            Assert.IsInstanceOf<MineSquare>(adjacentMineSquares[0, 0]);
            Assert.IsInstanceOf<SafeSquare>(adjacentMineSquares[0, 1]);
        }

    }
}