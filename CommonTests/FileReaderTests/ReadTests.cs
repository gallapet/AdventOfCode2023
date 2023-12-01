using Common;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTests.FileReaderTests
{
    [TestClass]
    public class ReadTests
    {
        [TestMethod]

        public void Read_ValidFile_ArrayReturned()
        {
            // Act
            var result = FileReader.Read("TestInput.txt").ToList();

            // Assert
            result.Count.ShouldBe(3);
            result[0].ShouldBe("a");
            result[1].ShouldBe("b");
            result[2].ShouldBe("c");
        }
    }
}
