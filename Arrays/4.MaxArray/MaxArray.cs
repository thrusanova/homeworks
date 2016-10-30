//Write a program that finds the maximal sequence of equal elements in an array.
using System;

class MaxSequenceInArray
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int[] Array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Array[i] = int.Parse(Console.ReadLine());
            
        }       
       int currentCount = 1;
       int bestLenght = 0;
       int bestElem = 0;
       for (int i = 0; i < Array.Length-1; i++)
       {
           if (Array[i] == Array[i + 1])
           {
               currentCount++;
           }
           else
           {
               if (currentCount > bestLenght)
               {
                   bestLenght = currentCount;
                   bestElem = Array[i];
               }
               currentCount = 1;
           }
         }

       if (currentCount > bestLenght)
       {
           bestLenght = currentCount;
           bestElem = Array[Array.Length - 1];
       }

       Console.WriteLine(bestLenght);

       }
    }
