//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).

using System;
   class BynarySearch
    {
        static void Main()
        {
           
            int N = int.Parse(Console.ReadLine());
            int[] myArr = new int[N];
            for (int i = 0; i < N; i++)
            {
                myArr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(myArr);

            int number = int.Parse(Console.ReadLine());
        BinSearch(myArr, 0,myArr.Length,number);
        
        }
    static void BinSearch(int[] arr, int start, int end, int element)
    {

        int middle = start + (end - start) / 2;
        if (element < arr[middle])
        {
            BinSearch(arr, start, middle - 1, element);
        }
        else if (element > arr[middle])
        {
            BinSearch(arr, middle + 1, end, element);
        }
        else
        {
            Console.WriteLine(middle);
            return;
        }

    }

    }