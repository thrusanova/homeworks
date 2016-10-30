//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
// Do not use the built-in .NET functionality.

using System;
class DecimalToHex
    {
        static void Main()
        {
           
            long decimalNumber = long.Parse(Console.ReadLine());
            string hexNumber = "";
            
            while (decimalNumber > 0)
            {
                long num = decimalNumber % 16;
                if (num < 10)
                {
                    hexNumber += num;
                }
                else
                {
                    switch (num)
                    {
                        case 10: hexNumber += "A"; break;
                        case 11: hexNumber += "B"; break;
                        case 12: hexNumber += "C"; break;
                        case 13: hexNumber += "D"; break;
                        case 14: hexNumber += "E"; break;
                        case 15: hexNumber += "F"; break;
                        default:
                            break;
                    }
                }
                decimalNumber /= 16;
            }
                
                string hexNum = string.Empty;
                for (int i = hexNumber.Length-1; i >=0 ; i--)
                {
                    hexNum += hexNumber[i];
                }
                Console.WriteLine(hexNum);
        }
    }
