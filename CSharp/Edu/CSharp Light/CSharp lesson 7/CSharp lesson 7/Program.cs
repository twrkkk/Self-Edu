using System;
using System.Collections.Generic;

namespace CSharp_lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };
            //numbers.AddRange(new int[4] { 7, 8, 9, 0 });
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue<int> queue = new Queue<int>(5);
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //queue.Dequeue();

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack<int> stack = new Stack<int>(5);

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);

            //stack.Pop();

            //foreach (var item in stack)
            //{
            //    Console.WriteLine($"elem = {item}");
            //}

            Dictionary<int, string> sportsmans = new Dictionary<int, string>(5);
            sportsmans.Add(1, "abc");
            sportsmans.Add(2, "abcd");
            sportsmans.Add(3, "abcde");
            sportsmans.Add(4, "abcdef");
            sportsmans.Add(5, "abcdefg");
            sportsmans.Add(6, "abcdefgh");


            foreach (var item in sportsmans)
            {
                Console.WriteLine($"number - {item.Key} surname - {item.Value}");
            }
        }

    }
}
