using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter left operand");
            string input = Console.ReadLine();
            double d;
            if (!Double.TryParse(input, out d))
                Console.WriteLine("Wrong input");
            Console.WriteLine();

            Console.WriteLine("enter left operand");
        }
    }
}
