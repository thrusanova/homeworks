//Write a program that reads two arrays from the console and compares them element by element.
using System;
    class CompareArrays
    {
        static void Main()
        {
            
            int n = int.Parse(Console.ReadLine());
            
            int[] firstArray = new int[n];
        int[] secondArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }
        var isEqual = true;

        Array.Sort(firstArray);
        Array.Sort(secondArray);
            for (int i = 0; i < n; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    isEqual = false;
                    
                }
                else
                {
                    isEqual = true;
                }
            }
            if (isEqual == false)
            {
                Console.WriteLine("Not equal");

            }
            else
            {
                Console.WriteLine("Equal");
            }
        }

    }

