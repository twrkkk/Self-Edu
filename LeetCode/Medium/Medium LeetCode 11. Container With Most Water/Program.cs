using System;

namespace Medium_LeetCode_11._Container_With_Most_Water
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int l = 0, r = height.Length - 1;
            int result = 0;
            while(l<r)
            {
                result = Math.Max(result, (r - l) * Math.Min(height[l], height[r]));
                if (height[l] < height[r])
                    ++l;
                else
                    --r;
            }

            return result;
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
