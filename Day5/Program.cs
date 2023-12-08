using Common;
using Day5;

var input = FileReader.Read("day5Input.txt");

var solver = new Solver();
var result = solver.Solve(input);

Console.WriteLine(result.ToString());