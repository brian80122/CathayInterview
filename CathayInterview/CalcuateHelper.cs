using System.Globalization;

namespace CathayInterview
{
    public static class CalculateHelper
    {

        public static string[] Calculate(decimal rate, string[] input)
        {
            var sortedAmounts = input
                .Select(x => ((x.Contains("-") ? 0 : decimal.Parse(x)) * rate).ToString(CultureInfo.InvariantCulture))
                .OrderByDescending(x => x)
                .ToArray();

            return sortedAmounts;
        }
    }
}
