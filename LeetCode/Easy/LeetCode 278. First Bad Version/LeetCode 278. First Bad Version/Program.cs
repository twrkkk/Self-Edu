using System;

namespace LeetCode_278._First_Bad_Version
{
    /* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

    public class Solution : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            int l = 1, r = n;
            int mid = 1;
            while (l < r)
            {
                mid = l + (r - l) / 2;
                if (IsBadVersion(mid))
                    r = mid;
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
            Console.WriteLine("Hello World!");
        }
    }
}
