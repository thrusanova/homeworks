//• Write a method that returns the last digit of given integer as an English word.
//512 two 
//1024 four 
//12309 nine 

using System;
   class EnglishDigit
    {
        static void Main()
        {
            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            string lastDigit = GetLastDigit(number % 10);
            Console.Write("The last digit of the number is:");
            Console.WriteLine(lastDigit);
        }
        static string GetLastDigit(int number)
        {
            if (number<0)
            {
                number *= -1;
            }
            if (number==0) return "zero";
            else if (number == 1) return "one";
            else if (number == 2) return "two";
            else if (number == 3) return "three";
            else if (number == 4) return "four";
            else if (number == 5) return "five";
            else if (number == 6) return "six";
            else if (number == 7) return "seven";
            else if (number == 8) return "eight";
             return "nine";
        }
    }
