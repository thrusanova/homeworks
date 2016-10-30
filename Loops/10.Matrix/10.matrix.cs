//Write a program that reads from the console a positive integer number  n  (1 = n = 20) and
//prints a matrix like in the examples below. Use two nested loops
using System;

    class Matrix
    {
        static void Main()
        {
           
            int n = int.Parse(Console.ReadLine());
        
        if (n <= 20)
            {
                for (int i = 0; i <= n - 1; i++)
                {
                    for (int j = 1 + i; j <= n + i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
          
        }
 }
    
