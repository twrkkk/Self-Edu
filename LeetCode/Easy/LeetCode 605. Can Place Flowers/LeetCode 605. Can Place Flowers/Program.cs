using System;

namespace LeetCode_605._Can_Place_Flowers
{
    public class Solution
    {
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int[] f = new int[flowerbed.Length + 2];
            f[0] = 0;
            for (int i = 1; i <= flowerbed.Length; i++)
                f[i] = flowerbed[i - 1];
            f[f.Length - 1] = 0;

            for (int i = 1; i < f.Length-1; i++)
            {
                if(f[i - 1] == 0 && f[i] == 0 && f[i+1] == 0)
                {
                    f[i] = 1;
                    n--;
                }
            }
            return n <= 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.CanPlaceFlowers(new[] { 1, 0, 0, 0, 0, 1 },2));
        }
    }
}
