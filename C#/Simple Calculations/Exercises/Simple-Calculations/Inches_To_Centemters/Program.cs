namespace Inches_To_Centemters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches = ");
            double Inches = double.Parse(Console.ReadLine());
            double Centemeters = Inches * 2.54;
            Console.Write("Centemeters = ");
            Console.WriteLine(Centemeters);
        }
    }
}