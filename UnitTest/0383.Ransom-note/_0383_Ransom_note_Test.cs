using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0383.Ransom_note;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0383.Ransom_note.Tests
{
    [TestClass()]
    public class _0383_Ransom_note_Test
    {
        _0383_Ransom_note solution = new _0383_Ransom_note();

        [TestMethod()]
        public void CanConstruct_Test1()
        {
            // Arrange
            string ransomNote = "a";
            string magazine = "b";

            // Act
            var actual = solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void CanConstruct_Test2()
        {
            // Arrange
            string ransomNote = "aa";
            string magazine = "ab";

            // Act
            var actual = solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void CanConstruct_Test3()
        {
            // Arrange
            string ransomNote = "aa";
            string magazine = "aab";

            // Act
            var actual = solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.IsTrue(actual);
        }
    }
}