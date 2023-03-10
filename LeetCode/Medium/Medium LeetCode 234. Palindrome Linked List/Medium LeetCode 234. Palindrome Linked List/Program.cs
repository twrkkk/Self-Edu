using System;
using System.Collections.Generic;

namespace Medium_LeetCode_234._Palindrome_Linked_List
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
        public static bool IsPalindrome(ListNode head)
        {
            List<int> list = new List<int>();
            while (head.next != null)
            {
                list.Add(head.val);
                head = head.next;
            }

            int i = 0, j = list.Count - 1;
            while (i < j && list[i] == list[j])
            {
                ++i;
                --j;
            }

            return i == list.Count - 1;
        }
    }
    class Program
    {
        static bool IsPalindrome(ListNode head)
        {
            //List<int> list = new List<int>();
            //while (head != null)
            //{
            //    list.Add(head.val);
            //    head = head.next;
            //}

            //if (list.Count < 2)
            //    return true;

            //int i = 0, j = list.Count - 1;
            //while (i <= j && list[i] == list[j])
            //{
            //    ++i;
            //    --j;
            //}

            //return i == list.Count / 2 + list.Count % 2;

            ListNode tmpHead = head;
            ListNode prevNode = new ListNode(tmpHead.val);
            tmpHead = tmpHead.next;
            while(tmpHead != null)
            {
                ListNode newNode = new ListNode(tmpHead.val, prevNode);
                prevNode = newNode;
                tmpHead = tmpHead.next;
            }

            while(head != null && prevNode != null)
            {
                if (head.val != prevNode.val)
                    return false;
                head = head.next;
                prevNode = prevNode.next;
            }

            return true;
        }
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            //ListNode dummy = new ListNode(next: head);
            ListNode l1 = new ListNode(2);
            ListNode l2 = new ListNode(2);
            ListNode l3 = new ListNode(1);
            //ListNode l4 = new ListNode(1);
            head.next = l1;
            l1.next = l2;
            l2.next = l3;
            //l3.next = l4;
            Console.WriteLine(IsPalindrome(head));
        }
    }
}
