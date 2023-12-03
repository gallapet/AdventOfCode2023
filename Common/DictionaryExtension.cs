using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class DictionaryExtension
    {
        public static int MultiplyValues(this IDictionary<string, int> input)
        {
            var result = 1;
            foreach (string key in input.Keys)
            {
                result *= input[key];
            }
            return result;
        }

        public static void ZeroValues(this IDictionary<string, int> input)
        {
            foreach (string key in input.Keys)
            {
                input[key] = 0;
            }
        }
    }
}
