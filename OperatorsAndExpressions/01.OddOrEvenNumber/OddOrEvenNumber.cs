//Write an expression that checks if given integer is odd or even.
using System;
    class OddOrEvenNumber
    {
        static void Main()
        {
            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            bool isOdd = true;
            if (number % 2 == 0)
            {
                isOdd = false;
            }
            Console.WriteLine("Is the number odd?:{0}",isOdd);

        }
    }
