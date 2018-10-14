using System;

namespace Vezba3_time
{
    class Program
    {
        static void Main(string[] args)
        {
            //write a program that asks the user to enter an amount of time in minutes only.
            //print to the console the same amount of time in hours and minutes.

            Console.Write("Napisi go vremeto vo minuti momceta ");
            int vremeVoMinuti = int.Parse(Console.ReadLine());
            int casovi = vremeVoMinuti / 60;
            int minuti = vremeVoMinuti % 60;
            Console.WriteLine("Toa se "+casovi + " Casovi " + " i " + minuti +" minuti");
            Console.ReadLine();
        }
    }
}
