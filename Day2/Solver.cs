using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Solver
    {
        int maxNumberRed = 12;
        int maxNumberGreen = 13;
        int maxNumberBlue = 14;
        public int Solve(IEnumerable<string> input)
        {
            var result = 0;
            foreach (string line in input)
            {
                bool impossibleGame = false;

                var split = line.Split(":");
                int gameNumber = int.Parse(split[0].Substring(4));
                foreach(var set in split[1].Split(";")) 
                {
                    var elems = set.Split(" ");
                    for(var i = 0;  i < elems.Length; i++)
                    {
                        if (int.TryParse(elems[i].ToString(), out int numberOfDice))
                        {
                            if (IsImpossibleGame(elems[i + 1], numberOfDice))
                            {
                                impossibleGame = true;
                                break;
                            }
                        }
                    }
                }

                if (!impossibleGame)
                {
                    result += gameNumber;
                }
            }
            return result;
        }

        public bool IsImpossibleGame(string colour, int totalDice)
        {
            if (colour.Contains("red"))
            {
                return totalDice > maxNumberRed;
            } 
            else if (colour.Contains("green"))
            {
                return totalDice > maxNumberGreen;
            } 
            else if (colour.Contains("blue"))
            {
                return totalDice > maxNumberBlue;
            } 
            else
            {
                throw new InvalidDataException("colour not recognised!");
            }
        }
    }
}
