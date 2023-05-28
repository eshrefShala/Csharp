using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;
        fahrenheit = Math.Round(fahrenheit, 2);

        Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F.");
    }
}
