namespace Problem_Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            var area = a * b;
            Console.Write("Area = " + area);
        }
    }
}