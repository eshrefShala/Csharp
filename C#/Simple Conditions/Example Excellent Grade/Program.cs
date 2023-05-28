namespace Example_Excellent_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Grade = ");
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}