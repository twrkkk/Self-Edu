using System;

namespace LeetCode_Remove_Linked_List_element
{
    class Program
    {

        //* Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public class Solution
        {
            public ListNode RemoveElements(ListNode head, int val)
            {
                ListNode dummy = new ListNode(next: head);
                ListNode prev = dummy, curr = head;

                while (curr != null)
                {
                    if (curr.val == val)
                        prev.next = curr.next;
                    else
                        prev = curr;
                    curr = curr.next;
                }
                return dummy.next;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
