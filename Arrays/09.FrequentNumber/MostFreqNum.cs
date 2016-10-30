//Write a program that finds the most frequent number in an array. Example:
	//{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
using System;
class MostFreqNum
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
       
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());

        }    
        int mostFreqNumber = 0;
        int count =0;
        int maxCount = 0;
        Array.Sort(array);
        for (int i =0; i < array.Length-1; i++)
        {
            if (array[i] == array[i + 1])
            {
                count++;

                if (count > maxCount)
                {
                    maxCount = count;
                    mostFreqNumber = array[i];
                }
            }
            else
            {
                count = 0;
            }
        }
        Console.WriteLine("{0} ({1} times)", mostFreqNumber,maxCount + 1);    
   } 
}
