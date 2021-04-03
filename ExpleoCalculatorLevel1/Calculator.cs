using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpleoCalculatorLevel1
{
    class Calculator
    {
        public static double? Evaluate(string input)
        {
            char[] operators = { '+', '-', '*', '/' };
            string[] splitInput = input.Split(operators);

            if (splitInput.Length < 2)
            {
                return null;
            }

            _ = double.TryParse(splitInput[0].Trim(), out double firstNumber);
            _ = double.TryParse(splitInput[1].Trim(), out double secondNumber);

            var inputOperator = input.FirstOrDefault(x => x == operators[0] || x == operators[1] || x == operators[2] || x == operators[3]);

            return inputOperator switch
            {
                '+' => Add(firstNumber, secondNumber),
                '-' => Subtract(firstNumber, secondNumber),
                '*' => Multiply(firstNumber, secondNumber),
                '/' => Divide(firstNumber, secondNumber),
                _ => null,
            };
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static double Subtract(double x, double y)
        {
            return x - y;
        }
        public static double Multiply(double x, double y)
        {
            return x * y;
        }
        public static double Divide(double x, double y)
        {
            return x / y;
        }
    }
}
