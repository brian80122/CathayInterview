using System.Text;

namespace CathayInterview.Helpers
{
    public static class CardNumberMaskHelper
    {
        public const string StartMarks = "****-";
        public static string MaskCreditCard(string creditCardNumber)
        {
            if (creditCardNumber.Length is not 12 && 
                creditCardNumber.Length is not 16)
            {
                throw new ArgumentException(@"CreditCardNumber must be 12 or 16");
            }

            var splitStringList = SplitStringIntoChunks(creditCardNumber, 4).ToList();

            var sb = new StringBuilder();
            for (var i = 0; i < splitStringList.Count - 1; i++)
            {
                sb.Append(StartMarks);
            }

            sb.Append(splitStringList[^1]);

            return sb.ToString();
        }


        public static IEnumerable<string> SplitStringIntoChunks(string input, int chunkSize)
        {
            return Enumerable.Range(0, input.Length / chunkSize).Select(i => input.Substring(i * chunkSize, chunkSize));
        }
    }
}
