using System;

namespace OOP_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Fighter[] fighters = {
                new Fighter("Джон", 120,10, 2),
                new Fighter("Марк", 150,11, 4),
                new Fighter("Антонио", 100,5, 15),
                new Fighter("Брэд", 300, 3, 20)
                };

                for (int i = 0; i < fighters.Length; i++)
                {
                    Console.Write(i + 1 + " ");
                    fighters[i].ShowInfo();
                }

                Console.WriteLine("Введите номер первого война");
                int firstNumber = Convert.ToInt32(Console.ReadLine()) - 1;
                Fighter firstFighter = fighters[firstNumber];

                Console.WriteLine("Введите номер второго война");
                int secondNumber = Convert.ToInt32(Console.ReadLine()) - 1;
                Fighter secondFighter = fighters[secondNumber];

                while (firstFighter.Health > 0 && secondFighter.Health > 0)
                {
                    firstFighter.TakeDamage(secondFighter.Damage);
                    secondFighter.TakeDamage(firstFighter.Damage);
                }

                firstFighter.ShowInfo();
                secondFighter.ShowInfo();

                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    class Fighter
    {
        private string _name;
        private int _health;
        private int _damage;
        private int _armor;

        public int Health { get { return _health; } private set { _health = value; } }
        public int Damage { get { return _damage; } private set { _damage = value; } }

        public Fighter(string name, int health, int damage, int armor)
        {
            _name = name;
            _health = health;
            _damage = damage;
            _armor = armor;
        }

        public void TakeDamage(int damage)
        {
            _health -= damage;
        }

        public void ShowInfo()
        {
            Console.WriteLine($" Имя {_name} Здоровье {_health} Урон {_damage} Броня {_armor}");
        }
    }

}
