using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the type of the figure (square, rectangle, circle, triangle): ");
            string figureType = Console.ReadLine();

            if (figureType == "square")
            {
                Console.Write("Enter the length of a side: ");
                double squareSide = double.Parse(Console.ReadLine());
                double squareArea = Math.Round(squareSide * squareSide, 3);
                Console.WriteLine($"The area of the square is {squareArea}");
            }
            else if (figureType == "rectangle")
            {
                Console.Write("Enter the length of the first side: ");
                double rectangleSide1 = double.Parse(Console.ReadLine());
                Console.Write("Enter the length of the second side: ");
                double rectangleSide2 = double.Parse(Console.ReadLine());
                double rectangleArea = Math.Round(rectangleSide1 * rectangleSide2, 3);
                Console.WriteLine($"The area of the rectangle is {rectangleArea}");
            }
            else if (figureType == "circle")
            {
                Console.Write("Enter the radius of the circle: ");
                double circleRadius = double.Parse(Console.ReadLine());
                double circleArea = Math.Round(Math.PI * circleRadius * circleRadius, 3);
                Console.WriteLine($"The area of the circle is {circleArea}");
            }
            else if (figureType == "triangle")
            {
                Console.Write("Enter the length of the base of the triangle: ");
                double triangleBase = double.Parse(Console.ReadLine());
                Console.Write("Enter the length of the height of the triangle: ");
                double triangleHeight = double.Parse(Console.ReadLine());
                double triangleArea = Math.Round(0.5 * triangleBase * triangleHeight, 3);
                Console.WriteLine($"The area of the triangle is {triangleArea}");
            }
            else
            {
                Console.WriteLine("Invalid figure type entered!");
            }
        }
    }
}
