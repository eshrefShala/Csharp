namespace Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var bonusScore = 0.0;
            if (num > 1000)
            {
                bonusScore = num * 0.10;
            }
            else if (num > 100)
            {
                bonusScore = 0.2 * num;
            }
            else if (num <= 100)
            {
                bonusScore = 5;
            }
            if (num % 2 == 0)
            {
                bonusScore += 1;
            }
            if (num % 10 == 5)
            {
                bonusScore += 2;
            }

            Console.WriteLine(bonusScore);
            Console.WriteLine(num + bonusScore);
        }
    }
}