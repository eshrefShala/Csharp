using System.Diagnostics;

namespace A_Program_That_Converts_USD_to_EUR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dollar = int.Parse(Console.ReadLine());
            var euro = dollar * 0.883795087;
            Console.WriteLine(euro);
        }
    }
}