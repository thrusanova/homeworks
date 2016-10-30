//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array
using System;
class AlphabethArray
{
    static void Main(string[] args)
    {
        char[] array = new char[26];
        
        for (int i = 0; i < 26; i++)
        {
            array[i] = (char)('a' + i);
        }
        string word = Console.ReadLine();
        foreach (char item in word)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (item==array[i])
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
   

}


