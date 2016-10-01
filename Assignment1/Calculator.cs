/**
@file    calculator.cs
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

namespace Assignment1
{
    public class Calculator
    {
        public string leftOperand = "";         // 
        public string rightOperand = "";        //
        public string operand = "";             // Variables used in the program
        public double lhs = 0;                  //
        public double rhs = 0;                  //
        public double result = 0;               //
        public bool isNumber = false;

        public void getOperands()             // asks user for input
        {
            do                                                      //
            {                                                       //
                Console.WriteLine("Input your left number: ");      //
                leftOperand = Console.ReadLine();                   // Prompts user for left number repeats if invalid
                isNumber = Double.TryParse(leftOperand, out lhs);   //
                                                                    //
                if (!isNumber)                                      //
                    Console.WriteLine("Error");                     //
            } while (!isNumber);


            do                                                                                                        //
            {                                                                                                         //
                Console.WriteLine("Input your operand: ");                                                            // asks user for middle operand
                operand = Console.ReadLine();                                                                         //
                                                                                                                      
                if (operand != "a" && operand != "A" && operand != "+" && operand != "d" && operand != "D" &&         // 
                    operand != "/" && operand != "M" && operand != "m" && operand != "*" && operand != "S" &&         //
                    operand != "s" && operand != "-" && operand != "^" && operand != "E" && operand != "e" &&         // if invalid print error
                    operand != "!" && operand != "f" && operand != "F")                                               //
                    Console.WriteLine("Error");                                                                       //
                                                                                                                      
            } while (operand != "a" && operand != "A" && operand != "+" && operand != "d" && operand != "D" &&        // repeat until valid
                     operand != "/" && operand != "M" && operand != "m" && operand != "*" && operand != "S" &&        //
                     operand != "s" && operand != "-" && operand != "^" && operand != "E" && operand != "e" &&        //
                     operand != "!" && operand != "f" && operand != "F");

            if (operand != "F" && operand != "f" && operand != "!")              // If middle operand is not factorial    
            {                                                                    //
                do                                                               //
                {                                                                //
                    Console.WriteLine("Input your right number: ");              // prompt user for right number 
                    rightOperand = Console.ReadLine();                           //
                    isNumber = Double.TryParse(rightOperand, out rhs);           //
                                                                                 //
                    if (!isNumber)                                               // if it's not a number print error
                        Console.WriteLine("Error");                              //
                                                                                 //
                } while (!isNumber);                                             // repeat until entry is a number 
            }                                                                    
        }

        public void doMath()            // calls the appropriate math function based on middle operand
        {
            switch (operand)
            {
                case "A":               //
                case "a":               //
                case "+":               //  addition
                    add();              //
                    break;              //
                                        
                case "S":               //
                case "s":               //
                case "-":               // subtraction
                    subtract();         //
                    break;              //
                                        
                case "D":               //
                case "d":               //
                case "/":               // divide
                    divide();           //
                    break;              //
                                        
                case "M":               //
                case "m":               //
                case "*":               // multiplication
                    multiply();         //
                    break;              //
                                        
                case "^":               //
                case "E":               //
                case "e":               // exponential
                    exponential();      //
                    break;              //
                                        
                case "!":               //
                case "f":               //
                case "F":               // factorial
                    factorial();        //
                    break;              //
                                        
                default:                // default case
                    break;              //
            }
            if (result > 1000000 || result < -1000000)          //  if result is greater then 1 million or -1 million print overflow
                Console.WriteLine("Overflow");                  //
            else                                                //
            {                                                   //  otherwise print out the answer
                Console.WriteLine("Answer is: " + result);      //
            }                                                   //


        }

        public void add()                              //  addition method
        {                                              //
            result = lhs + rhs;                        //
        }                                              //
        public void subtract()                         // subtraction method
        {                                              //
            result = lhs - rhs;                        //
        }                                              //
        public void multiply()                         // multiplication method
        {                                              //
            result = lhs * rhs;                        //
        }                                              //
        public void divide()                           // division method
        {                                              //
            if (rhs == 0)                              // if right number is 0 print Div0
            {                                          //
                Console.WriteLine("Div0");             //
            }                                          //
            else                                       // otherwise print result
                result = lhs / rhs;                    //
        }                                              //
        public void exponential()                      // exponential method
        {                                              //
            result = Math.Pow(lhs, rhs);               //
        }                                              //
                                                       //
        public void factorial()                        // factorial method
        {                                              //
            if (lhs < 0)                               // if left number is a negative number print out error
                Console.WriteLine("Error");            //
            else                                       // otherwise do factorial math in a for loop 
            {                                          //
                long factorial = (long)lhs;            // explicit conversion from double to long
                                                       //
                for (int i = 1; i < lhs; i++)          //
                    factorial = factorial * i;         //
                                                       //
                result = factorial;                    // implicit conversion from long to double
            }                                          //
        }                                              //
    }
}
