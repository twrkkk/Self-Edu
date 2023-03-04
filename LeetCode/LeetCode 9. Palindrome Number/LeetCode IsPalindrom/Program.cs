using System;

namespace LeetCode_IsPalindrom
{
    class Program
    { 
        public class Solution
        {
            public bool IsPalindrome(int x)
            {
                string str = Convert.ToString(x);
                int size = str.Length;
                for (int i = 0; i < size; i++)
                    if (str[i] != str[size - i - 1])
                        return false;
                return true;
            }

            public bool IsPalindrome2(int x)
            {
                int rev = 0, c = x;
                while(c>0)
                {
                    rev = rev * 10 + c % 10;
                    c /= 10;
                }
                return rev == x;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
