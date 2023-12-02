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
    public class GetLastDigitTests
    {
        [DataTestMethod]
        [DataRow("a1b", 1)]
        [DataRow("2ab", 2)]
        [DataRow("ab3", 3)]
        [DataRow("a1b23", 3)]
        [DataRow("a1b23four", 4)]
        public void GetLastDigit_ValidString_IntReturned(string input, int expected)
        {
            // Act
            var result = GetDigits.GetLastDigit(input);

            // Assert
            result.ShouldBe(expected);
        }

        [TestMethod]
        public void GetLastDigit_NoNumber_ErrorReturned()
        {
            // Arrange
            var input = "abc";

            // Act 
            Should.Throw<InvalidOperationException>(() =>
            {
                GetDigits.GetLastDigit(input);
            });
        }
    }
}
