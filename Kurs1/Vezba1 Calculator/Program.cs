using System;

namespace Vezba1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exersise Read two numbers from user and add them together 
            //then print the results

            Console.WriteLine("Enter first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondNumber = int.Parse(Console.ReadLine());

            int answer = firstNumber + secondNumber;
            Console.WriteLine(firstNumber + "+" + secondNumber + "=" + answer);
        }
    }
}
