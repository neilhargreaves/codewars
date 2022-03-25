using System;

namespace CodeWars
{
    public class RGBtoHEX
    {
        public static string RgbtoHex(int r, int g, int b)
        {
            r = Math.Max(Math.Min(255, r), 0);
            g = Math.Max(Math.Min(255, g), 0);
            b = Math.Max(Math.Min(255, b), 0);  

            return $"{r:X2}{g:X2}{b:X2}";
        }
    }
}
