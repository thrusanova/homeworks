//Write a method  GetMax()  with two parameters that returns the larger of two integers.
// Write a program that reads  3  integers from the console and prints the largest of them using the method  GetMax() .

using System;

    class GetLargestNumber
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(GetMax(x,y),z));
        }
      private  static int GetMax(int x, int y)
        {
            if (x>y)
            {
                return x;
            }
            else
            {
                return y;
            }

        }
    }

