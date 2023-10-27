namespace CathayInterview.Helpers
{
    public static class FormatHelper
    {
        public static string FormatInput<T>(T input)
        {
            if (input == null)
                throw new ArgumentException($@"Input can not be null");

            if (typeof(T) == typeof(int) || typeof(T) == typeof(string))
            {
                return input.ToString()!;
            }

            if (typeof(T) == typeof(DateTime))
            {
                var date = (DateTime)(object)input;
                return date.ToString("yyyy/MM/dd");
            }

            throw new ArgumentException("Unsupported input type");
        }
    }
}
