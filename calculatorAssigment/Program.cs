/**
@file Program.cs
@author  Chris Arsenault Chris.arsenault06@gmail.com
@version 1.0


@section DESCRIPTION

main file that calls the calulator.cs methods and checks if the user want to continue or not


*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string end = "";
            Calculator calc = new Calculator();
            while (end != "Q" && end != "q")
            {
                calc.getCalculation();
                Console.WriteLine(calc.Calculate());
                Console.WriteLine(@"Do you want to Quit? 'q' or 'Q' to quit"); //checks for the exit case
                end = Console.ReadLine();
            }
            
        }
    }
}
