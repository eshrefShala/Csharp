﻿using System;

namespace Sunglasses
{
    class Sunglasses
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.Write(new string('*', 2 * n));
            Console.WriteLine();
            for (int row = 0; row < n - 2; row++)
            {
                Console.Write('*');
                Console.Write(new string('/', (n * 2) - 2));
                Console.Write('*');

                if (row == (n - 1) / 2 - 1) 
                { 
                    Console.Write(new string('|', n));
                }
                else { 
                    Console.Write(new string(' ', n));
                }

              Console.Write('*');
              Console.Write(new string('/', (n * 2) - 2));
              Console.Write('*');

               Console.WriteLine();
            }


            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.Write(new string('*', 2 * n));
            Console.WriteLine();
        }
    }
}