using System;

namespace LeetCode_258._Add_Digits
{
    public class Solution
    {
        public int AddDigits(int num)
        {
            int temp = num;
            int sum = int.MaxValue;
            while (sum > 9)
            {
                sum = 0;
                while (temp > 0)
                {
                    sum += temp % 10;
                    temp /= 10;
                }
                temp = sum;
            }
            return sum;
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
