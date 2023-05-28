namespace Introduction_to_Simple_Conditions_by_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter you're area size = ");
            decimal size = decimal.Parse(Console.ReadLine());

            
            if(size < 0)
                Console.WriteLine($"Negative size: {size}");
            else if(size > 1000)
                Console.WriteLine($"Size too big: {size}");
            else
            {
                Console.WriteLine($"Size accepted: {size}");
                Console.WriteLine($"Area: {size * size}");
            }


        }
    }
}