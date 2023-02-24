using System;

namespace part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            Table[] tables = { new Table(1, 4), new Table(2, 8), new Table(3, 12) };
            while(isOpen)
            {
                Console.WriteLine("Администрирование Кафе у Михалыча\n");

                foreach (var table in tables)
                {
                    table.ShowInfo();
                }
                Console.WriteLine();

                Console.WriteLine("Введите номер стола");
                int wishTable = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Сколько мест забронировать?");
                int reservePlaces = Convert.ToInt32(Console.ReadLine());

                if(tables[wishTable - 1].ReservePlaces(reservePlaces))
                {
                    Console.WriteLine("Бронирование успешно");
                }
                else
                {
                    Console.WriteLine("Ошибка! Недостаточно мест");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        class Table
        {
            public int Number;
            public int FreePlaces;
            public int MaxPlaces;

            public Table() { }
            public Table(int number, int freePlaces)
            {
                Number = number;
                FreePlaces = freePlaces;
                MaxPlaces = freePlaces;
            }

            public bool ReservePlaces(int count)
            {
                bool result = true;
                if (count > FreePlaces) 
                    result = false;
                else
                {
                    FreePlaces -= count;
                }
                return result;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Номер стола {Number} свободно {FreePlaces} из {MaxPlaces}");
            }
        }

    }
}
