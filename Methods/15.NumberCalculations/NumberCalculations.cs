//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
// Use generic method (read in Internet about generic methods in C#).

using System;
class IntegerCalculations
{
    static void Main()
    {
        Console.Write("Enter random integer numbers with intervals: ");
        string inputArray = Console.ReadLine();
        char[] delimiter = new char[] { ',', ' ' };
        string[] input = inputArray.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
        float[] array = new float[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            array[i] = float.Parse(input[i]);
        }
        Console.WriteLine("The minimal element in the sequence is: {0}.", Minimum(array));
        Console.WriteLine("The maximal element in the sequence is: {0}.", Maximum(array));
        Console.WriteLine("The average value in the sequence is {0}",Average(array));
        Console.WriteLine("The sum of all element in the sequence is {0}", Sum(array));
        Console.WriteLine("The product of all element in the sequence is {0}", Product(array));
    }
    static T Maximum<T>(params T[] array)
    {
        dynamic maxNumber = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxNumber)
            {
                maxNumber = array[i];
            }
        }
        return maxNumber;
    }
    static T Minimum<T>(params T[] array)
    {
        dynamic minNumber = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minNumber)
            {
                minNumber = array[i];
            }
        }
        return minNumber;
    }
    static T Average<T>(params T[] array)
    {
        dynamic sum = 0;
        dynamic average = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        average = sum / array.Length;
        return average;
    }
    static T Sum<T>(params T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
    static T Product<T>(params T[] array)
    {
        dynamic product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }

}

