namespace About_the_Curly_Braces_After_If__Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var color = Console.ReadLine();
            //if (color == "red")
            //    Console.WriteLine("tomato");
            //else if  (color == "yellow")
            //    Console.WriteLine("Bannana");
            //Console.WriteLine("Lemon");
            // With this code the out put will be tomato bececause we dont use {}, but if we use {} the code and the output will look like down bellow
                                                 //tomato

            var color = Console.ReadLine();
            if (color == "red")
            {
                Console.WriteLine("tomato");
            }
                
            else if  (color == "yellow")
            {
                Console.WriteLine("Banom");
                Console.WriteLine("Lemon");
            }
               
        }
    }
}