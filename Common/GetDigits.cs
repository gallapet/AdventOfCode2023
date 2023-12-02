using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class GetDigits
    {
        public static int GetFirstDigit(string input)
        {
            foreach (char c in input) 
            {
                if (int.TryParse(c.ToString(), out int digit))
                {
                    return digit;
                }
            }
            throw new InvalidOperationException("no number in string");
        }

        public static int GetLastDigit(string input)
        {
            var reversed = input.Reverse();
            foreach (char c in reversed)
            {
                if (int.TryParse(c.ToString(), out int digit))
                {
                    return digit;
                }
            }
            throw new InvalidOperationException("no number in string");
        }

        public static int GetCombinedDigits(int first, int last) 
        {
            return int.Parse(first.ToString() + last.ToString());
        }
    }
}
