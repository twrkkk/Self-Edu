using System;
using System.Collections.Generic;

namespace LeetCode_1346._Check_If_N_and_Its_Double_Exist
{
    public class Solution
    {
        public bool CheckIfExist(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int elem in arr)
            {
                if (set.Contains(elem * 2) || (elem % 2 == 0 && set.Contains(elem / 2)))
                    return true;
                set.Add(elem);
            }
            return false;
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
