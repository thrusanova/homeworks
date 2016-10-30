//Write a program that reads 3 numbers: ◦ integer  a  (0 <= a <= 500)
// floating-point  b  
//floating-point  c  

//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. ◦ The number  a  should be printed in hexadecimal, left aligned
// Then the number  a  should be printed in binary form, padded with zeroes
// The number  b  should be printed with 2 digits after the decimal point, right aligned
// The number c should be printed with 3 digits after the decimal point, left aligned.

using System;
  class FormattingNumbers
    {
        static void Main()
        {
            Console.Write("Enter a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter c = ");
            float c = float.Parse(Console.ReadLine());
            Console.Write("|{0, -10:X}|", a);
            Console.Write(Convert.ToString(a, 2).PadLeft(10, '0'));
            bool dotCheckB = Convert.ToString(b).IndexOf(".") > 0;
            Console.Write(dotCheckB ? "|{0,10:0.00}" : "|{0,10}", b);
            bool dotCheckC = Convert.ToString(c).IndexOf(".") > 0;
            Console.WriteLine(dotCheckC ? "|{0,-10:0.000}|" : "|{0,10}|", c);
        }
    }
