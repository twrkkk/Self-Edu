using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digger
{
    public class Sack : ICreature
    {
        private int _flyHeight;
        public CreatureCommand Act(int x, int y)
        {
            CreatureCommand creatureCommand = new CreatureCommand { DeltaX = 0, DeltaY = 0 };
            if (y + 1 < Game.MapHeight)
            {
                if (_flyHeight > 0 && (Game.Map[x, y + 1] is Player || Game.Map[x, y + 1] is Monster) || Game.Map[x, y + 1] == null)
                {
                    _flyHeight++;
                    creatureCommand.DeltaY = 1;
                }
            }
            else if (_flyHeight >= 1)
            {
                _flyHeight = 0;
                creatureCommand.TransformTo = new Gold();
            }

            return creatureCommand;
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            return false;
        }

        public int GetDrawingPriority()
        {
            return 3;
        }

        public string GetImageFileName()
        {
            return "Sack.png";
        }
    }
}
