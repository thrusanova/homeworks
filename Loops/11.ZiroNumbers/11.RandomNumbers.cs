// Write a program that enters  integers  n ,  min  and  max  ( min != max ) and prints  n  random numbers in the range  [min...max] .
using System;

    class RandomNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.Write(rand.Next(min,max+1));
                Console.Write(" ");
            }
            Console.WriteLine();
        }

    }


