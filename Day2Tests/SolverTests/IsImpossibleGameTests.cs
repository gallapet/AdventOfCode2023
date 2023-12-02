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
    public class IsImpossibleGameTests
    {
        [DataTestMethod]
        [DataRow("red", 1, false)]
        [DataRow("red", 20, true)]
        [DataRow("green", 2, false)]
        [DataRow("green", 30, true)]
        [DataRow("blue", 3, false)]
        [DataRow("blue", 40, true)]
        public void IsImpossibleGame_Valid_Okay(string colour, int number, bool expected)
        {
            // Arrange
            var solver = new Solver();

            // Act
            var result = solver.IsImpossibleGame(colour, number);

            // Assert
            result.ShouldBe(expected);
        }
    }
}
