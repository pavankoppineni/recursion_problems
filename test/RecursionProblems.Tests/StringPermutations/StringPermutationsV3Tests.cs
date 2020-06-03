using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecursionProblems.StringPermutations;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionProblems.Tests.StringPermutations
{
    [TestClass]
    public class StringPermutationsV3Tests
    {
        [TestMethod]
        public void GivenString_GeneratePermutations_ReturnsListOfPermutations()
        {
            //Arrange
            var str = "aab";
            var expectedPermutations = new HashSet<string>
            {
                "abc",
                "acb",
                "bac",
                "bca",
                "cba",
                "cab"
            };
            var stringPermutation = new StringPermutationsV3();

            //Act
            var actualPermutations = stringPermutation.GeneratePermutations(str);

            //Assert
            Assert.AreEqual(expectedPermutations.Count, actualPermutations.Count);
            for (var i = 0; i < actualPermutations.Count; i++)
            {
                Assert.AreEqual(true, expectedPermutations.Contains(actualPermutations[i]));
            }
        }
    }
}
