//Write a program to convert binary numbers to hexadecimal numbers (directly).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class BinToHex
    {
        static void Main()
        {
            string binNum = Console.ReadLine();
            StringBuilder str = new StringBuilder();
            for (int i = 4; i < 32; i *= 4)
            {
                if (binNum.Length < i)
                {
                    string leadingZeros = new String('0', i - binNum.Length);
                    binNum = leadingZeros + binNum;
                    break;
                }
            }

            for (int i = 0; i < binNum.Length; i+=4)
            {
                switch (binNum.Substring(i,4))
                {
                    case "0001": str.Append("1"); break;
                    case "0010": str.Append("2"); break;
                    case "0011": str.Append("3"); break;
                    case "0100": str.Append("4"); break;
                    case "0101": str.Append("5"); break;
                    case "0110": str.Append("6"); break;
                    case "0111": str.Append("7"); break;
                    case "1000": str.Append("8"); break;
                    case "1001": str.Append("9"); break;
                    case "1010": str.Append("A"); break;
                    case "1011": str.Append("B"); break;
                    case "1100": str.Append("C"); break;
                    case "1101": str.Append("D"); break;
                    case "1110": str.Append("E"); break;
                    case "1111": str.Append("F"); break;
                }
                
            }
            Console.WriteLine(str.ToString());
        }
    }

