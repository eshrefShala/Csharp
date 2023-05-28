namespace Triangle_of_55_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 0; col < row; col++) 
                { 
                
                   Console.Write("*");
                }
                Console.WriteLine();
            }
           
        }
    }
}