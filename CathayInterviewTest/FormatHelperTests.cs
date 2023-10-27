using CathayInterview.Helpers;
using NUnit.Framework;
using System;

namespace CathayInterviewTest
{
    public class FormatHelperTests
    {
        [Theory]
        [TestCase(123, "123")]
        [TestCase(456, "456")]
        public void FormatInput_IntInput_ReturnsExpectedResult(int input, string expectedResult)
        {
            // Act
            string result = FormatHelper.FormatInput(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Theory]
        [TestCase("hello", "hello")]
        [TestCase("world", "world")]
        public void FormatInput_StringInput_ReturnsExpectedResult(string input, string expectedResult)
        {
            // Act
            string result = FormatHelper.FormatInput(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Theory]
        [TestCaseSource(nameof(_getDateTimeCases))]
        public void FormatInput_DateTimeInput_ReturnsExpectedResult(DateTime input, string expectedResult)
        {
            // Act
            string result = FormatHelper.FormatInput(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        private static object[] _getDateTimeCases =
        {
            new object[] { new DateTime(2022, 6, 20,12,05,33), "2022/06/20" },
            new object[] { new DateTime(2021, 10, 5,22,15,19), "2021/10/05" }
        };


        [Test]
        public void FormatInput_NullInput_ThrowsArgumentException()
        {
            // Arrange
            object? input = null;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => FormatHelper.FormatInput(input), "Input can not be null");
        }

        [Test]
        public void FormatInput_UnsupportedTypeInput_ThrowsArgumentException()
        {
            // Arrange
            object input = new object(); // an unsupported type

            // Act & Assert
            Assert.Throws<ArgumentException>(() => FormatHelper.FormatInput(input), "Unsupported input type");
        }
    }
}
