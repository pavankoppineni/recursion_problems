using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecursionProblems.PrintPyramid;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionProblems.Tests.PrintPyramid
{
    [TestClass]
    public class PrintPyramidV1Tests
    {
        [TestMethod]
        public void GivenHeight_Print_ReturnsListOfRows()
        {
            //Arrange
            var height = 3;
            var printPyramid = new PrintPyramidV1();
            var expectedRows = new List<string>
            {
                "#",
                "##",
                "###",
            };

            //Act
            var actualRows = printPyramid.Print(height);

            //Assert
            Assert.AreEqual(expectedRows.Count, actualRows.Count);
            for (var i = 0; i < expectedRows.Count; i++)
            {
                Assert.AreEqual(expectedRows[i], actualRows[i]);
            }
        }
    }
}
