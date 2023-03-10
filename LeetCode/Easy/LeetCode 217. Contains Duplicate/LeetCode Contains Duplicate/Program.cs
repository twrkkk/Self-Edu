using System;
using System.Collections.Generic;

namespace LeetCode_Contains_Duplicate
{
    class Program
    {
        public class Solution
        {
            //public bool ContainsDuplicate(int[] nums)
            //{
            //    Dictionary<int, int> d = new Dictionary<int, int>();
            //    foreach (var item in nums)
            //        if (!d.ContainsKey(item))
            //            d.Add(item, 1);
            //        else
            //            return true;
            //    return false;
            //}
            public bool ContainsDuplicate(int[] nums)
            {
                return nums.Length != new HashSet<int>(nums).Count;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
