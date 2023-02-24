using System;

namespace CSharp_lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Evgeny";
            //int age = 19;
            //Console.WriteLine("Ваше имя: " + name + " вам " + age + " лет!");
            //Console.WriteLine($"Ваше имя: {name} вам {age} лет!");

            //Console.WriteLine(5+5 + "Привет, мир!" + (5 + 5));

            Console.WriteLine("Please, input your name");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Input your age");
            int age;
            age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Congratulations {name}! \nYou`re {age} years old!");
            string intToStringAge = Convert.ToString(19);

            do
            {

            } while (5 != 5);
        }
    }
}
