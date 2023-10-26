// See https://aka.ms/new-console-template for more information

using CathayInterview;

string[] amountList = { "1.2", "1.4", "0.2", "-", "-0.005" };
decimal rate = 0.33m;

var result = CalculateHelper.Calculate(rate, amountList);

Console.WriteLine(string.Join($@", ", result));

Console.ReadKey();

