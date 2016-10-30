﻿//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   class Program
    {
        static void Main()
        {
            Console.Write("Enter a number in a decimal binary system:");
            int number = int.Parse(Console.ReadLine());
            List<int> binaryNumber = new List<int>();
            StringBuilder strBin = new StringBuilder();
            if (number>0)
            {
                while (number>0)
                {
                    binaryNumber.Add(number % 2);
                    number /= 2;
                }
                while (binaryNumber.Count %16!=0)
                {
                    binaryNumber.Add(0);
                }
                binaryNumber.Reverse();
                Console.WriteLine("The binary representation of the number is:");
                for (int i = 0; i < binaryNumber.Count; i++)
                {
                    strBin.Append(binaryNumber[i]);
                }
                Console.WriteLine(strBin);
            }
            else
            {
                number = Math.Abs(number) - 1;
                while (number>0)
                {
                    binaryNumber.Add(number % 2);
                    number /= 2;
                }
                while (binaryNumber.Count%16!=0)
                {
                    binaryNumber.Add(0);
                }
                binaryNumber.Reverse();
                for (int i = 0; i < binaryNumber.Count; i++)
                {
                    if (binaryNumber[i]==0)
                    {
                        strBin.Append(1); 
                    }
                    else
                    {
                        strBin.Append(0);
                    }
                }
                Console.WriteLine(strBin);
            }
        }
    }


