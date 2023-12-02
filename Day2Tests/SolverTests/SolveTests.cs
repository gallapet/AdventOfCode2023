using Common;
using Day2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Tests.SolverTests
{
    [TestClass]
    public class SolveTests
    {
        [TestMethod]
        public void Solve_Valid_Okay()
        {
            // Arrange
            FileReader.BasePath = @"C:\Users\peter\source\repos\AdventOfCode2023\Inputs\";
            var input = FileReader.Read("day2Sample.txt");
            var solver = new Solver();

            // Act
            var result = solver.Solve(input);

            // Assert
            result.ShouldBe(8);
        }
    }
}

