//Write a program that reads a year from the console and checks whether it is a leap one.
// Use  System.DateTime .

using System;

    class LeapYear
    {
        static void Main()
        {
            Console.WriteLine("Enter a year to check it is leap or not?");
            int year = int.Parse(Console.ReadLine());
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("The year you entered is leap");
            }
            else
            {
                Console.WriteLine("The year you entered is not leap");
            }
        }
    }

