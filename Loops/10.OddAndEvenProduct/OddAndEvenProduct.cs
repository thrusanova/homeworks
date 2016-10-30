// You are given  n  integers (given in a single line, separated by a space).
// Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
// Elements are counted from  1  to  n , so the first element is odd, the second is even, etc.

using System;
    class Program
    {
        static void Main()
        {
        int number = int.Parse(Console.ReadLine());
            string[] numbers=Console.ReadLine().Split(' ');
            long oddProduct = 1;
            long EvenProduct = 1;
            for (int i = 0; i < numbers.Length; i+=2)
            {
                oddProduct *= Convert.ToInt32(numbers[i]);
            }
            for (int i = 1; i < numbers.Length; i+=2)
            {
                EvenProduct *= Convert.ToInt32(numbers[i]);
            }
            if (oddProduct==EvenProduct)
            {
               
                Console.WriteLine("yes {0}",EvenProduct);
            }
            else
            {
            Console.WriteLine("no {0} {1}", oddProduct, EvenProduct);
              
                
            }
        }
    }

