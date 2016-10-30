//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:
//The target sub-string is  in 
//The text is as follows: We are living in an yellow submarine. We don't have anything else.
//inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The result is:  9 

using System;
   class SubString
    {
        static void Main()
        {
            Console.Write("Enter a text:");
            string text = Console.ReadLine();
            Console.Write("Enter a word to search:");
            string word = Console.ReadLine();
             int count = 0; 
        for (int i = 0; i < text.Length - 1; i++) 
        { 
           if (text.Substring(i, word.Length).ToLower() == word) 
            { 
                 count++; 
                i += word.Length; 
             } 
        } 
         Console.WriteLine("The result is:{0}",count); 
     } 
 } 

 