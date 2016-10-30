//Write a program to convert decimal numbers to their hexadecimal representation.
using System;
using System.Collections.Generic;
    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> hexNumber = new List<string>();
            while (number > 0)
            {
                switch (number%16)
                {
                    case 10: hexNumber.Add("A"); break;                       
                    case 11: hexNumber.Add("B"); break;
                    case 12: hexNumber.Add("C"); break;
                    case 13: hexNumber.Add("D"); break;
                    case 14: hexNumber.Add("E"); break;
                    case 15: hexNumber.Add("F"); break;
                    default: hexNumber.Add((number % 16).ToString());
                        break;
                }
                
                number /= 16;
            }
            hexNumber.Reverse();
            Console.WriteLine("The hexadecimal represantation of the number is :");
            for (int i = 0; i < hexNumber.Count; i++)
            {
                Console.Write(hexNumber[i]);
            }
            Console.WriteLine();
        }
    }

