/**
@file calculator.cs
@author  Chris Arsenault Chris.arsenault06@gmail.com
@version 1.0


@section DESCRIPTION

calculator program that pulls the left hand and right hand operands and also gets the operator from the user then calculates it and sends it back to the user

*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorAssigment
{
    class Calculator
    {
        //variables
        private double _lhs = 0;
        private double _rhs = 0;
        private string _operand;
        private double _total = 0;


        public void getCalculation()
        {


            //checks if the user sent a input that can be converted into a double.
            //if it cant it keeps it as the default initialisation(0)
            Console.Write("Enter left hand number: ");
            Double.TryParse((Console.ReadLine()), out _lhs);



            //the error checking for the operator is in the calculate method
            Console.Write("Enter the operator: ");
            _operand = (Console.ReadLine());

            //if they input factorial it ignores the right hand operand
            if (_operand != "!" && _operand != "f" && _operand != "F")
            {

                //checks if the user sent a input that can be converted into a double.
                //if it cant it keeps it as the default initialisation(0)
                Console.Write("Enter right hand number: ");
                Double.TryParse((Console.ReadLine()), out _rhs);

            }



        }

        public double Calculate()
        {
            _total = 0; //resets the total incase they do multiple calculations in a single session

            switch (_operand)
            {
                //addition
                case "A":
                case "a":
                case "+":
                    _total = _lhs + _rhs;
                    break;
                //subtraction
                case "S":
                case "s":
                case "-":
                    _total = _lhs - _rhs;
                    break;
                //Multiplication
                case "M":
                case "m":
                case "*":
                    _total = _lhs * _rhs;
                    if (_total > 1000000 || _total < -1000000) //so it wont become to big or small
                    {
                        Console.WriteLine("overflow");
                        _total = 0;
                    }
                    break;
                //division
                case "D":
                case "d":
                case "/":
                    if (_rhs != 0) //to avoid division by zero
                        _total = _lhs / _rhs;
                    else
                        Console.WriteLine("div0");
                    break;
                //exponent
                case "E":
                case "e":
                case "^":
                    _total = Math.Pow(_lhs, _rhs);
                    break;
                //Factorial
                case "F":
                case "f":
                case "!":
                    if (_lhs < 0) //makes sure they don't try to factorial a negative number
                    {
                        Console.WriteLine("ERROR");
                        break;
                    }


                    _lhs = Convert.ToInt64(_lhs);// converts into a Long

                    for (var i = _lhs; i != 0; i--)
                        _total += _lhs * i;

                    _total = Convert.ToDouble(_total);
                    break;


                //if the user didnt send in a proper operator
                default:
                    Console.WriteLine("error");
                    _total = 0;
                    break;

            }


            return _total;
        }
    }
}
