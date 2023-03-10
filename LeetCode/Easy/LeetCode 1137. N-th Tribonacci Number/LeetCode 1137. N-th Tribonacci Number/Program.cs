using System;

namespace LeetCode_1137._N_th_Tribonacci_Number
{
    public class Solution
    {
        public int Tribonacci(int n)
        {
            int[] arr = new int[n + 3];
            arr[0] = 0;
            arr[1] = 1;
            arr[2] = 1;
            for (int i = 3; i <= n; i++)
                arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];
            return arr[n];
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
