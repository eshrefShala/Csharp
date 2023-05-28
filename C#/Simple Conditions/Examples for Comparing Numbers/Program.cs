namespace Examples_for_Comparing_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            //With input a = 5 and input b = 10 we get these results
            Console.WriteLine(a < b);//True
            Console.WriteLine(a > 0);//True
            Console.WriteLine(a > 100);//False
            Console.WriteLine(a < a);//False
            Console.WriteLine(a <= 5);//True
            Console.WriteLine(b == 2 * a);//True

        }
    }
}