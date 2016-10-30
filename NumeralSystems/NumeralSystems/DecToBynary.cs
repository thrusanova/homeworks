//• Write a program to convert decimal numbers to their binary representation
using System;
using System.Collections.Generic;
   class DecToBinary
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<int> binaryNumber = new List<int>();
            while (number>0)
            {
                binaryNumber.Add(number % 2);
                number /= 2;
            }
            binaryNumber.Reverse();
            Console.WriteLine("The binary represantation of the number is :");
            for (int i = 0; i < binaryNumber.Count; i++)
            {
                Console.Write(binaryNumber[i]+ " ");
            }
            Console.WriteLine();   
        }
    }

