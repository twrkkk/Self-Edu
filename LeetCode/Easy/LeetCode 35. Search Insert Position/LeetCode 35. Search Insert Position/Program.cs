using System;

namespace LeetCode_35._Search_Insert_Position
{
    public class Solution
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int l = 0, r = nums.Length - 1;
            int mid = 0;
            while(l<=r)
            {
                mid = l + (r - l) / 2;
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                    r = mid  -1;
                else
                    l = mid + 1;
            }
            return l;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.SearchInsert(new[] { 1, 3, 5, 6 }, 7));
        }
    }
}
