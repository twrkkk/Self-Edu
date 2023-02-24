using System;

namespace Virtual_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            NonPlayerCracter[] characters = { 
                new NonPlayerCracter(),
                new Farmer(),
                new Knight()
            };

            foreach (var character  in characters)
            {
                character.DoSomething();
                Console.WriteLine(new string('-', 30));
            }
        }
    }

    class NonPlayerCracter
    {
        public virtual void DoSomething()
        {
            Console.WriteLine("Я NPC и я умею ходить");
        }
    }

    class Farmer : NonPlayerCracter
    {
        public override void DoSomething()
        {
            base.DoSomething();
            Console.WriteLine("А еще я умею выращивать овощи");
        }
    }

    class Knight:NonPlayerCracter
    {
        public override void DoSomething()
        {
            Console.WriteLine("Я могу защищать земли от врагов");
        }
    }


}
