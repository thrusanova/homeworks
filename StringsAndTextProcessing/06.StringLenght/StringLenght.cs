﻿//Write a program that reads from the console a string of maximum  20  characters. If the length of the string is less than  20 ,
//the rest of the characters should be filled with  * .
//Print the result string into the console.

using System;
  class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            if (text.Length>20)
            {
                text = text.Substring(0,19)+new string('*', text.Length - 20);

            }
            Console.WriteLine(text);
        }
    }

