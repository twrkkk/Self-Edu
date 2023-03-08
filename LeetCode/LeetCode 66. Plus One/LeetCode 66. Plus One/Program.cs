using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_66._Plus_One
{
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; --i)
            {
                if (digits[i] == 9)
                    digits[i] = 0;
                else
                {
                    digits[i]++;
                    return digits;
                }
            }
            int[] result = new int[] { 1 };
            return result.Concat(digits).ToArray();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
