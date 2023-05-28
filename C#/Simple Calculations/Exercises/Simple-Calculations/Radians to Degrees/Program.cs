namespace Radians_to_Degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Radius = ");
            double rad = double.Parse(Console.ReadLine());
            double deg = rad * 180 / Math.PI;

            deg = Math.Round(deg, 2);

            Console.Write("Degrees = " + deg);
        }
    }
}