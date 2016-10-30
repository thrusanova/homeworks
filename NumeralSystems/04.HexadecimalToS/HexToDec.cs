//Write a program to convert hexadecimal numbers to their decimal representation.
using System;
using System.Collections.Generic;

class HexToDec
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int number = 0;
            switch (arr[i])
            {
                case 'A': number = 10;
                    break;
                case 'B': number = 11;
                    break;
                case 'C': number = 12;
                    break;
                case 'D': number = 13;
                    break;
                case 'E': number = 14;
                    break;
                case 'F': number = 15;
                    break;
                default: number = int.Parse(arr[i].ToString());
                    break;
            }
           
            for (int j = 0; j < i; j++)
            {
                number *= 16;
            }
            sum += number;
        }
        Console.WriteLine(sum);
    }
}

