//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
using System;
    class LargerThanNeighbours
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
            Console.Write("Enter the position to check: ");
            int position = int.Parse(Console.ReadLine());
            if (position < 0 || position > input.Length) throw new Exception("Wrong position!");

            CheckNeighbours(arr, position);
        }
        static void CheckNeighbours(int[] arr, int position)
        {
            if (position==0)
            {
                Console.WriteLine("it is the first position in the array");
                return;
            }
           
            if (position == arr.Length - 1)
            {
                
                Console.WriteLine("it is last element");
                return;
               
            }
            if (arr[position] > arr[position - 1] && arr[position] > arr[position + 1])
            {
                Console.WriteLine("bigger then neibours");
                return;
            }
            if (arr[position] < arr[position - 1] && arr[position] < arr[position + 1])
            {
                Console.WriteLine("smaller then neibors");
                return;
            }
            else Console.WriteLine("equal to the neibours");
            return;

        }
    }

