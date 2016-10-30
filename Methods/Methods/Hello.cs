//Write a method that asks the user for his name and prints  “Hello, <name>”  
// Write a program to test this method.

using System;
 public class Hello
    {
        static void Main(string[] args)
        {
            string name;
            name = PrintName();
            Console.WriteLine("Hello, {0}!", name);
        }

        private static string PrintName()
        {
            string name;
            Console.Write("Please enter your name ");
            name = Console.ReadLine();
            return name;
        }

    }

