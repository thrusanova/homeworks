 //Age after 10 Years
using System;
class AgeAfterTen
    {
        static void Main()
        {
            
           Console.WriteLine("Enter the date of your birthday:mm-dd-yy ");
           DateTime theDateOfBirth = DateTime.Parse(Console.ReadLine());
            DateTime currentDate = DateTime.Now;
         int   myAge = currentDate.Year - theDateOfBirth.Year;
         Console.WriteLine("Your age in the moment is " + myAge);
         Console.WriteLine("Your age after 10 years will be "+ (myAge + 10));
        
        }
    }

