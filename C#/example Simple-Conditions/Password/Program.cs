namespace Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Password: ");
            var pass = Console.ReadLine();

            if (pass == "s3cr3t!P@ssw0rd") 
            {
                Console.WriteLine("Welcome! ");
            
            }
            else
            {
                Console.WriteLine("Wrong password try again! ");
            }
        }
    }
}