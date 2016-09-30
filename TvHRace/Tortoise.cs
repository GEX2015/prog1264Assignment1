using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvHRace
{
    class Tortoise : Racer
    {

        public override void move() {
            Random rnd = new Random();
            int roll = rnd.Next(1, 11);
            if (roll <= 5)
                Position += 3;
            else if (roll > 5 && roll <= 7)
                Position -= 6;
            else
                Position++;

        }
        public override void draw() { Console.Write("Tortoise: "); base.draw(); Console.WriteLine(); }
       
    }
}
