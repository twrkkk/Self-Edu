using System;
using System.IO;

namespace CSharp_lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            Console.WriteLine(arr.Length);
            arr = Resize(arr, 6);
            Console.WriteLine(arr.Length);
            int[,] arr2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine(arr2.Length);
            arr2 = Resize(arr2, 5, 5);
            Console.WriteLine(arr2.Length);

            DrawHelathBar(5, 10);

            Console.WriteLine();
            char[,] map = CreateMap("map.txt");
            DrawMap(map, ConsoleColor.Blue);
        }
        #region Overload
        static int[] Resize(int[] arr, int newSize)
        {
            int[] newArr = new int[newSize];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            arr = newArr;
            return arr;
        }

        static int[,] Resize(int[,] arr, int x, int y)
        {
            int[,] newArr = new int[x, y];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    newArr[i, j] = arr[i, j];
                }
            }
            arr = newArr;
            return arr;
        }
        #endregion

        #region HealthBar
        static void DrawHelathBar(int value, int maxValue, char filledSymbol = ' ')
        {
            Console.Write('[');

            string Health = "";
            for (int i = 0; i < value; i++)
            {
                Health += " ";
            }
            ConsoleColor defaultColor = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(Health);
            Console.BackgroundColor = defaultColor;
            for (int i = 0; i < maxValue - value; i++)
            {
                Console.Write(' ');
            }
            Console.Write(']');
        }
        #endregion

        static char [,] CreateMap(string filePath)
        {
            string[] FileInfo = File.ReadAllLines(filePath);
            char[,] map = new char[FileInfo.Length,FileInfo[0].Length];

            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    map[x, y] = FileInfo[x][y];
                }
            }

            return map;
        }

        static void DrawMap(char[,] map, ConsoleColor color = ConsoleColor.White)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    Console.Write(map[x, y]);
                }
                Console.Write('\n');
            }
            Console.ForegroundColor = defaultColor;
        }
    }
}
