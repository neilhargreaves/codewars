using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class NumberTriangle
    {
        public static long rowSumNumbers(long n, string numbersToCalculate = "Odd")
        {
            var pins = CalculatePins(n);

            List<long> numbers;

            switch (numbersToCalculate)
            {
                case "Odd":
                    numbers = OddNumbers(pins, n);
                    break;
                case "Even":
                    numbers = EvenNumbers(pins, n);
                    break;
                default:
                    numbers = AllNumbers(pins, n);
                    break;
            }

            return numbers.Aggregate((x, y) => x + y);
        }

        private static long CalculatePins(long n)
        {
            var r = n + 1;
            var rn = n * r;
            return rn / 2;
        }

        private static List<long> AllNumbers(long length, long row)
        {
            var number = 0;
            var numbers = new List<long>();

            while (numbers.Count < length)
            {
                number++;
                numbers.Add(number);
            }

            return Enumerable.Reverse(numbers).Take((int)row).ToList();
        }

        private static List<long> OddNumbers(long length, long row)
        {
            var number = 0;
            var numbers = new List<long>();

            while (numbers.Count < length)
            {
                number++;

                if (number % 2 != 0)
                    numbers.Add(number);
            }

            return Enumerable.Reverse(numbers).Take((int)row).ToList();
        }

        private static List<long> EvenNumbers(long length, long row)
        {
            var number = 0;
            var numbers = new List<long>();

            while (numbers.Count < length)
            {
                number++;
                if (number % 2 == 0)
                    numbers.Add(number);
            }

            return Enumerable.Reverse(numbers).Take((int)row).ToList();
        }
    }
}