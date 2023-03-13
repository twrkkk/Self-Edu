using System;

namespace Medium_LeetCode_88._Merge_Sorted_Array
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1, j = n - 1, k = m + n - 1;
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                    nums1[k--] = nums1[i--];
                else
                    nums1[k--] = nums2[j--];
            }

            while (i >= 0)
                nums1[k--] = nums1[i--];
            while (j >= 0)
                nums1[k--] = nums2[j--]; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] nums1 = new[] { 0 };
            s.Merge(nums1, 0, new[] { 1 }, 1);
        }
    }
}
