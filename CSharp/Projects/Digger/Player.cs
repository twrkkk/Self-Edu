using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digger
{
    public class Player : ICreature
    {
        public static int X { get; private set; }
        public static int Y { get; private set; }
        public static bool IsAlive { get; private set; } = false;
        public void OutMovingDelta(out int deltaX, out int deltaY)
        {
            IsAlive = true;
            deltaX = 0;
            deltaY = 0;
            switch (Game.KeyPressed)
            {
                case System.Windows.Forms.Keys.Left:
                    deltaX = -1;
                    break;
                case System.Windows.Forms.Keys.Up:
                    deltaY = -1;
                    break;
                case System.Windows.Forms.Keys.Right:
                    deltaX = 1;
                    break;
                case System.Windows.Forms.Keys.Down:
                    deltaY = 1;
                    break;
                default:
                    break;
            }
        }

        public CreatureCommand Act(int x, int y)
        {
            int deltaX, deltaY;
            OutMovingDelta(out deltaX, out deltaY);
            var creatureCommand = new CreatureCommand();

            bool isExit = false;
            if (x + deltaX < 0 || x + deltaX >= Game.MapWidth || y + deltaY < 0 || y + deltaY >= Game.MapHeight)
                isExit = true;

            creatureCommand.DeltaX = isExit || Game.Map[x + deltaX, y + deltaY] is Sack ? 0 : deltaX;
            creatureCommand.DeltaY = isExit || Game.Map[x + deltaX, y + deltaY] is Sack ? 0 : deltaY;
            creatureCommand.TransformTo = isExit ? null : Game.Map[x, y];

            X = x + creatureCommand.DeltaX;
            Y = y + creatureCommand.DeltaY;

            Game.Map[x, y] = null;

            return creatureCommand;
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            IsAlive = !(conflictedObject is Monster);
            return conflictedObject is Sack || !IsAlive;
        }

        public int GetDrawingPriority()
        {
            return 2;
        }

        public string GetImageFileName()
        {
            return "Digger.png";
        }
    }
}
