using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class StringExtension
    {
        public static bool IsSymbol(this string character)
        {
            return character != "." && !int.TryParse(character, out _);
        }
    }
}
