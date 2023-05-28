namespace Triangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter h = ");
            double h = double.Parse(Console.ReadLine());

            double area = a * h / 2;
            area = Math.Round(area, 2);


            Console.WriteLine("Area = " + area);
        }
    }
}