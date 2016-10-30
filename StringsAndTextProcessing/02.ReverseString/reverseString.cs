//Write a program that reads a string, reverses it and prints the result at the console.

using System;
    class ReverseString
    {
        static void Main()
        {
            Console.Write("Enter a string to reverse:");
            string sequence = Console.ReadLine();
            Console.Write
                ("The reversed string is:");
            for (int i = sequence.Length-1; i >= 0; i--)
            {
                Console.Write(sequence[i]);
            }
            Console.WriteLine();

        }
    }

