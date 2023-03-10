using System;

namespace LeetCode_344._Reverse_String
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            int i = 0, j = s.Length - 1;
            char tmp;
            while (i < j)
            {
                tmp = s[j];
                s[j--] = s[i];
                s[i++] = tmp;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
