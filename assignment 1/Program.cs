using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double lhs;
            double rhs;
            long longLhs = 0;
            double result = 0;
            String userOperator;
            Boolean userContinue = true;

            while (userContinue)
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
                lhs = Convert.ToDouble(Console.ReadLine());


                

                Console.WriteLine("Enter the operator");
                userOperator = Console.ReadLine();
                userOperator = userOperator.ToLower();

                if (userOperator == "^" || userOperator == "f")
                {
                    longLhs = Convert.ToInt64(lhs);
                    // do the factorial
                    for(int i = 1; i  < lhs; i++)
                    {
                        longLhs = ( longLhs* i);
                    }
                    Console.WriteLine(longLhs);

                }
                
                else
                {
                    Console.WriteLine("Enter the other number");
                    rhs = Convert.ToDouble(Console.ReadLine());

                    switch (userOperator)
                    {
                        case "a":
                            result = lhs + rhs;
                            break;
                        case "s":
                            result = lhs - rhs;
                            break;
                        case "m":
                            result = lhs * rhs;
                            break;
                        case "d":
                            result = lhs / rhs;
                            break;
                        case "!":
                        case "e":
                            result = Math.Pow(lhs, rhs);
                            break;
                        case "q":
                            userContinue = false;
                            break;
                        default:
                            break;

                    }

                    Console.WriteLine("The resule is " + result);

                }
                Console.ReadKey();
            }
        }
    }
}
