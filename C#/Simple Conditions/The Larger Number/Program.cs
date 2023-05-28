namespace The_Larger_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter value ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Greater number: " + num1);            
            }
            else 
            {
                Console.WriteLine("Greater number: " + num2);
            }
        }
    }
}