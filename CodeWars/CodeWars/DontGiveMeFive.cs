using System.Linq;

namespace CodeWars
{
    public class DontGiveMeFive
    {
        public static int NoFives(int start, int end)
        {
            return Enumerable.Range(start, end - start + 1).ToList().RemoveAll(Contains5);
        }

        private static bool Contains5(int s)
        {
            return !s.ToString().Contains("5");
        }
    }
}
