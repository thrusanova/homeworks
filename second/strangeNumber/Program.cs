using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strangeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string strNumber = Console.ReadLine();
            string sevenNums = string.Empty;
            string partial = string.Empty;
            for (int i = 0; i < strNumber.Length; i++)
            {
                partial += strNumber[i];
                string currDigit = GetSevenNum(partial);
                if (currDigit!="No")
                {
                    sevenNums += currDigit;
                    partial = "";
                }
            }
            long decimalNumber = 0;
            for (int i = 0; i < sevenNums.Length; i++)
            {
                int digit = int.Parse(sevenNums[i].ToString());
                decimalNumber += digit * (GetPower(sevenNums.Length - i - 1));
            }
            Console.WriteLine(decimalNumber);

        }

        private static string GetSevenNum(string digit)
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
            }
            return result;
        }
        static long GetPower(long power)
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
