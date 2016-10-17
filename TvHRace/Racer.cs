using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvHRace
{
    abstract class Racer
    {
       
        public Racer() {}
        public void initialize() { Position = 0; }
        public abstract void move();
        public virtual void draw() {
            for (int i = 0; i < Position; i++)
                Console.Write("*");
        }

        private int _position = 0;
        public int Position { get; protected set; }
    }
}
