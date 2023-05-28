using System;

namespace Rhombus_Down 
{
    class Rhombus_Down 
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n -1; row++)
            {
                Console.Write("*");
                for (int col = n-1; col > row; col--) 
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}

