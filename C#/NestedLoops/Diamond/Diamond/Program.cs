using System;


namespace Diamond
{
    class Diamond
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //her we split the diamond in the left and right side

            int left = n / 2;
            int right = n / 2;

            //now we use for to make the structure
            for (int row = 0; row < n / 2; row++) //now we set the row loop
            {
                for (int col = 0; col < n; col++)// we set the Colom loop
                {
                    if(col == left || col == right)//With this strategy we say if the right side is equal and if the left is equal we print a star
                    {
                        Console.Write("*");
                    }
                    else//otherwise draw a minus
                    {
                        Console.Write('-');
                    }
                    
                }

                Console.WriteLine();
                left--;
                right++;
            }
            //this is the middle part
            Console.Write("*");
            Console.Write(new string('-', n - 2));
            Console.Write("*");
            Console.WriteLine();
            //

            //Now we do thw bottom part it is baseicly as the top part but ce change left to positive and right to negativ

            left = 1;
            right = n - 2;

            for (int row = 0; row < n / 2; row++) //now we set the row loop
            {
                for (int col = 0; col < n; col++)// we set the Colom loop
                {
                    if (col == left || col == right)//With this strategy we say if the right side is equal and if the left is equal we print a star
                    {
                        Console.Write("*");
                    }
                    else//otherwise draw a minus
                    {
                        Console.Write('-');
                    }

                }

                Console.WriteLine();
                left++;
                right--;
            }

        }
    }
}
