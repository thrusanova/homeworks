//Using loops write a program that converts a binary integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long.
// Do not use the built-in .NET functionality.

using System;
   class BinaryToDecimal
    {
        static void Main()
       {
           string binaryNumber = Console.ReadLine();
           long decimalNumber=0;
           
           
           for (int i =0; i<binaryNumber.Length ; i++)
           {
               if (binaryNumber[i]=='1')
               {
               double    degree = binaryNumber.Length - 1 - i;
                   decimalNumber =decimalNumber + (long)Math.Pow(2, degree); 


               }
           }
           Console.WriteLine(decimalNumber);
            
        }
    }

