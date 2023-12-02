using Common;
using Day2;

var input = FileReader.Read("day2Input.txt");

var solver = new Solver();
var result = solver.Solve(input);

Console.WriteLine(result.ToString());