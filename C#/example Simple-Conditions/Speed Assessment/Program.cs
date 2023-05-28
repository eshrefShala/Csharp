namespace Speed_Assessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter speed: ");
            double speed = double.Parse(Console.ReadLine());

            if (speed <= 10)
            {
                Console.WriteLine("Slow");
            }
            else if (speed <= 50)
            {
                Console.WriteLine("Average");
            }
            else if (speed <= 150)
            {
                Console.WriteLine("Fast");
            }
            else if (speed <= 1000)
            {
                Console.WriteLine("Ultra fast");
            }
            else
            {
                Console.WriteLine("Extremely fast");
            }
        }


    }
}