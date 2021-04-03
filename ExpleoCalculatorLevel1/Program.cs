using System;
using System.Linq;

namespace ExpleoCalculatorLevel1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter two numbers and an operator to calculate the result, ex. 5+5:");
                string input = Console.ReadLine();

                double? result = Calculator.Evaluate(input);

                if (result != null)
                {
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("You have entered an invalid input");
                }
            }
        }
    }
}
