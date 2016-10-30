//﻿//Write a program that reverses the words in given sentence. 
 //Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!". 

using System;

    class ReversedSentence
    {
        static void Main()
        {
            string sentence = "C# is not C++, not PHP and not Delphi!";
            string[] words = sentence.Split(new char[] { ' ', '!', ',', '.', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i]+ " ");
            }
            Console.Write("!");
            Console.WriteLine();

        }
    }
