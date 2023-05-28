namespace Excellent_Grade_or_Not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter grade = ");
            int grade = int.Parse(Console.ReadLine());
            if (grade >= 5.5)
            {
                Console.WriteLine("Excelent :) ");
            }
            else
            {
                Console.WriteLine("Not excelent");
            }
        }
    }
}