using System;
using System.Linq;

namespace Stepik_Merge_Sort__inverse_count_
{
    class Program
    {
        static long InverseCount = 0;

        static long[] sort(long[] array)
        {
            InverseCount = 0;
            if (array == null) return null;
            if (array.Length == 0) return array;
            return sort(array, 0, array.Length - 1);
        }

        static long[] sort(long[] array, long low, long high)
        {
            if (low > high - 1) return new long[] { array[low] };
            long mid = low + (high - low) / 2;

            return merge(sort(array, low, mid), sort(array, mid + 1, high));
        }

        static long[] merge(long[] array1, long[] array2)
        {
            long cursor1 = 0;
            long cursor2 = 0;
            long[] merged = new long[array1.Length + array2.Length];
            long mergedCursor = 0;

            while (cursor1 < array1.Length && cursor2 < array2.Length)
            {

                if (array1[cursor1] <= array2[cursor2])
                    merged[mergedCursor++] = array1[cursor1++];
                else
                {
                    merged[mergedCursor++] = array2[cursor2++];
                    InverseCount += (array1.Length - cursor1);
                }
            }

            while (cursor1 < array1.Length)
                merged[mergedCursor++] = array1[cursor1++];

            while (cursor2 < array2.Length)
                merged[mergedCursor++] = array2[cursor2++];

            return merged;
        }

        static void Main(string[] args)
        {
            long count = Convert.ToInt32(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            long[] a = new long[count];
            for (long i = 0; i < count; i++) a[i] = Int64.Parse(s[i]);


            long[] res = sort(a);



            Console.WriteLine(InverseCount);
        }

    }
}
