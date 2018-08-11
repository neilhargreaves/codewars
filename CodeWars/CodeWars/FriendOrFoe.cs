using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class Kata
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            return names.ToList().Where(x => x.Length == 4);
        }
    }
}