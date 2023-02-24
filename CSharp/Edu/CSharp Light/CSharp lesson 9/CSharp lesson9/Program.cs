using System;

namespace CSharp_lesson9
{
    //свойства с телом у get set, автореализуемое св-во без тела у get set
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(10, 20);

            //player.X = -10;

            Drawier drawier = new Drawier(player.X, player.Y);
        }
    }

    class Drawier
    {
        public Drawier(int x, int y, char symbol = '@')
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }


    //class Player
    //{
    //    private int _x;
    //    private int _y;

    //    public int X
    //    {
    //        get { return _x; }
    //        private set { _x = value; }
    //    }

    //    public int Y
    //    {
    //        get { return _y; }
    //        private set { _y = value; }
    //    }

    //    public Player(int x, int y)
    //    {
    //        _x = x;
    //        _y = y;
    //    }
    //}

    class Player
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
