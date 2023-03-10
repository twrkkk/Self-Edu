using System;

namespace LeetCode_876._Middle_of_the_Linked_List
{
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
        private int GetCount(ListNode node)
        {
            int count = 1;
            while (node.next != null)
            {
                node = node.next;
                count++;
            }
            return count;
        }
        public ListNode MiddleNode(ListNode head)
        {
            int count = GetCount(head);
            int currPos = 0;
            while (currPos < count / 2)
            {
                head = head.next;
                currPos++;
            }
            return head;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
