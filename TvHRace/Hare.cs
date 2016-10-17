using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvHRace
{
    class Hare : Racer
    {

        public override void move()
        {
            Random rnd = new Random();
            int roll = rnd.Next(1, 11);
            if (roll <= 2)
                Position += 0;
            else if (roll > 2 && roll <= 4)
                Position += 9;
            else if (roll ==5)
                Position -= 12;
            else if (roll > 5 && roll <= 8)
                Position++;
            else
                Position-=2;

        }
        public override void draw() { Console.Write("Hare: "); base.draw(); }

    }
}

