/**
 * @file
 * Michael Landry	mic_23@hotmail.com
 * @version 1.0
 *
 * @section LICENSE
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License as
 * published by the Free Software Foundation; either version 2 of
 * the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful, but
 * WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
 * General Public License for more details at
 * https://www.gnu.org/copyleft/gpl.html
 *
 * @section DESCRIPTION
 *
 * This is a simple calculator programe. It will do +, -, /, *, exponential and factorial
 * it also check for input error
 *
 * The time class represents a moment of time.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    class Menu
    {
       public  Menu()
        {

        }

        // display the menu for the user to know the sysbole to use
        public void displayMenu()
        {
            Console.Clear();
            Console.WriteLine("***************Calculator***************\n");
            Console.WriteLine("Legend: A or a is +");
            Console.WriteLine("        S or s is -");
            Console.WriteLine("        M or m is *");
            Console.WriteLine("        D or d is /");
            Console.WriteLine("        !, E or e is Exponentiation");
            Console.WriteLine("        ^, F or f is Factorial\n");
            Console.WriteLine(" Please enter a number");
        }


    }
}
