using System;

namespace LeetCode_338._Counting_Bits
{
    class Program
    {
        public class Solution
        {
            public int[] CountBits(int n)
            {
                int[] result = new int[n + 1];
                for (int i = 0; i <= n; i++)
                {
                    int num = i;
                    while (num > 0)
                    {
                        result[i] += num % 2;
                        num /= 2;
                    }
                }
                return result;
            }

            public int[] CountBits2(int n)
            {
                int[] result = new int[n + 1];
                for (int i = 0; i <= n; i++)
                    result[i] = result[i / 2] + i % 2;
                return result;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
