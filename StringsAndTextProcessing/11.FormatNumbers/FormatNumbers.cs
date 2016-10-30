//• Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FormatNumbers
{
    class FormatNumbers
    {
        static void Main()
        {
             Console.Write("Enter a number: ");
             string input = Console.ReadLine();
             int number = int.Parse(input);
             Console.WriteLine("{0,15}", number);
             Console.WriteLine("{0,15:X}", number);
             Console.WriteLine("{0,15:P}", number + "%");
             Console.WriteLine("{0,15:E}", number); 

        }
    }
}
