//You are given a sequence of positive integer values written into a string, separated by spaces.
// Write a function that reads these values from given string and calculates their sum.

using System;
class SumInteger
{
    static void Main()
    {
        string[] sequenceOfNumber = Console.ReadLine().Split(new char[] { '"', ' ', ',', '"' }, StringSplitOptions.RemoveEmptyEntries);

        int sum = 0;
        for (int i = 0; i < sequenceOfNumber.Length; i++)
        {
            int number = int.Parse(sequenceOfNumber[i].ToString());
            sum += number;
        }
        Console.WriteLine(sum);
    }
}

