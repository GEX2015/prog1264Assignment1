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

    class Calculator
    {
        // private member use in the calculator class
        public const int MILLION = 1000000;
        private double _lhs;
        private double _rhs;
        private double _result;
        private long _longResult;
        private char _operators;
        private bool userContinue = true;

        // constructor with no parameter
        public Calculator()
        { }

        // switch to redirec, according to the operator, to the good function to do the calculation 
        public void calculation(char operators)
        {
            switch (operators)
            {
                case 'a':
                    addition();
                    break;
                case 's':
                    subtraction();
                    break;
                case 'm':
                    multiplication();
                    break;
                case 'd':
                    division();
                    break;
                case '!':
                case 'e':
                    exponentiation();
                    break;
                case '^':
                case 'f':
                    factorial();
                    break;
                case 'q':
                    quit();
                    break;
                default:
                    break;
            };
        }

        // Do the addition and check if the resuls is over 1,000,000 or less that -1,000,000
        // and call overflow or displayResult depend of the result
        public void addition()
        {
            _result = _lhs + _rhs;
            if (_result > MILLION || _result < -MILLION)
                overflow();
            else
                displayResult();
        }

        // Do the subtraction and check if the resuls is over 1,000,000 or less that -1,000,000
        // and call overflow or displayResult depend of the result
        public void subtraction()
        {
            _result = _lhs - _rhs;
            if (_result > MILLION || _result < -MILLION)
                overflow();
            else
                displayResult();
        }

        // Do the multiplication and check if the resuls is over 1,000,000 or less that -1,000,000
        // and call overflow or displayResult depend of the result
        public void multiplication()
        {
            _result = _lhs * _rhs;
            if (_result > MILLION || _result < -MILLION)
                overflow();
            else
                displayResult();
        }

        // Do the division and check if the resuls is over 1,000,000 or less that -1,000,000
        // and call overflow or displayResult depend of the result
        public void division()
        {
            if (_rhs == 0)
            {
                div0();
            }
            else if (_result > MILLION || _result < -MILLION)
                overflow();
            else
            {
                _result = _lhs / _rhs;
                displayResult();
            }

        }

        // Do the factorial and check if the user enter a negatif value. if yes
        // message a error. check if the resuls is over 1,000,000 or less that -1,000,000
        // and call overflow or displayResult depend of the result
        public void factorial()
        {
            if (_lhs < 0)
                error();
            else
            {
                _longResult = Convert.ToInt64(_lhs);

                for (int i = 1; i < _lhs; i++)
                {
                    _longResult = (_longResult * i);
                }
                _result = _longResult;
                if (_result > MILLION || _result < -MILLION)
                    overflow();
                else
                    displayResult();
            }

        }
        // Do the exponentiation and check if the resuls is over 1,000,000 or less that -1,000,000
        // and call overflow or displayResult depend of the result
        public void exponentiation()
        {
            _result = Math.Pow(_lhs, _rhs);
            if (_result > 1000000 || _result < -1000000)
                overflow();
            else
                displayResult();
        }

        // if the user press q or Q the programe exit
        public void quit()
        {
            Environment.Exit(0);
        }

        // the calculation loop 
        public void calculatorRun()
        {
            Menu menu = new Menu();

            while (userContinue)
            {
                Console.Clear();
                // display the menu
                menu.displayMenu();
                // check if the user enter a numeric 
                isLhsNumeric();
                // check if the user enter a char for the operator
                isChar();
                // if the operator is f or ^ do nothing
                if (_operators.Equals('f') || _operators.Equals('^'))
                { }
                // else ask for the rhs and do the calculation
                else
                {
                    isRhsNumeric();
                    calculation(_operators);
                }

            }
            Environment.Exit(0);
        }

        // check if the lhs number is numeric if yes assigne to _lhs
        public void isLhsNumeric()
        {
            bool isNumeric = false;
            while (!isNumeric)
            {
                Console.WriteLine("Enter a Number");
                string lhs = Console.ReadLine();
                // check if the user enter a interger if yes place it to _lhs
                isNumeric = double.TryParse(lhs, out _lhs);
                // if is not a numeric print a error message
                if (!isNumeric)
                {
                    error();
                }
                else
                    isNumeric = true;
            }
        }

        // check if the rhs number is numeric if yes assigne to _rhs
        public void isRhsNumeric()
        {
            bool isNumeric = false;
            while (!isNumeric)
            {
                Console.WriteLine("Enter a Number");
                string rhs = Console.ReadLine();
                // check if the user enter a interger if yes place it to _rhs
                isNumeric = double.TryParse(rhs, out _rhs);
                // if is not a numeric print a error message
                if (!isNumeric)
                {
                    error();
                }
                else
                    isNumeric = true;
            }
        }

        // check if the operator is a char and if is a good operator and assigne to _operator
        public void isChar()
        {
            bool goodChar = false;

            while (!goodChar)
            {
                Console.WriteLine("Enter operator");
                string operators = Console.ReadLine();
                // put the operator to lower and check if the operator is a char if yes put it to _operators
                bool isChar = char.TryParse(operators.ToLower(), out _operators);
                // if the operator is f or ^ redirect to factorial 
                // because factorial don't need rhs
                if (_operators.Equals('f') || _operators.Equals('^'))
                {
                    factorial();
                }
                // check if the operator is one of the good chose
                if (_operators.Equals('a') || _operators.Equals('s') ||
                   _operators.Equals('m') || _operators.Equals('d') ||
                   _operators.Equals('e') || _operators.Equals('!') ||
                   _operators.Equals('f') || _operators.Equals('^'))
                    goodChar = true;
                // if the opperator is not a good operator print a error message
                else
                {
                    error();
                }
                // if the operator is q sent to calculation to go to the exit function
                if (_operators.Equals('q'))
                {
                    calculation(_operators);
                    goodChar = true;
                }


            }
        }
        // if the result is over 1,000,000 or -1,000,000 display this message
        public void overflow()
        {
            Console.WriteLine("Overflow");
            Console.ReadKey();
        }
        // display the result of the operation
        public void displayResult()
        {
            Console.WriteLine("The result is: " + _result);
            Console.ReadKey();
        }
        // if the division is divide by 0 display this message
        public void div0()
        {
            Console.WriteLine("Div0");
            Console.ReadKey();
        }
        // if user try to enter a wrong value to number or operator display this mesage
        public void error()
        {
            Console.WriteLine("Error");
            Console.ReadKey();
        }
    }


}

