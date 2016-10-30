//Write a program, that reads from the console an array of  N  integers and an integer  K ,
//sorts the array and using the method  Array.BinSearch()  finds the largest number in the array which is ≤  K . 
using System;

    class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the array N=");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter number K=");
            int K = int.Parse(Console.ReadLine());
            int [] array=new int[N];
            Console.WriteLine("Enter the elements of the array");
            for (int i = 0; i < array.Length; i++)
			{
			 array[i]=int.Parse(Console.ReadLine());
			}
            Array.Sort(array);
            if (array[0]>K)
            {
                Console.WriteLine("There is no elemens smaller than K in the array");
            }
            else
            { 
                int largestElement = 0;
                int index = Array.BinarySearch(array, K);
                if (index>=0)
                {
                    largestElement = array[index];
                }
                else
                {
                    largestElement = array[~index - 1];
                }
                Console.WriteLine("The largest element in the array smaller  than  or equal to K is {0}",largestElement);
            }
        }
    }

