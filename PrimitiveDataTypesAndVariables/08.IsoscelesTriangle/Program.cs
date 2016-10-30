//Write a program that prints an isosceles triangle of 9 copyright symbols  © 
using System;
  class Program
    {
        static void Main()
        {
            char symbol = '\u00A9';
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("   "+symbol);
            Console.WriteLine("  "+symbol+ " "+symbol);
            Console.WriteLine(" "+symbol+"   " +symbol);
            Console.WriteLine(symbol+" "+symbol+ " "+symbol+" "+symbol);
        }
    }

