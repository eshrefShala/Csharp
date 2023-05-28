namespace Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x1 = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Enter y1 = ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Enter x2 = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Enter y2 = ");
            double y2 = double.Parse(Console.ReadLine());

            double widht = Math.Max(x2, x1) - Math.Min(x2, x1);
            double height = Math.Max(y2, y1) - Math.Min(y2, y1);
            double area = widht * height;
            double perimeter = 2 * widht * height;

            Console.WriteLine("Area = " + area);
            Console.WriteLine("Perimeter = " + perimeter);
        }
    }
}