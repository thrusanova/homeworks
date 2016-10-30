//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;
class appearanceCount
{
    static void Main()
        {
            Console.Write("Enter random array: ");
            string inputArray = Console.ReadLine();
            char[] delimiter = new char[] { ',', ' ' };
            string[] input = inputArray.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[input.Length];
           
            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = int.Parse(input[i]);
            }
            Console.Write("Enter the number we are looking for: ");
                   int numToSearch = int.Parse(Console.ReadLine());

            Console.WriteLine("Found {0} times", CheckNum(arr, numToSearch));
    }

           static int CheckNum(int[] arr, int num)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    count++;
                }
            }
               
            return count;
        }

}

