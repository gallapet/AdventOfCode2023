using Common;

namespace Day1
{
    public class Solver
    {
        public int Solve(IEnumerable<string> input) 
        {
            var values = new List<int>();
            foreach (var line in input) 
            {
                var firstDigit = GetDigits.GetFirstDigit(line);
                var lastDigit = GetDigits.GetLastDigit(line);

                values.Add(GetDigits.GetCombinedDigits(firstDigit, lastDigit));
            }
            return values.Sum();
        }
    }
}
