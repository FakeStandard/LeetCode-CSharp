using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0234.Palindrome_linked_list;
using Common;

namespace _0234.Palindrome_linked_list.Tests
{
    [TestClass()]
    public class _0234_Palindrome_linked_list_Test
    {
        _0234_Palindrome_linked_list solution = new _0234_Palindrome_linked_list();

        [TestMethod()]
        public void IsPalindrome_Test1()
        {
            // Arrange
            ListNode head = new ListNode();
            head = head.AddNode(new int[] { 1, 2, 2, 1 });

            // Act
            var actual = solution.IsPalindrome(head);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsPalindrome_Test2()
        {
            // Arrange
            ListNode head = new ListNode();
            head = head.AddNode(new int[] { 1, 2 });

            // Act
            var actual = solution.IsPalindrome(head);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}