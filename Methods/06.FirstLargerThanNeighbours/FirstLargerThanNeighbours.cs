//Write a method that returns the index of the first element in array that is larger than its neighbours, or  -1 , if there’s no such element.
// Use the method from the previous exercise

using System;

    class FirstLargerThanNeighbours
    {
        static void Main()
        {
            Console.Write("Enter an array with random lenght: ");
            string inputArray = Console.ReadLine();
            char[] delimiter = new char[] { ',', ' ' };
            string[] input = inputArray.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = int.Parse(input[i]);
            }
            int result = CheckAllNeighbors(arr);
            if (result != 1)
            {
                Console.WriteLine("The index of the first larger element is {0} and the element is {1}", result,arr[result]);
            }
            else
            {
                Console.WriteLine("No such element");
            }
        }
            static bool CheckNeighbour(int[]arr,int index)
            {
                if (arr[index] > arr[index - 1] && arr[index] > arr[index + 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
	
            }
            static int CheckAllNeighbors(int[] array)
            {
                for (int i = 1; i < array.Length - 1; i++)
                {
                    if (CheckNeighbour(array, i)) return i;
                }
                return -1;
            }

            }

  

