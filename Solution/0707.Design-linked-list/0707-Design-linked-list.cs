using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0707.Design_linked_list
{
    public class _0707_Design_linked_list
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
        }

        public class MyLinkedList
        {
            private ListNode _head;
            private int _count = 0;

            /// <summary>
            /// Initializes the MyLinkedList object.
            /// </summary>
            public MyLinkedList()
            {
                _head = null;
            }

            /// <summary>
            /// Get the value of the indexth node in the linked list.
            /// If the index is invalid, return -1.
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            public int Get(int index)
            {
                if (index >= _count || index < 0 || _count == 0)
                    return -1;

                var curr = _head;

                while (curr != null && index > 0)
                {
                    curr = curr.next;
                    index--;
                }

                return curr == null ? -1 : curr.val;
            }

            /// <summary>
            /// Add a node of value val before the first element of the linked list.
            /// After the insertion, the new node will be the first node of the linked list.
            /// </summary>
            /// <param name="val"></param>
            public void AddAtHead(int val)
            {
                _head = new ListNode() { val = val, next = _head };

                _count++;
            }

            /// <summary>
            /// Append a node of value val as the last element of the linked list.
            /// </summary>
            /// <param name="val"></param>
            public void AddAtTail(int val)
            {
                var node = new ListNode() { val = val };

                if (_head == null)
                    _head = node;
                else
                {
                    var curr = _head;

                    while (curr.next != null)
                        curr = curr.next;

                    curr.next = node;
                }

                _count++;
            }

            /// <summary>
            /// Add a node of value val before the indexth node in the linked list.
            /// If index equals the length of the linked list, the node will be appended to the end of the linked list.
            /// If index is greater than the length, the node will not be inserted.
            /// </summary>
            /// <param name="index"></param>
            /// <param name="val"></param>
            public void AddAtIndex(int index, int val)
            {
                if (index > _count || index < 0) return;

                if (index == 0)
                    AddAtHead(val);
                else if (index == _count)
                    AddAtTail(val);
                else
                {
                    //int i = 0;
                    var curr = _head;

                    while (curr != null && index - 1 > 0)
                    {
                        curr = curr.next;
                        index--;
                    }

                    var temp = curr.next;
                    curr.next = new ListNode() { val = val, next = temp };
                }

                _count++;
            }

            /// <summary>
            /// Delete the indexth node in the linked list, if the index is valid.
            /// </summary>
            /// <param name="index"></param>
            public void DeleteAtIndex(int index)
            {
                if (index >= _count || index < 0 || _count == 0) return;

                if (index == 0)
                    _head = _head.next;
                else
                {
                    //int i = 0;
                    var curr = _head;

                    while (curr != null && index - 1 > 0)
                    {
                        curr = curr.next;
                        index--;
                    }

                    curr.next = curr.next?.next;
                }

                _count--;
            }
        }

        /**
         * Your MyLinkedList object will be instantiated and called as such:
         * MyLinkedList obj = new MyLinkedList();
         * int param_1 = obj.Get(index);
         * obj.AddAtHead(val);
         * obj.AddAtTail(val);
         * obj.AddAtIndex(index,val);
         * obj.DeleteAtIndex(index);
         */
    }
}
