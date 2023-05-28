using System;
using System.Data;

namespace NestedLoops 

{
    class NestedLoopsTriangle 
    {
        static void Main() 
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++) 
            {
                for (int col = 0; col < row; col++) 
                {
                    Console.Write("*_* ");
                }
                Console.WriteLine();
            }
        }
    }
}