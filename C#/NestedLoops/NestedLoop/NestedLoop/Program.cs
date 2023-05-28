using System;

namespace NestedLoop 

{
    class NestedLoop 
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            for (int r = 1; r <= n; r++)
            {
                //Console.Write("*");
                for (int c = 0; c < n; c++)
                    Console.Write("* ");
                    Console.WriteLine();
            }
        }
    }
}
