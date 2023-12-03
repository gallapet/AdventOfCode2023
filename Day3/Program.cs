using Common;
using Day3;

var input = FileReader.Read("day3Input.txt");

var solver = new Solver();
var result = solver.Solve(input);

Console.WriteLine(result.ToString());