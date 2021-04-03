using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpleoCalculatorLevel3
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

            while (charList.Count > 0)
            {
                for (int i = 0; i < charList.Count; i++)
                {
                    if (charList[i] == '*' || charList[i] == '/')
                    {
                        switch (charList[i])
                        {
                            case '*':
                                inputNumbers[i + 1] = Multiply(inputNumbers[i], inputNumbers[i + 1]);
                                inputNumbers.RemoveAt(i);
                                charList.RemoveAt(i);
                                break;
                            case '/':
                                inputNumbers[i + 1] = Divide(inputNumbers[i], inputNumbers[i + 1]);
                                inputNumbers.RemoveAt(i);
                                charList.RemoveAt(i);
                                break;
                            default:
                                break;
                        }
                    }
                }
                for (int i = 0; i < charList.Count; i++)
                {
                    if (charList[i] == '+' || charList[i] == '-')
                    {
                        switch (charList[i])
                        {
                            case '+':
                                inputNumbers[i + 1] = Add(inputNumbers[i], inputNumbers[i + 1]);
                                inputNumbers.RemoveAt(i);
                                charList.RemoveAt(i);
                                break;
                            case '-':
                                inputNumbers[i + 1] = Subtract(inputNumbers[i], inputNumbers[i + 1]);
                                inputNumbers.RemoveAt(i);
                                charList.RemoveAt(i);
                                break;
                            default:
                                break;
                        }
                    }
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

