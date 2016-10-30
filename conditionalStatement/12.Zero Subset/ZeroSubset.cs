//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
// Assume that repeating the same subset several times is not a problem.
//Вади само първата сума равна на 0.А не всички.
using System;
class ZeroSubset
{
    static void Main()
    {
        string[] num = Console.ReadLine().Split(' ');
        int[] number = new int[num.Length];
        for (int i = 0; i < 5; i++)
        {
            number[i] = Convert.ToInt32(num[i]);
        }
        bool isZero = false;
        int sum;
        for (int i = 0; i < 5; i++)
        {
            for (int j = i; j < 5; j++)
            {
                 sum = 0;
                sum += number[j];
                if (sum == 0)
                {
                    isZero = true;

                    for (int k = i; k < j; k++)
                    {
                        Console.Write("{0} + ", number[k]);
                    }
                    Console.Write(number[j]);
                    Console.Write(" = 0\n\n");
                }
                
                }
            }
        if (isZero == false)
        {
            Console.WriteLine("no zero subset");
        }
    }
}