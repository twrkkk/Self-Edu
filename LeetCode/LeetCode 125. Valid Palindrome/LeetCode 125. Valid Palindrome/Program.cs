using System;
using System.Linq;

namespace LeetCode_125._Valid_Palindrome
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            string after = new string(s.Where(e => (char.IsLetter(e) || char.IsDigit(e))).ToArray()).ToLower();
            bool result = true;
            int i = 0, j = after.Length - 1;
            while (result && i < j)
                result = after[i++] == after[j--];
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
