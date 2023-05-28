namespace Introduction_to_Simple_Calculations_by_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Foots = ");
            int foots = int.Parse(Console.ReadLine());
            double meters = foots * 0.3048;
            Console.Write("Meters = ");
            Console.WriteLine(meters);
        }
    }
}