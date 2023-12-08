using Common;
using Shouldly;

namespace CommonTests.StringExtenstionTests
{
        [TestClass]
        public class IsSymbolTests
        {
            [DataTestMethod]
            [DataRow(".", false)]
            [DataRow("1", false)]
            [DataRow("2", false)]
            [DataRow("+", true)]
            [DataRow("*", true)]
            [DataRow("#", true)]
            public void IsSymbol_Valid_Okay(string character, bool expected)
            {
                // Act
                var result = character.IsSymbol();

                // Assert
                result.ShouldBe(expected);
            }
        }
    }
