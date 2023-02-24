using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digger
{
    public class Monster : ICreature
    {
        private bool CanMove(int x, int y)
        {
            return !(Game.Map[x, y] is Terrain) && !(Game.Map[x, y] is Sack) && !(Game.Map[x, y] is Monster);
        }

        public CreatureCommand Act(int x, int y)
        {
            var creatureCommand = new CreatureCommand();
            if (Player.IsAlive)
            {
                if (x == Player.X)
                {
                    creatureCommand.DeltaY = (y > Player.Y && CanMove(x, y - 1)) ? -1 :
                        ((y < Player.Y && CanMove(x, y + 1)) ? 1 : 0);
                }
                else if (y == Player.Y)
                {
                    creatureCommand.DeltaX = (x > Player.X && CanMove(x - 1, y)) ? -1 :
                        ((x < Player.X && CanMove(x + 1, y)) ? 1 : 0);
                }
            }

            if (x + creatureCommand.DeltaX < 0 || x + creatureCommand.DeltaX >= Game.MapWidth || y + creatureCommand.DeltaY < 0 ||
                   y + creatureCommand.DeltaY >= Game.MapHeight)
            {
                creatureCommand.DeltaX = 0;
                creatureCommand.DeltaY = 0;
            }

                return creatureCommand;
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            return conflictedObject is Monster || conflictedObject is Sack;
        }

        public int GetDrawingPriority()
        {
            return 3;
        }

        public string GetImageFileName()
        {
            return "Monster.png";
        }
    }
}
