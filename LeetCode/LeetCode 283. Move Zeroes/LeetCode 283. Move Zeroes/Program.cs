using System;

namespace LeetCode_283._Move_Zeroes
{
    public static class Solution
    {
        public static void MoveZeroes(int[] nums)
        {
            int i = 0, j = 0; // i = not zero pos, j = zero pos

        }
    }
    class Program
    {
        static void MoveZeroes(int[] nums)
        {
            int i = 0, j = 0;
            while (i < nums.Length)
            {
                if (nums[i] != 0)
                {
                    if (i != j)
                    {
                        int temp = nums[j];
                        nums[j] = nums[i];
                        nums[i] = temp;
                    }
                    ++j;
                }
                ++i;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 0, 3, 12 };
            MoveZeroes(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
