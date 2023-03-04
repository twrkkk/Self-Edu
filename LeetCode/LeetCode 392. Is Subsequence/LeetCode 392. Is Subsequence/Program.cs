using System;

namespace LeetCode_392._Is_Subsequence
{
    public class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            int i = 0, j = 0;
            while (i < s.Length && j < t.Length)
            {
                if (s[i] == t[j])
                    ++i;
                ++j;
            }
            return i == s.Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
