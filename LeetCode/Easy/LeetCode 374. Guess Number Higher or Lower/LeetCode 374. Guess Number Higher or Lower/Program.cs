﻿using System;

namespace LeetCode_374._Guess_Number_Higher_or_Lower
{
    /** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

    public class Solution : GuessGame
    {
        public int GuessNumber(int n)
        {
            int l = 1, r = n;
            int mid = 1;
            while (l <= r)
            {
                mid = l + (r - l) / 2;
                if (guess(mid) == 0)
                    return mid;
                else if (guess(mid) == -1)
                    r = mid - 1;
                else
                    l = mid + 1;
            }
            return mid;
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
