//Using loops write a program that converts a hexadecimal integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long.
// Do not use the built-in .NET functionality.

using System;

    class Program
    {
        static void Main()
        {
          
            string hexNumber = Console.ReadLine();
            long digit = 0;
            long decimalNum = 0;
            long degree=hexNumber.Length-1;
            for (int i = 0; i < hexNumber.Length; i++)
			{
                char ch = hexNumber[i];
                switch (ch.ToString())
                {
                    //1AE3=1*16`3+10 *16`2+14*16`1+1
                    case "A": digit = 10; break;
                    case "B": digit = 11; break;
                    case "C": digit = 12; break;
                    case "D": digit = 13; break;
                    case "E": digit = 14; break;
                    case "F": digit = 15; break;
                    default :digit=Convert.ToInt32(ch.ToString());break;
                }
                decimalNum += digit *(long)Math.Pow(16, degree);
                degree--;

			}
            Console.WriteLine(decimalNum);
            
        }
    }

