using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTests.GetDigitsTests
{
    [TestClass]
    public class GetCombinedDigitsTests
    {
        [TestMethod]
        public void GetCombinedDigits_Valid_IntReturned()
        {
            // Arrange
            var first = 1;
            var second = 2;

            // Act
            var result = GetDigits.GetCombinedDigits(first, second);

            // Assert
            result.ShouldBe(12);
        }
    }
}
