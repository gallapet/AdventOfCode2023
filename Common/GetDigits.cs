using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class GetDigits
    {
        static IDictionary<string, int> StringNumbers = new Dictionary<string, int>()
        {
            { "one", 1 }, { "two", 2 }, { "three", 3 }, { "four", 4 }, { "five", 5 }, 
            { "six", 6 }, { "seven", 7 }, { "eight", 8 }, { "nine", 9 } 
        };
        public static int GetFirstDigit(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (int.TryParse(input[i].ToString(), out int digit))
                {
                    return digit;
                }

                foreach (string key in StringNumbers.Keys)
                {
                    if (input.Substring(i).StartsWith(key))
                    {
                        return StringNumbers[key];
                    }
                }
            }
            throw new InvalidOperationException("no number in string");
        }

        public static int GetLastDigit(string input)
        {
            for (var i = input.Length - 1; i >= 0; i--)
            {
                if (int.TryParse(input[i].ToString(), out int digit))
                {
                    return digit;
                }

                foreach (string key in StringNumbers.Keys)
                {
                    if (input.Substring(i).StartsWith(key))
                    {
                        return StringNumbers[key];
                    }
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
