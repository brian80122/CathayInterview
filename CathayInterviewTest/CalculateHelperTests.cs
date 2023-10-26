using CathayInterview.Helpers;
using NUnit.Framework;
using System.Globalization;

namespace CathayInterviewTest
{
    [TestFixture]
    public class CalculateHelperTests
    {
        [TestCase("0.33", new string[] { "1.2", "1.4", "0.2", "-", "-0.005" }, new string[] { "0.462", "0.396", "0.066", "0", "0" })]
        [TestCase("0.5", new string[] { "2.0", "0.5", "-", "1.0" }, new string[] { "1", "0.5", "0.25", "0" })]
        [TestCase("0.2", new string[] { "10.0", "-", "5.5", "3.2" }, new string[] { "2", "1.1", "0.64", "0" })]
        public void Calculate_ShouldReturnCorrectResults_WhenValidInputsProvided(string rate, string[] input, string[] expectedOutput)
        {
            // Arrange
            decimal decimalRate = decimal.Parse(rate, CultureInfo.InvariantCulture);

            // Act
            var result = CalculateHelper.Calculate(decimalRate, input);

            // Assert
            Assert.AreEqual(expectedOutput.Length, result.Length);
            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.AreEqual(expectedOutput[i], result[i]);
            }
        }
    }
}

