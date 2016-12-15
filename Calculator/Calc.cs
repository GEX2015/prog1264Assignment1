/////////////////////////////////////////////////////////////////////
// File:  Calc.cs
//
// Author: Ricky Bastarache 
// This assignment represents my own work and is in accordance with the College Academic Policy
//
// Copyright (c) 2016 All Right Reserved by Dave Burchill
// Contributors: 
// Description:  
//
// Date: Sept 2016
//
// Revisions:
//
/////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calc
    {

        private double _lhs;
        private double _rhs;
        private double _results;
        private char _operators;
        private bool isContinue = true;

        public Calc()
        { }


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
                    Division();
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


        public void addition()
        {
            _results = _lhs + _rhs;
            if (_results > 1000000 || _results < -1000000)
                OverFlow();
            else
                displayResults();
        }


        public void subtraction()
        {
            _results = _lhs - _rhs;
            if (_results > 1000000 || _results < -1000000)
                OverFlow();
            else
                displayResults();
        }


        public void multiplication()
        {
            _results = _lhs * _rhs;
            if (_results > 1000000 || _results < -1000000)
                OverFlow();
            else
                displayResults();
        }


        public void Division()
        {
            if (_rhs == 0)
                divByZero();
            else if (_results > 1000000 || _results < -1000000)
                OverFlow();
            else
            {
                _results = _lhs / _rhs;
                displayResults();
            }

        }

        public void factorial()
        {
            if (_lhs < 0)
                Error();
            else
            {

                for (int i = 1; i < _lhs; i++)
                    _results = (_results * i);

                if (_results > 1000000 || _results < -1000000)
                    OverFlow();
                else
                    displayResults();
            }

        }

        public void exponentiation()
        {
            _results = Math.Pow(_lhs, _rhs);
            if (_results > 1000000 || _results < -1000000)
                OverFlow();
            else
                displayResults();
        }

        public void quit()
        {
            Environment.Exit(0);
        }

        public void Run()
        {

            while (isContinue)
            {
                Console.Clear();
                
                isLhsNumeric();
                isChar();
                if (_operators.Equals('f') || _operators.Equals('F') || _operators.Equals('^'))
                { /*do nothing*/}
                else
                {
                    isRhsNumeric();
                    calculation(_operators);
                }

            }
            Environment.Exit(0);
        }

        public void isLhsNumeric()
        {
            bool isNumeric = false;
            while (!isNumeric)
            {
                Console.WriteLine("Enter a Number");
                string lhs = Console.ReadLine();
                isNumeric = double.TryParse(lhs, out _lhs);
                if (!isNumeric)
                    Error();
                else
                    isNumeric = true;
            }
        }

        public void isRhsNumeric()
        {
            bool isNumeric = false;
            while (!isNumeric)
            {
                Console.WriteLine("Enter a Number");
                string rhs = Console.ReadLine();
                isNumeric = double.TryParse(rhs, out _rhs);
                if (!isNumeric)
                    Error();
                else
                    isNumeric = true;
            }
        }

        public void isChar()
        {
            bool isGoodChar = false;

            while (!isGoodChar)
            {
                Console.WriteLine("Enter an operator");
                string operators = Console.ReadLine();
                bool isChar = char.TryParse(operators.ToLower(), out _operators);
                if (_operators.Equals('f') || _operators.Equals('^'))
                    factorial();

                if (_operators.Equals('a') || _operators.Equals('A') || _operators.Equals('s') || _operators.Equals('S') ||
                   _operators.Equals('m') || _operators.Equals('M') || _operators.Equals('d') || _operators.Equals('D') ||
                   _operators.Equals('e') || _operators.Equals('E') || _operators.Equals('!') ||
                   _operators.Equals('f') || _operators.Equals('F') || _operators.Equals('^'))
                    isGoodChar = true;
                else
                    Error();

                if (_operators.Equals('q') || _operators.Equals('Q'))
                {
                    calculation(_operators);
                    isGoodChar = true;
                }


            }
        }

        public void OverFlow()
        {
            Console.WriteLine("Over flow");
            Console.ReadKey();
        }

        public void displayResults()
        {
            Console.WriteLine("Result is: " + _results);
            Console.ReadKey();
        }

        public void divByZero()
        {
            Console.WriteLine("Div0");
            Console.ReadKey();
        }

        public void Error()
        {
            Console.WriteLine("Error");
            Console.ReadKey();
        }
    }


}

