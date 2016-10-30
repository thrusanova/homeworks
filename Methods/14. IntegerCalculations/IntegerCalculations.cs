//• Write methods to calculate  minimum ,  maximum ,  average ,  sum  and  product  of given set of integer numbers.
// Use variable number of arguments.

using System;
 class IntegerCalculations
    {
        static void Main()
        {
            Console.Write("Enter random integer numbers with intervals: ");
            string inputArray = Console.ReadLine();
            char[] delimiter = new char[] { ',', ' ' };
            string[] input = inputArray.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }
            Minimum(array);
            Maximum(array);
            Average(array);
            Sum(array);
            Product(array);
        }
        static void Maximum(int[] array)
        {
            int maxNumber = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>maxNumber)
                {
                    maxNumber = array[i];
                }
            }
            Console.WriteLine("The maximal element in the sequence is: {0}.", maxNumber);
        }
        static void Minimum(int[] array)
        {
            int minNumber = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minNumber)
                {
                    minNumber = array[i];
                }
            }
            Console.WriteLine("The minimal element in the sequence is: {0}.", minNumber);
        }
        static void Average(int[] array)
        {
            double sum = 0;
            double average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            average = sum / array.Length;
            Console.WriteLine("The average value in the sequence is {0}",average);
        }
        static void Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("The sum of all element in the sequence is {0}",sum);
        }
        static void Product(int[] array)
        {
            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            Console.WriteLine("The product of all element in the sequence is {0}", product);
        }

    }

