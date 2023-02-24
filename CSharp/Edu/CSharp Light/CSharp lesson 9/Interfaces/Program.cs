using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            while (true)
            {
                human.Move();
                System.Threading.Thread.Sleep(1000);
                human.Jump();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }

    interface IMovable
    {
        void Move();
    }

    interface IJumpable
    {
        void Jump();
    }


    class Human : IMovable, IJumpable
    {
        public void Move()
        {
            Console.WriteLine("Иду");
        }

        public void Jump()
        {
            Console.WriteLine("Прыгаю");
        }
    }


}
