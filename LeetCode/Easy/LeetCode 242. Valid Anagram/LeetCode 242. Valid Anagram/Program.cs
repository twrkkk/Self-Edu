using System;
using System.Collections.Generic;

namespace LeetCode_242._Valid_Anagram
{
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (!dict.ContainsKey(c))
                    dict.Add(c, 1);
                else
                    dict[c]++;
            }

            foreach (char c in t)
            {
                if (!dict.ContainsKey(c))
                    return false;
                else
                {
                    dict[c]--;
                    if (dict[c] < 0)
                        return false;
                }
            }

            foreach (var v in dict.Values)
            {
                if (v > 0)
                    return false;
            }
            return true;
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
