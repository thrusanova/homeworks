//Write an expression that checks for given integer if its third digit from right-to-left is  7 .
using System;
  class TheThirdDigitIsSeven
    {
        static void Main()
        {
            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            bool IsSeven = false;
            if ((number / 100) % 10 == 7)
            {
                IsSeven = true;
            }
            Console.WriteLine("The third digit is seven is {0}",IsSeven);
        }
    }

