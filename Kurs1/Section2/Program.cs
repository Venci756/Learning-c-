using System;

namespace Section2
{
    class Program
    {
        static void Main(string[] args)
        {
            //And is only true when both sides are true
            //T && T = T
            //T && F = F
            //F && F = F
            //F && T = f

            //Or is only false when both sides are false
            //T || T = T
            //T || F = T
            //F || T = T
            //F || F = F
            bool x = true;
            bool y = true;

            bool z = x && y;

            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            if (age >=18 && age <=55)
            {
                Console.WriteLine("Good to go");
            }
            else
            {
                Console.WriteLine("No you are not");
            }
            
        }
    }
}
