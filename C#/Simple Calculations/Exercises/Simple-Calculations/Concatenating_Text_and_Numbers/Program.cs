using Microsoft.VisualBasic;

namespace Concatenating_Text_and_Numbers
{
    internal class Program
    {
        static void Main()
        {

            var FirstName = Console.ReadLine();

            var LastName = Console.ReadLine();
            
            var age = int.Parse(Console.ReadLine());

            var town = Console.ReadLine();

            Console.WriteLine("You're name is {0} {1}, You are {2}, from {3}", FirstName, LastName, age, town);
        }
    }
}