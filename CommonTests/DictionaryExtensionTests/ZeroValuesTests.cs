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
    public class ZeroValuesTests
    {
        [TestMethod]
        public void ZeroValues_Valid_Okay()
        {
            // Arrange
            IDictionary<string, int> input = new Dictionary<string, int>()
            {
                { "a", 2 },
                { "b", 3 },
            };

            // Act
            input.ZeroValues();

            // Assert
            input["a"].ShouldBe(0);
            input["b"].ShouldBe(0);

        }
    }
}
