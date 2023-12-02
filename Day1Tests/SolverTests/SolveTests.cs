using Day1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Tests.SolverTests
{
    [TestClass]
    public class SolveTests
    {
        [TestMethod]
        public void Solve_Valid_Okay()
        {
            // Arrange 
            // ---- Part 1 ----
            //var input = new List<string> { "1abc2", "npqr3stu8vwx", "na1b2c3d4e5f", "ntreb7uchet" };

            // ---- Part 2 ----
            var input = new List<string> { "two1nine", "eightwothree", "abcone2threexyz", "xtwone3four", "4nineeightseven2", "zoneight234", "7pqrstsixteen" };
            var target = new Solver();
            
            // Act
            var result = target.Solve(input);

            // Assert
            // ---- Part 1 ----
            //result.ShouldBe(142);

            // ---- Part 2 ----
            result.ShouldBe(281);
        }
    }
}
