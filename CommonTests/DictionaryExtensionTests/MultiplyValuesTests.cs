using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTests.DictionaryExtensionTests
{
    [TestClass]
    public class MultiplyValuesTests
    {
        [TestMethod]
        public void MultiplyValues_Valid_Okay()
        {
            // Arrange
            IDictionary<string, int> input = new Dictionary<string, int>()
            {
                { "a", 2 },
                { "b", 3 },
            };

            // Act
            var result = input.MultiplyValues();

            // Assert
            result.ShouldBe(6);
        }
    }
}
