using Common;
using Day1;

var input = FileReader.Read("day1Input.txt");

var solver = new Solver();
var result = solver.Solve(input);

Console.WriteLine(result.ToString());
