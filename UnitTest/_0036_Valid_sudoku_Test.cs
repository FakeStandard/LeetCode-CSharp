using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0036.Valid_sudoku;

namespace _0036.Valid_sudoku.Tests
{
    [TestClass()]
    public class _0036_Valid_sudoku_Test
    {
        _0036_Valid_sudoku solution = new _0036_Valid_sudoku();

        [TestMethod()]
        public void IsValidSudoku_Test1()
        {
            // Arrange
            char[][] board = new char[][]
            {
                new char[]{ '5','3','.','.','7','.','.','.','.' },
                new char[]{ '6','.','.','1','9','5','.','.','.' },
                new char[]{ '.','9','8','.','.','.','.','6','.' },
                new char[]{ '8','.','.','.','6','.','.','.','3' },
                new char[]{ '4','.','.','8','.','3','.','.','1' },
                new char[]{ '7','.','.','.','2','.','.','.','6' },
                new char[]{ '.','6','.','.','.','.','2','8','.' },
                new char[]{ '.','.','.','4','1','9','.','.','5' },
                new char[]{ '.','.','.','.','8','.','.','7','9' },
            };

            // Act
            var actual = solution.IsValidSudoku(board);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsValidSudoku_Test2()
        {
            // Arrange
            char[][] board = new char[][]
            {
                new char[]{ '8','3','.','.','7','.','.','.','.' },
                new char[]{ '6','.','.','1','9','5','.','.','.' },
                new char[]{ '.','9','8','.','.','.','.','6','.' },
                new char[]{ '8','.','.','.','6','.','.','.','3' },
                new char[]{ '4','.','.','8','.','3','.','.','1' },
                new char[]{ '7','.','.','.','2','.','.','.','6' },
                new char[]{ '.','6','.','.','.','.','2','8','.' },
                new char[]{ '.','.','.','4','1','9','.','.','5' },
                new char[]{ '.','.','.','.','8','.','.','7','9' },
            };

            // Act
            var actual = solution.IsValidSudoku(board);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}