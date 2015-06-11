﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace The_Quest
{
    public class Sword: Weapon
    {

        public Sword(Game game, Point location)
            : base(game, location)
        {

        }

        public override string Name {get { return "Sword"; }}

        public override void Attack(Direction direction, Random random)
        {
            if (direction == Direction.Up)
            {
                if (DamageEnemy(direction, 10, 3, random) == false)
                {
                    if (DamageEnemy(Direction.Right, 10, 3, random) == false)
                    {
                        DamageEnemy(Direction.Left, 10, 3, random);
                    }
                }
            }
            if (direction == Direction.Right)
            {
                if (DamageEnemy(direction, 10, 3, random) == false)
                {
                    if (DamageEnemy(Direction.Down, 10, 3, random) == false)
                    {
                        DamageEnemy(Direction.Up, 10, 3, random);
                    }
                }
            }
            if (direction == Direction.Down)
            {
                if (DamageEnemy(direction, 10, 3, random) == false)
                {
                    if (DamageEnemy(Direction.Left, 10, 3, random) == false)
                    {
                        DamageEnemy(Direction.Right, 10, 3, random);
                    }
                }
            }
            if (direction == Direction.Left)
            {
                if (DamageEnemy(direction, 10, 3, random) == false)
                {
                    if (DamageEnemy(Direction.Up, 10, 3, random) == false)
                    {
                        DamageEnemy(Direction.Down, 10, 3, random);
                    }
                }
            }
        }
    }
}
