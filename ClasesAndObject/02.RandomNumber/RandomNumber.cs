//Write a program that generates and prints to the console  10  random values in the range [ 100, 200 ].
using System;

    class RandomNumber
    {
        static void Main()
        {
            Random range = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ",range.Next(100,200)); 
            }
            Console.WriteLine();
        }
    }
