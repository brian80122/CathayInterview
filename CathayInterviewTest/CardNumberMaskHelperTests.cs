using CathayInterview.Helpers;
using NUnit.Framework;
using System;

namespace CathayInterviewTest
{
    [TestFixture]
    public class CardNumberMaskHelperTests
    {
        [TestCase("123456789012", "****-****-9012")]
        [TestCase("1234567890123456", "****-****-****-3456")]
        public void MaskCreditCard_ValidInput_ReturnsMaskedNumber(string input, string expectedOutput)
        {
            // Act
            string maskedCardNumber = CardNumberMaskHelper.MaskCreditCard(input);

            // Assert
            Assert.AreEqual(expectedOutput, maskedCardNumber);
        }

        [TestCase("123", typeof(ArgumentException), "CreditCardNumber must be 12 or 16")]
        [TestCase("12345678901234567", typeof(ArgumentException), "CreditCardNumber must be 12 or 16")]
        public void MaskCreditCard_InvalidInput_ThrowsException(string input, Type exceptionType, string expectionMessage)
        {
            // Assert
            Assert.Throws(exceptionType, () => CardNumberMaskHelper.MaskCreditCard(input), expectionMessage);
        }
    }
}
