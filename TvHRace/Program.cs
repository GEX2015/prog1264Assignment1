using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvHRace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Racer t = new Tortoise();
            Racer h = new Hare();
            while (true)
            {
                h.initialize();
                t.initialize();
                while (t.Position < 100 && h.Position < 100)
                {

                    t.move();
                    h.move();


                    Console.Clear();
                    string tmp = new string(' ', 30);
                    Console.WriteLine(tmp + "******* The Race *******");

                    t.draw();
                    h.draw();

                    System.Threading.Thread.Sleep(100);

                }
                Console.ReadKey();
            }
        }
    }
}
