namespace Circle_Area_and_Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Circle radius. r = ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Area = " + Math.PI * r * r);
            Console.WriteLine("Perimeter = " + 2 * Math.PI * r);

        }
    }
}