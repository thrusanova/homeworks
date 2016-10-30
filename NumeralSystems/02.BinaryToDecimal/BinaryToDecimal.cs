//• Write a program to convert binary numbers to their decimal representation.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            string binNumber=Console.ReadLine();
            
            int sum = 0;
            
                for (int j = 0 ; j < binNumber.Length ; j++)
                {
                    int number = int.Parse(binNumber[j].ToString());
                    number = number * (int)Math.Pow(2, binNumber.Length-(j+1));
                    sum += number;
                }
            Console.WriteLine(sum);


        }
    }
