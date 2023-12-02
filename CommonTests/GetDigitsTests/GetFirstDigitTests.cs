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
    public class GetFirstDigitTests
    {
        [DataTestMethod]
        [DataRow("a1b", 1)]
        [DataRow("2ab", 2)]
        [DataRow("ab3", 3)]
        [DataRow("a1b23", 1)]
        [DataRow("one23", 1)]
        public void GetFirstDigit_ValidString_IntReturned(string input, int expected)
        {
            // Act
            var result = GetDigits.GetFirstDigit(input);

            // Assert
            result.ShouldBe(expected);
        }

        [TestMethod]
        public void GetFirstDigit_NoNumber_ErrorReturned()
        {
            // Arrange
            var input = "abc";

            // Act 
            Should.Throw<InvalidOperationException>(() =>
            {
                GetDigits.GetFirstDigit(input);
            });
        }
    }
}
