using Common;
using Day5;
using Shouldly;

namespace Day5Tests.SolverTests
{
    [TestClass]
    public class SolveTests
    {
        [TestMethod]
        public void Solve_Valid_Okay()
        {
            // Arrange
            FileReader.BasePath = @"C:\Users\peter\source\repos\AdventOfCode2023\Inputs\";
            var input = FileReader.Read("day5Sample.txt");
            var solver = new Solver();
            
            // Act 
            var result = solver.Solve(input);

            // Assert
            result.ShouldBe(35);
        }
    }
}
