using System;

namespace ExpleoCalculatorLevel2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter any set of numbers and operators to calculate the result, ex. 5+5-2");
                Console.WriteLine("Operators must be of same precedence (+ and -) or (* and /)");
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
