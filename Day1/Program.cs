using Common;
using Day1;

bool isTesting = false;

string filename = isTesting ? "day1Sample.txt" : "day1Input.txt";

var input = FileReader.Read(filename);

var solver = new Solver();
var result = solver.Solve(input);

Console.WriteLine(result.ToString());
