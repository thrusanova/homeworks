// Write a program that finds all prime numbers in the range [ 1...10 000 000 ]. Use the Sieve of Eratosthenes algorithm.
using System;

class PrimeNumber
{
    static void Main()
    {
        long sum = 0;
        long n = long.Parse(Console.ReadLine());
     //   long n = 10000000;

        bool[] e = new bool[n];//by default they're all false

        for (int i = 2; i < n; i++)
        {

            e[i] = true;//set all numbers to true

        }

        //weed out the non primes by finding mutiples 

        for (int j = 2; j < n; j++)
        {

            if (e[j])//is true
            {

                for (long p = 2; (p * j) < n; p++)
                {

                    e[p * j] = false;

                }

            }

        }
        for (long i = n; i >1;  i--)
        {
            if (e[i])
            {
                Console.WriteLine(i);
                break;
            }
        }

    }
}

    

