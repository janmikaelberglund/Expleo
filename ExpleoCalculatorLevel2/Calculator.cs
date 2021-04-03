using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpleoCalculatorLevel2
{
    class Calculator
    {
        public static double? Evaluate(string input)
        {
            char[] operators = { '+', '-', '*', '/' };
            string[] splitInput = input.Split(operators[0], operators[1]);

            if (splitInput.Length < 2)
            {
                splitInput = input.Split(operators[2], operators[3]);
            }

            List<double> inputNumbers = new();
            for (int i = 0; i < splitInput.Length; i++)
            {
                bool checkValues = double.TryParse(splitInput[i] = splitInput[i].Trim(), out double result);
                inputNumbers.Add(result);
                if (!checkValues)
                {
                    return null;
                }
            }

            List<char> charList = new();
            foreach (var character in input)
            {
                if (operators.Contains(character))
                {
                    charList.Add(character);
                }
            }

            for (int i = 0; i < charList.Count; i++)
            {
                switch (charList[i])
                {
                    case '+':
                        inputNumbers[i + 1] = Add(inputNumbers[i], inputNumbers[i + 1]);
                        break;
                    case '-':
                        inputNumbers[i + 1] = Subtract(inputNumbers[i], inputNumbers[i + 1]);
                        break;
                    case '*':
                        inputNumbers[i + 1] = Multiply(inputNumbers[i], inputNumbers[i + 1]);
                        break;
                    case '/':
                        inputNumbers[i + 1] = Divide(inputNumbers[i], inputNumbers[i + 1]);
                        break;
                    default:
                        return null;
                }
            }

            return inputNumbers[^1];
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
