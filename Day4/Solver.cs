using System.ComponentModel;

namespace Day4
{
    public class Solver
    {
        public int Solve(IEnumerable<string> input)
        {
            double result = 0;
            foreach (string line in input)
            {
                var card = line.Split(':')[1];
                var split = card.Split("|");
                var wn = split[0];

                var winningNumbers = CreateIEnumerableFromString(split[0]);

                var playerNumbers = CreateIEnumerableFromString(split[1]);

                var commonNumbers = winningNumbers.Intersect(playerNumbers).Count();

                if (commonNumbers > 0)
                {
                    result += Math.Pow(2, (double)(commonNumbers - 1));
                }
            }
            return ((int)result);
        }

        private IEnumerable<int> CreateIEnumerableFromString(string input)
        {
            return input.Split(" ")
                .Where(text => !string.IsNullOrWhiteSpace(text))
                .Select(text => int.Parse(text));
        }
    }
}
