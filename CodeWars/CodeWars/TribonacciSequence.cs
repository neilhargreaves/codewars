using System.Linq;

namespace CodeWars
{
    public class TribonacciSequence
    {
        public double[] Tribonacci(double[] signature, int n)
        {
            var sequence = signature.ToList();

            while (sequence.Count < 3)           
                sequence.Insert(0, 0);            

            while(sequence.Count < n)
            {
                var value = sequence.Skip(sequence.Count - 3).Sum();
                sequence.Add(value);
            }

            var returnSequence = sequence.Take(n).ToList();

            if (returnSequence.Count() == 0)
                returnSequence.Add(0);

            return returnSequence.ToArray();
        }
    }
}
