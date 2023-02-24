using System;

namespace Has_a
{
    //композиция классов
    class Program
    {
        static void Main(string[] args)
        {
            Task[] tasks = { new Task("Иван", "Выкопать яму"), new Task("Пётр", "Почистить картошку"), new Task("Семён", "починить танк") };
            Board board = new Board(tasks);
            board.ShowAll();
        }

        class Performer
        {
            public string name;
        }

        class Task
        {
            public Performer performer;
            public string Description;

            public Task(string name, string description)
            {
                performer = new Performer();
                performer.name = name;
                Description = description;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Исполнитель: {performer.name} Описание: {Description}");
            }

        }

        class Board
        {
            public Board(Task[] tasks)
            {
                this.tasks = tasks;
            }
            Task[] tasks;
            public void ShowAll()
            {
                foreach (var task in tasks)
                {
                    task.ShowInfo();
                }
            }
        }

    }
}
