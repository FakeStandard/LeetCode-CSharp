using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1290.Convert_binary_number_in_a_linked_list_to_integer;
using Common;

namespace _1290.Convert_binary_number_in_a_linked_list_to_integer.Tests
{
    [TestClass()]
    public class _1290_Convert_binary_number_in_a_linked_list_to_integer_Test
    {
        _1290_Convert_binary_number_in_a_linked_list_to_integer solution = new _1290_Convert_binary_number_in_a_linked_list_to_integer();

        [TestMethod()]
        public void GetDecimalValue_Test1()
        {
            // Arrange
            ListNode head = AddNode(new int[] { 1, 0, 1 });
            var expected = 5;

            // Act
            var actual = solution.GetDecimalValue(head);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetDecimalValue_Test2()
        {
            // Arrange
            ListNode head = AddNode(new int[] { 0, });
            var expected = 0;

            // Act
            var actual = solution.GetDecimalValue(head);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetDecimalValue_Test3()
        {
            // Arrange
            ListNode head = AddNode(new int[] { 1 });
            var expected = 1;

            // Act
            var actual = solution.GetDecimalValue(head);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetDecimalValue_Test4()
        {
            // Arrange
            ListNode head = AddNode(new int[] { 1, 0, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0 });
            var expected = 18880;

            // Act
            var actual = solution.GetDecimalValue(head);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetDecimalValue_Test5()
        {
            // Arrange
            ListNode head = AddNode(new int[] { 0, 0 });
            var expected = 0;

            // Act
            var actual = solution.GetDecimalValue(head);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        private ListNode AddNode(int[] arr)
        {
            ListNode res = new ListNode(arr[0]);
            ListNode current = res;

            for (int i = 1; i < arr.Length; i++)
            {
                ListNode newNode = new ListNode(arr[i]);

                current.next = newNode;
                current = current.next;
            }

            return res;
        }
    }
}