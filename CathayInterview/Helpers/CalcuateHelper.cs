using System.Globalization;
using CathayInterview.Extensions;

namespace CathayInterview.Helpers
{
    public static class CalculateHelper
    {

        public static string[] Calculate(decimal rate, string[] input)
        {
            var sortedAmounts = input
                .Select(x => ((x.Contains("-") ? 0 : decimal.Parse(x)) * rate).Normalize().ToString(CultureInfo.InvariantCulture))
                .OrderByDescending(x => x)
                .ToArray();

            return sortedAmounts;
        }
    }
}
