namespace CathayInterview.Extensions
{
    public static class DecimalExtension
    {
        //refer:https://blog.darkthread.net/blog/decimal-trailing-zeros/
        public static decimal Normalize(this decimal value)
        {
            return value / 1.000000000000000000000000000000000m;
        }
    }
}
