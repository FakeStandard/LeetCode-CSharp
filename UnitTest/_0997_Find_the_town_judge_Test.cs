using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0997.Find_the_town_judge;

namespace _0997.Find_the_town_judge.Tests
{
    [TestClass()]
    public class _0997_Find_the_town_judge_Test
    {
        _0997_Find_the_town_judge solution = new _0997_Find_the_town_judge();

        [TestMethod()]
        public void FindJudge_Test1()
        {
            // Arrange
            int n = 2;
            int[][] trust =
            {
                new int[] { 1, 2 }
            };
            var expected = 2;

            // Act
            var actual = solution.FindJudge(n, trust);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindJudge_Test2()
        {
            // Arrange
            int n = 3;
            int[][] trust =
            {
                new int[] { 1, 3 },
                new int[] { 2, 3 }
            };
            var expected = 3;

            // Act
            var actual = solution.FindJudge(n, trust);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindJudge_Test3()
        {
            // Arrange
            int n = 3;
            int[][] trust =
            {
                new int[] { 1, 3 },
                new int[] { 2, 3 },
                new int[] { 3, 1 }
            };
            var expected = -1;

            // Act
            var actual = solution.FindJudge(n, trust);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindJudge_Test4()
        {
            // Arrange
            int n = 4;
            int[][] trust =
            {
                new int[] { 1, 3 },
                new int[] { 1, 4 },
                new int[] { 2, 3 },
                new int[] { 2, 4 },
                new int[] { 4, 3 }
            };
            var expected = 3;

            // Act
            var actual = solution.FindJudge(n, trust);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindJudge_Test5()
        {
            // Arrange
            int n = 2;
            int[][] trust = { };
            var expected = -1;

            // Act
            var actual = solution.FindJudge(n, trust);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindJudge_Test6()
        {
            // Arrange
            int n = 1;
            int[][] trust = { };
            var expected = 1;

            // Act
            var actual = solution.FindJudge(n, trust);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}