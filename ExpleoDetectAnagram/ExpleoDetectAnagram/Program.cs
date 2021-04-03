using System;
using static ExpleoDetectAnagramLibrary.ExpleoDetectAnagram;

namespace ExpleoDetectAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two inputs to be checked for an anagram:");
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            bool result = DetectAnagram(firstInput, secondInput);

            Console.WriteLine(result);
        }


    }
}
