using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace The_Quest
{
    public class Ghost: Enemy
    {
        public Ghost(Game game, Point location) : base(game, location, 8) { }

        public override void Move(Random random){
            if (HitPoints > 0)
            {
                if (random.Next(0, 5) != 1)
                    location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                if (NearPlayer())
                    game.HitPlayer(3, random);
            }
        }
    }
}