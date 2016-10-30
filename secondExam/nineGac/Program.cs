using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace nineGac
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string onePart = string.Empty;
            string nineNumber = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                onePart += input[i];
                string currDigit = GacNineNumber(onePart);
                if (currDigit!="No")
                {
                    nineNumber += currDigit;
                    onePart = "";
                }
            }
            BigInteger decimalNumber = 0;
            for (int i = 0; i < nineNumber.Length; i++)
            {
                BigInteger digit = int.Parse(nineNumber[i].ToString());
                decimalNumber += digit * PowerNine(nineNumber.Length - i - 1);
            }
            Console.WriteLine(decimalNumber);
        }
        static string GacNineNumber(string digit)
        {
            string result = "No";
            switch (digit)
            {
                case "-!":result="0";break;
                case "**":result="1";break;
                case "!!!":result="2";break;
                case "&&":result="3";break;
                case "&-":result="4";break;
                case "!-":result="5";break;
                case "*!!!":result="6";break;
                case "&*!":result="7";break;
                case "!!**!-":result="8";break;
                default:
                    break;
            }
            return result;
        }
        static BigInteger PowerNine(BigInteger power)
        {
            BigInteger result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= 9;
            }
            return result;
        }


    }
}
