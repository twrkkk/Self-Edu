using System;

namespace CSharp_lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;

            string[,] bookshelf = {
                { "Пушкин", "Лермонтов", "Достоевский"},
                { "Грин", "Мартин","Хилл"},
                { "Есенин", "Левитин","Страуструп"}
            };
            while (isOpen)
            {
                Console.SetCursorPosition(0, 20);
                for (int i = 0; i < bookshelf.GetLength(0); i++)
                {
                    for (int j = 0; j < bookshelf.GetLength(1); j++)
                    {
                        Console.Write(bookshelf[i, j] + " | ");
                    }
                    Console.WriteLine();
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Library\n");

                Console.WriteLine("\n1. Найти книгу по номеру полки и номеру колонки\n\n" +
                                  "2. Найти книгу по автору\n\n" +
                                  "3. Выход\n\n");

                Console.Write("Выполнить команду: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        int line, column;
                        Console.Write("Введите номер полки: ");
                        line = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите номер колонки: ");
                        column = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"На полке {line} в колонке {column} находится {bookshelf[line - 1, column - 1]}");
                        break;
                    case "2":
                        string author;
                        bool isFind = false;
                        Console.Write("Введите автора ");
                        author = Console.ReadLine();
                        for (int i = 0; i < bookshelf.GetLength(0); i++)
                        {
                            for (int j = 0; j < bookshelf.GetLength(1); j++)
                            {
                                if (author.ToLower() == bookshelf[i, j].ToLower())
                                {
                                    Console.WriteLine($"Книга {author} находится на полке {i + 1} в колонке {j + 1}");
                                    isFind = true;
                                }
                            }
                        }
                        if (!isFind)
                            Console.WriteLine("Такого автора нет\n");
                        break;
                    case "3":
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("Я не знаю такой команды\n");
                        break;
                }

                Console.WriteLine("Нажмите любую клавишу для продолжения...\n");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
