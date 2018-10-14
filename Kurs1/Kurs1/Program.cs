using System;

namespace Kurs1
{
    class Program
    {
        enum DaysOfWeek
        {
            SUNDAY,
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY,

        }
        static void Main(string[] args)
        {
            DaysOfWeek today = DaysOfWeek.FRIDAY;
            Console.WriteLine(today);
            int numberOfToday = (int)today;
            Console.WriteLine(numberOfToday);
            
            
            
            
            
            
            
            //+-*%
            int myInt = 5 + 5;
            Console.WriteLine(myInt);
            int myInt2 = 5 - 5;
            Console.WriteLine(myInt);
            int myInt3 = 5 * 5;
            Console.WriteLine(myInt3);

            double myDouble = 45.0 / 2;
            Console.WriteLine(myDouble);

            double remain = 5 % 4;
            Console.WriteLine(remain);

            int result = (2 + 3) * 4;
            Console.WriteLine("The result is {0}", result);

            int myInt4 = myInt + myInt2 + myInt3;
            Console.WriteLine(myInt4);


            int x = 5;
            x = x +1;
            x += 1;

            Console.WriteLine("The value of x is {0}", x);
            int y = 5;
            y++;
            Console.WriteLine("The value of y is {0}", y);

            int b = 4;
            int c = ++b;
            Console.WriteLine("The value of b is {0} and the value c is {1}", b, c);

            // > >= < <= == !=
            bool myBool = true;

            bool myBool2 = 5 > 6;
            myBool = 6 != 6;
            Console.WriteLine(myBool2);

            int hoursWorked = 25;
            bool doesEmployeeGetOverTime = hoursWorked > 40;
            Console.WriteLine("Does employee get overtime? {0}", doesEmployeeGetOverTime);

            char myChar = '\n';
            Console.WriteLine(myChar);

            string myString = "Hello World";
            Console.WriteLine(myString);

            string name1 = "Jesse";
            string name2 = "Jesse";

            bool namesEqual = name1==name2;
            Console.WriteLine("Names equal {0}", namesEqual);

            bool namesEqual2 = string.Equals(name1, name2);
            Console.WriteLine("Names equal {0}", namesEqual2);

            int namesEqual3 = name1.CompareTo(name2);
            Console.WriteLine("Names equal{0}", namesEqual3);

            Console.WriteLine("{0} has {1} characters", name1, name1.Length);

            string firstCharacterOfName = name1.Substring(0, 1);
            Console.WriteLine(firstCharacterOfName);

            string middleSectionOfName = name1.Substring(1,3);
            Console.WriteLine(middleSectionOfName);

            bool startsWith = name1.StartsWith("Jess");
            Console.WriteLine(startsWith);

            int x1 = 5;

            double y1 = x1;

            double myDouble1 = 5.5;
            int myInt1 = (int)myDouble1;

            Console.WriteLine(myInt1);

            //declaring constants 

            const int myConstInt = 5;

            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello {0}", name);
            //string lastName = Console.ReadLine();
            //Console.WriteLine("Hello{0} {1}", name, lastName);

            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            number += 10;
            Console.WriteLine("The new number  is {0}",number);

            
        
      



        }
    }
}
