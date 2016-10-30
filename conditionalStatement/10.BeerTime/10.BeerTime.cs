//// Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], 
//a minute in range [00…59] and AM / PM designator) and prints  beer time  or  non-beer time
//according to the definition above or  invalid time  if the time cannot be parsed. Note: You may need to learn how to parse dates and times.

using System;
 class BeerTime
    {
        static void Main()
        {   
            DateTime startTime = DateTime.Parse("1:00 PM");
            DateTime endTime = DateTime.Parse("3:00 AM");
            DateTime dt = DateTime.Parse(Console.ReadLine());
           
            if ((dt >startTime) || (dt > endTime))
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
    }

