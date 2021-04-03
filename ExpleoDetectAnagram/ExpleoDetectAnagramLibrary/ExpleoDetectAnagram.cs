using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExpleoDetectAnagramLibrary
{
    public class ExpleoDetectAnagram
    {
        public static bool DetectAnagram(string firstInput, string secondInput)
        {
            string firstInputModified = firstInput.ToLower();
            string secondInputModified = secondInput.ToLower();

            if (firstInputModified == secondInputModified)
                return false;

            firstInputModified = new string(firstInputModified
                .Where(x => !Char.IsWhiteSpace(x))
                .OrderBy(x => x)
                .ToArray());

            secondInputModified = new string(secondInputModified
                .Where(x => !Char.IsWhiteSpace(x))
                .OrderBy(x => x)
                .ToArray());

            if (secondInputModified == firstInputModified)
            {
                return true;
            }

            return false;
        }
    }
}
