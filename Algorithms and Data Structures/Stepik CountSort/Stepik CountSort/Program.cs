using System;
using System.Linq;

namespace Stepik_CountSort
{
    class Program
    {
        static int[] CountSort(int[] array, int k)
        {
            var count = new int[k + 1];
            for (var i = 0; i < array.Length; i++)
                count[array[i]]++;

            var index = 0;
            for (var i = 0; i < count.Length; i++)
            {
                for (var j = 0; j < count[i]; j++)
                    array[index++] = i;
            }

            return array;
        }

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            foreach (var item in CountSort(arr, 10))
            {
                Console.Write(item + " ");
            }
        }
    }
}
