//* Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).
using System;
using System.Linq;
namespace SelSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int[] myArr = new int[N];
            for (int i = 0; i < N; i++)
            {
                myArr[i] = int.Parse(Console.ReadLine());
            }

            foreach (var item in Split(myArr))
            {
                Console.WriteLine(item);
            }
            
        }

   public static int[] Split(int[] arr)
        {
            if (arr.Length == 1)
            {
                return arr;
            }
            int middle = arr.Length / 2;
            int[] leftArr = new int[middle];
            int[] rightArr = new int[arr.Length - middle];
            for (int i = 0; i < middle; i++)
            {
                leftArr[i] = arr[i];
            }
            for (int i = middle, j = 0; i < arr.Length; i++, j++)
            {
                rightArr[j] = arr[i];
            }
            leftArr = Split(leftArr);
            rightArr = Split(rightArr);
            return MergeSort(leftArr, rightArr);
        }

        private static int[] MergeSort(int[] leftArr, int[] rightArr)
        {
            int left = 0;
            int right = 0;
            int[] arr = new int[leftArr.Length + rightArr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (right == rightArr.Length || ((left < leftArr.Length) && (leftArr[left] <= rightArr[right])))
                {
                    arr[i] = leftArr[left];
                    left++;
                }
                else if (left == leftArr.Length || ((right < rightArr.Length) && (rightArr[right] <= leftArr[left])))
                {
                    arr[i] = rightArr[right];
                    right++;
                }
            }
            return arr;
        }

    }
}
    


 