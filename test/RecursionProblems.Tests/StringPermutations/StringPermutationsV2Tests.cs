using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecursionProblems.StringPermutations;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionProblems.Tests.StringPermutations
{
    [TestClass]
    public class StringPermutationsV2Tests
    {
        [TestMethod]
        public void GivenString_GeneratePermutations_ReturnsListOfPermutations()
        {
            //Arrange
            var str = "abc";
            var expectedPermutations = new List<string>
            {
                "abc",
                "acb",
                "bac",
                "bca",
                "cba",
                "cab"
            };
            var stringPermutation = new StringPermutationsV2();

            //Act
            var actualPermutations = stringPermutation.GeneratePermutations(str);

            //Assert
            Assert.AreEqual(expectedPermutations.Count, actualPermutations.Count);
            for (var i = 0; i < expectedPermutations.Count; i++)
            {
                Assert.AreEqual(expectedPermutations[i], actualPermutations[i]);
            }
        }
    }
}
