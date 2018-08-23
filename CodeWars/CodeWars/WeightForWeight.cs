using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class WeightForWeight
    {
        public static string OrderWeight(string strng)
        {
            var numberList = strng.Split(" ").ToList();
            numberList.Sort();

            var sortedList = numberList.Aggregate(new SortedList<decimal, string>(), (x, y) => {
                decimal key = y.Select(digit => int.Parse(digit.ToString())).Sum();

                while (x.ContainsKey(key))
                {
                    key += 0.1m;
                }

                x.Add(key, y);
                return x;
            });

            return string.Join(" ", sortedList.Values);
        }
    }
}
