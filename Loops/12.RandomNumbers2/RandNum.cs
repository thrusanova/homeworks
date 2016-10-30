//Write a program that enters in integer  n  and prints the numbers  1, 2, …, n  in random order
using System;
class RandomNum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = i ;
        }
        Random random = new Random();      
            for (int i = 0; i < n; i++)
            {
                int randNum = random.Next(0,n);
                int temp = array[i];
                array[i] = array[randNum];
                array[randNum] = temp;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i]+1 +" ");
            }
            Console.WriteLine();
    }
}