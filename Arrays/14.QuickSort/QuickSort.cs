//﻿// Write a program that sorts an array of strings using the quick sort algorithm.
using System;

    class QuickSort
    {
        static void Main()
        {
        int N = int.Parse(Console.ReadLine());
        int[] myArr = new int[N];
        for (int i = 0; i < N; i++)
        {
            myArr[i] = int.Parse(Console.ReadLine());
        }


        Quicksort(myArr, 0, myArr.Length - 1);
 
            // Print the sorted array
            for (int i = 0; i < myArr.Length; i++)
            {
                Console.WriteLine(myArr[i]);
            }
 
         
        }
 
        public static void Quicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];
 
            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }
 
                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }
 
                if (i <= j)
                {                   
                    var tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;
 
                    i++;
                    j--;
                }
            }
            if (left < j)
            {
                Quicksort(elements, left, j);
            }
 
            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
 
    }



