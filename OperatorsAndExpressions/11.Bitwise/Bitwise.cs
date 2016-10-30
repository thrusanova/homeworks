//Using bitwise operators, write an expression for finding the value of the bit  #3  of a given unsigned integer.
// The bits are counted from right to left, starting from bit  #0 .
// The result of the expression should be either  1  or  0 .

using System;
  class Bitwise
    {
        static void Main()
        {
            int pos = 3;
            int n = int.Parse(Console.ReadLine());//n=5=000000101
            int lastBit = (n >> pos) & 1;//00000101 >>3=00000001 & 00000001
            Console.WriteLine(lastBit);//1
        }
    }

