using System.Collections.Generic;

namespace CodeWars
{
    public class MembersService
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            var output = new List<string>();

            foreach(var item in data)
            {
                if(item[0] >= 55 && item[1] > 7)
                {
                    output.Add("Senior");
                    continue;
                }

                output.Add("Open");                
            }

            return output;
        }
    }
}
