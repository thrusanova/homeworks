﻿//Write a program that reads a number  n  and prints on the console the first  n  members of the Fibonacci sequence 
//(at a single line, separated by comma and space -  , ) :  0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … .
using System;
    class FibonacciNumbers
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long a = 0;
        long b = 1;
            long c;
            if (n>=3)
            {
                Console.Write(a + ", " + b +", ");
                for (int i = 0; i < n-2;i++)
                {
                    c = a;
                    a = b;
                    b = c + a;
                if (i<n-3)
                {
                    Console.Write(b + ", ");
                }
                else
                {
                    Console.WriteLine(b);
                }
                    
                }
                Console.WriteLine();
            }
            else if (n==1)
            {
                Console.WriteLine(a);
            }
            else if (n==2)
            {
                Console.Write(a + ", " + b);
            }
        else if (n==0)
        {
            Console.WriteLine(a);
        }
            Console.WriteLine();
        }
    }

