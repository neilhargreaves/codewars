using System.Linq;

namespace CodeWars
{
    public class XbonacciSequence
    {
        public double[] Xbonacci(double[] signature, int n)
        {
            var sequenceType = signature.Count();
            var sequence = signature.ToList();

            while (sequence.Count < n)
            {
                var value = sequence.Skip(sequence.Count - sequenceType).Sum();
                sequence.Add(value);
            }

            return sequence.Take(n).ToArray();
        }
    }
}
