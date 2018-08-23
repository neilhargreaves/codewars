using System.Collections.Generic;

namespace CodeWars
{
    public class SquaresInRectangle
    {
        public static List<int> SquareCalculator(int lng, int wdth)
        {
            if(lng == wdth)
                return null;

            var squares = new List<int>();

            while (lng > 0 && wdth > 0)
            {
                if (lng > wdth)
                {
                    squares.Add(wdth);
                    lng -= wdth;
                    continue;
                }

                if (lng < wdth)
                {
                    squares.Add(lng);
                    wdth -= lng;
                    continue;
                }

                squares.Add(lng);
                lng -= wdth;
                wdth -= lng;
            }

            return squares;
        }
    }
}
