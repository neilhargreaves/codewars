using System.Text.RegularExpressions;

namespace CodeWars
{
    public class Dubstep
    {
        public static string SongDecoder(string input)
        {          
            return Regex.Replace(input.Replace("WUB", " ").Trim(), "[ ]{2,}", " ");
        }
    }
}
