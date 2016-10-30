//Write a method that reverses the digits of given decimal number.
//example:256>>652
using System;
class ReverseNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int revNumber = Reverse(number);
        Console.WriteLine(revNumber);
    }

    static int Reverse(int num1)
    {
        string num = string.Empty;
        if (num1 < 0)
        {
            num += "-";
            num1 *= -1;
        }
        while (num1 != 0)
        {
            int digit = num1 % 10;
            num += digit;
            num1 /= 10;
        }
        num1 = int.Parse(num);
        return num1;
    }

}

