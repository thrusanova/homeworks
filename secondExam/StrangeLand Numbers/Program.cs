using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeLand_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string partial = "";
            string sevenNum = "";
            for (int i = 0; i < input.Length; i++)
            {
                partial += input[i];
                string currDigit = GetSevenNumber(partial);
                if (currDigit!="No")
                {
                    sevenNum += currDigit;
                    partial = ""; 
                }

            }
            long decimalNumber = 0;
            for (int i = 0; i < sevenNum.Length; i++)
            {
                int digit = int.Parse(sevenNum[i].ToString());
                decimalNumber += digit * (SevenPower(sevenNum.Length - i - 1));
            }
            Console.WriteLine(decimalNumber);
        }
        static string GetSevenNumber(string digit)
        {
            string result = "No";
            switch (digit)
            {
                case "f": result = "0"; break;
                case "bIN": result = "1"; break;
                case "oBJEC": result = "2"; break;
                case "mNTRAVL": result = "3"; break;
                case "lPVKNQ": result = "4"; break;
                case "pNWE": result = "5"; break;
                case "hT": result = "6"; break;
                default:
                    break;
            }
            return result;
        }
        static long SevenPower(long power)
        {
            long result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= 7;
            }
            return result;
        }
    }
}
 