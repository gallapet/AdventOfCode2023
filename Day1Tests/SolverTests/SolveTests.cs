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
            var input = new List<string>();
            var target = new Solver();
            
            // Act
            var result = target.Solve(input);

            // Assert
            result.ShouldBe(142);
        }
    }
}
