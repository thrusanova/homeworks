//Write a program to convert from any numeral system of given base  s  to any other numeral system of base  d  (2 ≤  s ,  d  ≤ 16).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ConvertToAny
{
    static void Main()
    {
        Console.WriteLine("Please enter numeral base from which you want to convert: ");
        int s = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the  number you want to convert:");
        string number = Console.ReadLine();
        Console.WriteLine("Please enter numeral base to which you want to convert");
        int d = int.Parse(Console.ReadLine());
        if (s < 2 || d < 2 || s > 16 || d > 16)
        {
            Console.WriteLine("you are out of range ");
        }
        else
        {
            ConvertFromDec(ConvertToDec(number, s), d);
        }
    }
    static int ConvertToDec(string number, int baseFrom)
    {
        int decNum = 0;
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] > '9')
            {
                decNum += (number[i] - '7') * (int)Math.Pow(baseFrom, (number.Length - 1 - i));
            }
            else
            {
                decNum += (number[i] - '0') * (int)Math.Pow(baseFrom, (number.Length - 1 - i));
            }
        }
        return decNum;
    }
    static void ConvertFromDec(int number, int baseTo)
    {
        List<int> result = new List<int>();
        if (baseTo > 10)
        {
            while (number > 0)
            {
                result.Add(number % baseTo);
                number = number / baseTo;
            }
            result.Reverse();
            foreach (var item in result)
            {
                switch (item)
                {
                    case 10: Console.Write("A");
                        break;
                    case 11: Console.Write("B");
                        break;
                    case 12: Console.Write("C");
                        break;
                    case 13: Console.Write("D");
                        break;
                    case 14: Console.Write("E");
                        break;
                    case 15: Console.Write("F");
                        break;
                    default: Console.Write(item);
                        break;
                }
            }
            Console.WriteLine();
        }
        else
        {
            while (number > 0)
            {
                result.Add(number % baseTo);
                number = number / baseTo;
            }
            result.Reverse();
            foreach (var item in result)
            {
                Console.Write("The converted number is {0}",item);
            }
            Console.WriteLine();
        }
    }
}

      