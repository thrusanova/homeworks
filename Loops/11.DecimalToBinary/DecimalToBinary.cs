//Using loops write a program that converts an integer number to its binary representation.
// The input is entered as long. The output should be a variable of type string.
// Do not use the built-in .NET functionality.

using System;
    class DecimalToBinary
    {
        static void Main()
       {
        
            long n = long.Parse(Console.ReadLine());
            string binary = "";
            while (n != 0)
            {
                int remain = (int)n % 2;
                n /= 2;
                binary = remain + binary;
            }
            Console.WriteLine(binary);
             


        }

    }



