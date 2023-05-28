using System;

class Music
{
    static void Main()
    {
        for (int i = 200; i <= 4000; i += 200)
        {
            Console.Beep(i, 100);
        }
    }
}
