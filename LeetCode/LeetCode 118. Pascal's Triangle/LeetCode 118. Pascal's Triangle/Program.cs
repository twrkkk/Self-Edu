using System;
using System.Collections.Generic;

namespace LeetCode_118._Pascal_s_Triangle
{
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>(numRows);
            if(numRows > 0)
                result.Add(new List<int>() { 1 });
            if(numRows > 1)
                result.Add(new List<int>() { 1, 1 });
            for (int i = 2; i < numRows; i++)
            {
                result.Add(new List<int>());
                result[i].Add(1);
                for (int j = 1; j < i; j++)
                {
                    result[i].Add(result[i - 1][j - 1] + result[i - 1][j]);
                }
                result[i].Add(1);
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
