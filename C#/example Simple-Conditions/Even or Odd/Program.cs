namespace Even_or_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Value = ");
            double num = double.Parse(Console.ReadLine());

            if (num %  2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}