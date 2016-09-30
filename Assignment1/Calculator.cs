using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Calculator
    {
        public string leftOperand = "";
        public string rightOperand = "";
        public string operand = "";
        public double lhs = 0;
        public double rhs = 0;

        public void getOperands()
        {
            bool isNumber = false;
            do
            {
                Console.WriteLine("Input your left number: ");              // Add validation
                leftOperand = Console.ReadLine();
                isNumber = Double.TryParse(leftOperand, out lhs);
            } while (!isNumber);


            Console.WriteLine("Input your operand: ");                  // add validation
            operand = Console.ReadLine();

            if (operand != "F" && operand != "f" && operand != "!")
            {
                Console.WriteLine("Input your right number: ");         // add validation
                rightOperand = Console.ReadLine();
                isNumber = Double.TryParse(rightOperand, out rhs);
            }

        }



        public double add()
        {
            return lhs + rhs;
        }
        public double subtract()
        {
            return lhs - rhs;
        }
        public double multiply()
        {
            return lhs * rhs;
        }
        public double divide()
        {
            return lhs / rhs;
        }

    }
}
