﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace The_Quest
{
    class Bat: Enemy
    {
        public Bat(Game game, Point location) : base(game, location, 6) { }

        public override void Move(Random random){
           
            if (HitPoints > 0)
            {
                if (random.Next(0, 2) == 1)
                {
                    location = Move((Direction)random.Next(0, 4), game.Boundaries);
                }
                else
                {
                    location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);

                }
                if (NearPlayer())
                    game.HitPlayer(2, random);
            }

        }
    }
}
