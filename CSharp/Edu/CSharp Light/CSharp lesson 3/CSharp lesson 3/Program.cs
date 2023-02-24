using System;

namespace CSharp_lesson_3
{
    class Program
    {
        const int SIZE = 5;
        static void Main(string[] args)
        {
            int[] sectors = new int[SIZE] { 5, 7, 12, 15, 17 };
            bool isOpen = true;

            while (isOpen)
            {
                Console.SetCursorPosition(0, 20);
                int arraySize = sectors.Length;
                for (int i = 0; i < arraySize; i++)
                {
                    Console.WriteLine($"В секторе: {i + 1} свободно мест: {sectors[i]}");
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Регистрация рейса");

                Console.WriteLine("\n\n1 - Забронировать места\n\n2 - выход из программы\n\n");
                Console.Write("Выполнить команду: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int sectorNumber, countSeats;
                        Console.Write("Забронировать места в секторе: ");
                        sectorNumber = Convert.ToInt32(Console.ReadLine());
                        if (sectorNumber > SIZE || sectorNumber < 1)
                        {
                            Console.WriteLine($"В самолете нет {sectorNumber} сектора");
                            break;
                        }

                        Console.Write($"В секторе {sectorNumber} забронировать мест: ");
                        countSeats = Convert.ToInt32(Console.ReadLine());
                        if (countSeats > sectors[sectorNumber - 1] || countSeats < 0)
                        {
                            Console.WriteLine($"В секторе {sectorNumber} недостаточно мест, остаток: {sectors[sectorNumber - 1]}");
                            break;
                        }

                        sectors[sectorNumber - 1] -= countSeats;
                        
                        break;
                    case 2:
                        isOpen = false;
                        break;
                    default:
                        break;
                }


                Console.Clear();
                Console.SetCursorPosition(0, 0);
            }

        }
    }
}
