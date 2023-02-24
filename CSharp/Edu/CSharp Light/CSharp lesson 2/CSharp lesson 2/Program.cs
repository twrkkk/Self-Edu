using System;

namespace CSharp_lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Добро пожаловать в игру Угадай число! ");

            int number, lower, higher, userInput, triesCount = 5;
            number = rand.Next(0, 101);

            while (triesCount-- > 0)
            {
                lower = rand.Next(number - 10, number);
                higher = rand.Next(number + 1, number + 10);
                Console.WriteLine($"Загаданное число больше {lower}, но меньше {higher} ");
                Console.Write("Введите число ");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == number)
                {
                    Console.WriteLine("Вы выиграли! Это число " + number);
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный ответ! Осталось попыток " + triesCount);
                }
            }

            if (triesCount < 0)
            {
                Console.WriteLine("Вы проиграли! Правильный ответ: " + number);
            }
        }
    }
}
