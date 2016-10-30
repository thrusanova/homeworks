//Write a Boolean expression that returns if the bit at position  p  (counting from  0 , starting from the right) in given integer number  n , has value of 1.
using System;
class CheckBitGivenPosition
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        bool isOne = false;
        if (((number >> position) & 1) == 1)
        {
            isOne = true;
        }
        Console.WriteLine(isOne);
    }
}

