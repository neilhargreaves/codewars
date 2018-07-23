using System;
using System.Linq;

namespace CodeWars
{
    public class IQ
    {
        public static int Test(string numbers)
        {
            var numbersArray = numbers.Split(null);
            var oddNumbers = numbersArray.Where(x =>
            {
                var isNumeric = int.TryParse(x, out var number);
                return number % 2 != 0;
            });

            var evenNumbers = numbersArray.Where(x =>
            {
                var isNumeric = int.TryParse(x, out var number);
                return number % 2 == 0;
            });

            if (oddNumbers.Count() > evenNumbers.Count())
            {
                var firstEvenNumber = evenNumbers.FirstOrDefault().ToString();
                return Array.IndexOf(numbersArray, firstEvenNumber) + 1;
            }

            var firstOddNumber = oddNumbers.FirstOrDefault().ToString();

            return Array.IndexOf(numbersArray, firstOddNumber) + 1;
        }
    }
}
