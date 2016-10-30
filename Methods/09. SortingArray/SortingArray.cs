//Write a method that return the maximal element in a portion of array of integers starting at given index.  
 //Using it write another method that sorts an array in ascending / descending order. 

using System;

    class SortingArray
    {

            static void Main(string[] args)
        {
            Console.Write("Enter the lenght if the array:");
            int n = int.Parse(Console.ReadLine());
            int[] myArr = new int[n];
            Console.WriteLine("Enter elements of the array:");
            for (int i = 0; i < n; i++)
            {
                myArr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the index of the element in starting position:");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Max element in the current portion is {0}",MaxElement(myArr,index));
            Console.Write("Type true for sorting the array ascending or false for descending sort:"); 
            bool ascending = bool.Parse(Console.ReadLine()); 
            SelectionSort(myArr, ascending);
            PrintArr(myArr);
        }
            static int MaxElement(int[] array, int index)
            {
                int maxIndex = index;
                for (int i = maxIndex; i < array.Length; i++)
                {
                    if (array[maxIndex]<array[i])
                    {
                        maxIndex = i;
                    }
                }
                return array[maxIndex];
            }
            static void PrintArr(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]+" ");
                }
                Console.WriteLine();
            }
            static void SelectionSort(int[] array, bool ascending)
            {
                int temp = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i+1; j < array.Length; j++)
                    {
                        if (array[i]>array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
                if (ascending == false)
                {
                    Array.Reverse(array);
                }
           
            }
    }

