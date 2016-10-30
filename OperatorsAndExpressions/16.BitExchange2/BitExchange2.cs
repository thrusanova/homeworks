//Write a program that exchanges bits  {p, p+1, …, p+k-1}  with bits  {q, q+1, …, q+k-1}  of a given 32-bit unsigned integer.
// The first and the second sequence of bits may not overlap.

using System;

    class BitsExchange2
    {
        static void Main()
        {
             long n = long.Parse(Console.ReadLine());
             int p = int.Parse(Console.ReadLine());
             int q = int.Parse(Console.ReadLine());
             int k = int.Parse(Console.ReadLine());
             for (int i = p; i <= p + k - 1; i++)
            {
                int mask = 1;
                long firstBits = (n & (mask << i)) >> i;
                long secondBits = (n & (mask << q)) >> q;
                n = n & ~(mask << i);
                n = n & ~(mask << q);
                n = n | (firstBits << q);
                n = n | (secondBits << i);
                q++;
            }
                    if (p + k - 1 == q + k - 1)
                    {
                        Console.WriteLine("overlapping");
                    }
                    else if ((p + k - 1 > 31) | (q + k - 1 > 31))
                    {
                        Console.WriteLine("out of range");
                    }
                    else
                    {
                        Console.WriteLine(n);
                    }
            }
            
        }