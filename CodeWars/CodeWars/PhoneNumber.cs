using System.Linq;

namespace CodeWars
{
    public class PhoneNumber
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            var numberList = numbers.ToList();
            var section1 = string.Join("", numberList.Take(3));
            var section2 = string.Join("", numberList.Skip(3).Take(3));
            var section3 = string.Join("", numberList.Skip(6).Take(numberList.Count - 6));

            return $"({section1}) {section2}-{section3}";
        }
    }
}
