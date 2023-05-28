using System;

class CurrencyConverter
{
    static void Main()
    {
       
        const decimal BGN_USD_RATE = 0.55m;
        const decimal BGN_EUR_RATE = 0.51m;
        const decimal BGN_GBP_RATE = 0.46m;
        const decimal USD_EUR_RATE = 0.93m;
        const decimal USD_GBP_RATE = 0.83m;
        const decimal EUR_GBP_RATE = 0.89m;

        // Get input from the user
        Console.Write("Enter the amount: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        Console.Write("Enter the currency to convert from (BGN, USD, EUR, GBP): ");
        string fromCurrency = Console.ReadLine().ToUpper();

        Console.Write("Enter the currency to convert to (BGN, USD, EUR, GBP): ");
        string toCurrency = Console.ReadLine().ToUpper();

        // Convert the amount
        decimal convertedAmount = 0;

        if (fromCurrency == "BGN")
        {
            if (toCurrency == "USD")
                convertedAmount = amount * BGN_USD_RATE;
            else if (toCurrency == "EUR")
                convertedAmount = amount * BGN_EUR_RATE;
            else if (toCurrency == "GBP")
                convertedAmount = amount * BGN_GBP_RATE;
        }
        else if (fromCurrency == "USD")
        {
            if (toCurrency == "BGN")
                convertedAmount = amount / BGN_USD_RATE;
            else if (toCurrency == "EUR")
                convertedAmount = amount * USD_EUR_RATE;
            else if (toCurrency == "GBP")
                convertedAmount = amount * USD_GBP_RATE;
        }
        else if (fromCurrency == "EUR")
        {
            if (toCurrency == "BGN")
                convertedAmount = amount / BGN_EUR_RATE;
            else if (toCurrency == "USD")
                convertedAmount = amount / USD_EUR_RATE;
            else if (toCurrency == "GBP")
                convertedAmount = amount * EUR_GBP_RATE;
        }
        else if (fromCurrency == "GBP")
        {
            if (toCurrency == "BGN")
                convertedAmount = amount / BGN_GBP_RATE;
            else if (toCurrency == "USD")
                convertedAmount = amount / USD_GBP_RATE;
            else if (toCurrency == "EUR")
                convertedAmount = amount / EUR_GBP_RATE;
        }

        // Output the result
        Console.WriteLine("{0} {1} is equal to {2} {3}.", amount, fromCurrency, convertedAmount, toCurrency);
    }
}
