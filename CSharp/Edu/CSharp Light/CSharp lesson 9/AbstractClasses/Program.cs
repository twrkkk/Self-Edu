using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Car(220);
            vehicle.Move();
            vehicle.ShowInfo();
        }
    }

    abstract class Vehicle
    {
        protected int MaxSpeed;
        public abstract void Move();
        public void ShowInfo()
        {
            Console.WriteLine(MaxSpeed);
        }
    }

    class Car : Vehicle 
    {
        public override void Move()
        {
            Console.WriteLine("Еду");
        }
        public Car(int maxSpeed)
        {
            MaxSpeed = maxSpeed;
        }
    }


}
