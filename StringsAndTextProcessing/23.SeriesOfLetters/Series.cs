//Write a program that reads a string from the console and replaces all 
//series of consecutive identical letters with a single one.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.SeriesOfLetters
{
    class Series
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            result.Append(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i]!=input[i-1])
                {
                    result.Append(input[i]);
                }
            }
            Console.WriteLine(result);
                    
        }
    }
}
