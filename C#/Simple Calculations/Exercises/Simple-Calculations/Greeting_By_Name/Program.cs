namespace Greeting_By_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name = ");
            string str = string.Concat(Console.ReadLine());
            Console.Write("Hello, {0}", str);
        }
    }
}