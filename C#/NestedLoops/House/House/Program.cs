using System;
using System.Data;

namespace house
{
    class House
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int spacesCnt = (n - 1) / 2;
            int starsCnt = 1;
            if (n % 2 == 0)
            {
                starsCnt = 2;
            }
            for (int row = 0; row < (n - 1) / 2; row++)
            {
                Console.Write(new string('-', spacesCnt));
                Console.Write(new string('*', starsCnt));
                Console.Write(new string('-', spacesCnt));
                Console.WriteLine();

                starsCnt += 2;
                spacesCnt--;
            }

            Console.WriteLine(new string('*', n));

            for (int row = 0; row < (n - 1) / 2; row++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.Write("|");
                Console.WriteLine();
            }
        }
    }
}