using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_844.Backspace_String_Compare
{
    public class Solution
    {
        private Stack<char> helper(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var c in s)
            {
                if (c != '#')
                    stack.Push(c);
                else if (stack.Count > 0)
                    stack.Pop();
            }
            return stack;
        }
        public bool BackspaceCompare(string s, string t)
        {
            Stack<char> stackS = helper(s);
            Stack<char> stackT = helper(t);

            if (stackS.Count != stackT.Count)
                return false;

            while (stackS.Count > 0)
            {
                if (stackS.Pop() != stackT.Pop())
                    return false;
            }

            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
