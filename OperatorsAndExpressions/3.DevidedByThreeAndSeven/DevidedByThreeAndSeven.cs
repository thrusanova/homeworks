//Write an expression that checks for given integer if its third digit from right-to-left is  7 
using System;
class DevidedByThreeAndSeven
{
    static void Main()
    {
        Console.Write("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        bool isDevider = true;
        if (number % 35 != 0)
        {

            isDevider = false;
        }
       Console.WriteLine("Is the number devided by 35? {0}",isDevider);
    }
}


        