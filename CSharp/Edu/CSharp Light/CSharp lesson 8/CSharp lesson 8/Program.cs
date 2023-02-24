using System;

namespace CSharp_lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Car ferrari = new Car("F40", 18, 417, 321);
            Car lamborghini = new Car("Huracane", 14, 420, 320);

            ferrari.ShowInfo();
            lamborghini.ShowInfo();

            ferrari = lamborghini;
            ferrari.MaxSpeed = 500;

            ferrari.ShowInfo();
            lamborghini.ShowInfo();
        }

        class Car
        {
            public string Model;
            public int Age;
            public int HorsePower;
            public float MaxSpeed;

            public Car() { }
            public Car(string model, int age, int horsePower, float maxSpeed)
            {
                Model = model; 
                Age = age;
                HorsePower = horsePower;
                MaxSpeed = maxSpeed;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Модель: {Model}\nВозраст: {Age}\nМощность:{HorsePower}\n" +
                                  $"Максимальная скорость:{MaxSpeed}\n");
            }
        }


    }
}
