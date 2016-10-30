//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
//Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;
using System.Linq;

class FallDownArr
{
    static void Main()
    {
        int [] myArray = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        Console.WriteLine();     
        int temp = 0;
        for (int i = 0; i < myArray.Length - 1; i++)
        {
            for (int j = i+1; j < myArray.Length; j++)
            {
                if (myArray[j] < myArray[i])
                {
                    temp = myArray[i];
                    myArray[i] = myArray[j];
                    myArray[j] = temp;
                } 
            }
        }
        Console.WriteLine("The elements of array in increasing order: ");
        for (int i =0 ; i <myArray.Length; i++)
        {
            Console.Write(myArray[i]+" ");
        }
        Console.WriteLine();
    }
}
