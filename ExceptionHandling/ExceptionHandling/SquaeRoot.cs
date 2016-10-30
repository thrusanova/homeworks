//Write a program that reads an integer number and calculates and prints its square root. 
//◦ If the number is invalid or negative, print  Invalid number .
//◦ In all cases finally print  Good bye .
//Use  try-catch-finally  block.

﻿using System; 
 class HandlingExceptions 
 { 
    static void Main()
     {
         Console.Write("Enter an integer:");

        string s = Console.ReadLine(); 
         try 
     {
             double root=Math.Sqrt(Int32.Parse(s));
            Console.WriteLine("The root ot the number is {0}.", root); 
        } 
         catch (FormatException) 
         { 
             Console.WriteLine("Invalid integer number!"); 
        } 
        catch (OverflowException) 
         { 
             Console.WriteLine("The number is too big to fit in Int32!"); 
         } 
    } 
 } 
