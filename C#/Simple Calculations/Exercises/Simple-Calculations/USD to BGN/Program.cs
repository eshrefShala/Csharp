namespace USD_to_BGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter USD = ");
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.83;

            bgn = Math.Round(bgn, 2);

            Console.WriteLine(bgn);
        }
    }
}