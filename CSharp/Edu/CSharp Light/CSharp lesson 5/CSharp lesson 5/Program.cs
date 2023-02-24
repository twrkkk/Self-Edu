using System;

namespace CSharp_lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            method(2, c: 2);
            int sum;
            Sum(out sum, 1, 2);
            Console.WriteLine(sum);
        }

        static void method(int a, int b = 0, int c = 1)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        static void Sum(out int sum, int x, int y)
        {
            sum = x + y;
        }
    }
}
