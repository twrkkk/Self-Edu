using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_lesson_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //long b = long.MaxValue;//long b = 23;
            //a = (int)b;
            //Console.WriteLine(a + " " + b);



            //Persone persone = new Persone ("Petr", 20);
            //Student student = persone as Student;
            //if(student != null)
            //{
            //    student = (Student)persone;
            //    Console.WriteLine(student.AverageScore); 
            //}
            ////паттерн Matching
            //switch (persone)
            //{
            //    case Student student2:
            //        Console.WriteLine("Это студент со средним баллом: " + student2.AverageScore);
            //        break;
            //    case Teacher teacher:
            //        Console.WriteLine("Это преподаватель с " + teacher.StudentsCount + " учениками");
            //        break;
            //    case Persone persone2:
            //        Console.WriteLine("Не удалось преобразовать объект");
            //        break;
            //}
            //class Persone
            //{
            //    public string Name { get; private set; }
            //    public int Age { get; private set; }

            //    public Persone(string name, int age)
            //    {
            //        Name = name;
            //        Age = age;
            //    }
            //}

            //class Student : Persone
            //{
            //    public int AverageScore { get; private set; }

            //    public Student(string name, int age, int averageScore) : base(name, age)
            //    {
            //        AverageScore = averageScore;
            //    }
            //}

            //class Teacher : Persone
            //{
            //    public int StudentsCount { get; private set; }
            //    public Teacher(string name, int age, int studentsCount):base(name,age)
            //    {
            //        StudentsCount = studentsCount;
            //    }
            //}




            //Linq
            List<Player> players = new List<Player> {
                new Player("John", 34),
                new Player("Alfa", 12),
                new Player("Beta", 54),
                new Player("Gamma", 38),
                new Player("Omega", 53)
            };

            //так делали бы поиск игрока с макс уровнем 
            Player findPlayer = null;
            int max = players[0].Level;
            foreach (var player in players)
            {
                if(player.Level > max)
                {
                    max = player.Level;
                    findPlayer = player;
                }    
            }
            Console.WriteLine(findPlayer.NickName + " " + findPlayer.Level);

            //var findPlayer2 = players.Max(player => player);
            //Console.WriteLine(findPlayer2.NickName + " " + findPlayer2.Level);

            //поиск игроков с уровнем >=35
            Console.WriteLine("поиск игроков с уровнем >=35");
            var findPlayers = players.Where(player => player.Level >= 35).Select(player => player);
            foreach (var player in findPlayers)
            {
                Console.WriteLine(player.NickName + " " + player.Level);
            }

            //поиск игроков с первой буквой в нике 'A'
            Console.WriteLine("поиск игроков с первой буквой в нике 'A'");
            var findPlayers3 = players.Where(player => player.NickName.ToUpper().StartsWith('A'));
            foreach (var player in findPlayers3)
            {
                Console.WriteLine(player.NickName + " " + player.Level);
            }

            //отсортировать список по возрастанию уровней игроков 
            Console.WriteLine("отсортировать список по возрастанию уровней игроков ");
            var findPlayers4 = players.Where(player=>player.Level>10).OrderBy(player => player.Level); //OrderByDescending
            foreach (var player in findPlayers4)
            {
                Console.WriteLine(player.NickName + " " + player.Level);
            }
        }

        class Player
        {
            public string NickName { get; private set; }
            public int Level { get; private set; }

            public Player(string nickName, int level)
            {
                NickName = nickName;
                Level = level;
            }
        }


    }
}
