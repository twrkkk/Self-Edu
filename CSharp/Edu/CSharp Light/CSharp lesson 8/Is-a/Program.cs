using System;

namespace Is_a
{
    //наследование
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(100, 5, 2, 3);
            Barbarian barbarian = new Barbarian(135, 6, 4);

            while (player.Health > 0 && barbarian.Health > 0)
            {
                player.TakeDamage(barbarian, player.Damage);
                barbarian.TakeDamage(player, barbarian.Damage);
            }

            Console.WriteLine($"Здоровье игрока: {player.Health} здоровье противника: {barbarian.Health}");
        }

        class Warrior
        {
            public int Health;
            public int Damage;
            public int Armor;

            public Warrior(int health, int damage, int armor)
            {
                Health = health;
                Damage = damage;
                Armor = armor;
            }

            public void TakeDamage(Warrior opponent, int value)
            {
                opponent.Health -= value;
            }
        }

        class Player : Warrior
        {
            private int _damageSpeed;
            public Player(int health, int damage, int armor, int damageSpeed) : base(health, damage, armor)
            {
                _damageSpeed = damageSpeed;
            }
        }

        class Barbarian : Warrior
        {
            public Barbarian(int health, int damage, int armor) : base(health, damage, armor) { }
        }
    }
}
