namespace Identical_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first word: ");
            string word1 = Console.ReadLine().ToLower();

            Console.Write("Enter the second word: ");
            string word2 = Console.ReadLine().ToLower();

            if (word1 == word2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }

}