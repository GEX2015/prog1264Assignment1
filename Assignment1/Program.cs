/**
@file    program.cs
@author  Robert Carll Robert-a-c@live.com
@version 1.0

Additions and modifications are my sole work for prog 1266

@section DESCRIPTION

<your description of the purpose of this file here>

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Assignment1
{
    public class Program
    {
        static void Main(string[] args)
        {

            Calculator calc = new Calculator(); // creates calculator
            string quit = "";                   // string to test for quit

            do            
            {
                Console.Clear();                //clears screen for easier reading
                calc.getOperands();             //gets input from the user  
                calc.doMath();                  //calls the functions that do the calculations based on user input

                Console.WriteLine("Press Q to quit or any key to continue.");   // prompts user to continue or quit
                quit = Console.ReadLine();                                      //

            } while (quit != "q" && quit != "Q");   //loop continues until user hits q when prompted
        }
    }
}
