using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second
{
    class strangeNum

    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string currNum = "";
            string partial = "";
            long decimalNum=0;
            for (int i = 0; i < input.Length; i++)
            {
                partial += input[i];
                string currDigit = SevenNumber(partial);
                if (currDigit!="No")
                {
                    currNum += currDigit;
                    partial = "";
                }
            }
            for (int i = 0; i < currNum.Length; i++)
            {
                int digit = int.Parse(currNum[i].ToString());
                decimalNum += digit * (GetPow(currNum.Length - i - 1));
            }
            Console.WriteLine(decimalNum);

        }
        static string SevenNumber(string digits)
        {
            string result = "No";
            switch (digits)
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
            static long GetPow(long number)
            {
                long result=1;
                for (int i = 0; i < number; i++)
			{
                result *= 7;
			}
                return result;
            }
    }
}
