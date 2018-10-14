using System;

namespace CarpentingVezba
{
    class Program
    {
        static void Main(string[] args)
        {
            //write a program that asks the user for the length and width of their room. Define a constant that 
            // represents the price of carpenting per square foot. Compute and display the cost of carpenting the 
            //room.
            const int price = 25;
            
            Console.WriteLine("Kolko ti e dugacka sobata momceta?");
            int dolzina = int.Parse(Console.ReadLine());
            Console.WriteLine("A kolko ti e sirocka sosbata momceta?");
            int sirina = int.Parse(Console.ReadLine());
            int trosok = (dolzina * sirina) * price;
            Console.WriteLine("epa momceta sobata ce te kosta " + trosok + " evri"); 
        }
    }
}
