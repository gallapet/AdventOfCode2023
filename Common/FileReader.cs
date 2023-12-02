using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class FileReader
    {
        public static IEnumerable<string> Read(string filename) 
        {
            var path = Path.Combine(BasePath, filename);
            var result = new List<string>();

            using StreamReader sr = new (path);

            var line = sr.ReadLine();
            while (line != null) 
            {
                result.Add(line);
                line = sr.ReadLine();
            }

            sr.Close();
            return result;
        }

        public static string BasePath { get; set; } = @"C:\Users\peter\source\repos\AdventOfCode2023\Inputs\";
    }
}