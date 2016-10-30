//Write a method that adds two positive integer numbers represented as arrays of digits
//(each array element  arr[i]  contains a digit; the last digit is kept in  arr[0] ).
//Each of the numbers that will be added could have up to  10 000  digits.

using System;
class NumberAsArray
    {
        static void Main()
            {
            string firstNumber =Console.ReadLine();
            string secondNumber =Console.ReadLine();
            int[] firstArray = new int[firstNumber.Length];
            int[] secondArray = new int[secondNumber.Length];
            ToArray(firstNumber, firstArray);
            ToArray(secondNumber, secondArray);
            int[] sum =new int [Math.Max(firstNumber.Length,secondNumber.Length) + 1];
            if (firstNumber.Length > secondNumber.Length)
            {
                Array.Copy(secondArray, sum, secondArray.Length);//12345
                SumArrays(sum, firstArray);//123>>12468
            }
            else
            {
                Array.Copy(firstArray, sum, firstArray.Length);
                SumArrays(sum, secondArray);
            }

            Array.Reverse(sum);
            int i = 0;
            if (sum[i] == 0) i++;
            for (; i < sum.Length; i++)
            {
                Console.Write(sum[i]);
            }
            Console.WriteLine();
            }

        private static void SumArrays(int[] sum, int[] array1)
        {
            int oneOnMind = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if ((sum[i] + array1[i] + oneOnMind) > 9)
                {
                    sum[i] = ((sum[i] + array1[i] + oneOnMind) % 10);
                    oneOnMind = 1;
                }
                else
                {
                    sum[i] = ((sum[i] + array1[i] + oneOnMind) % 10);
                    oneOnMind = 0;
                }
            }
            if (oneOnMind == 1) sum[sum.Length - 1] = 1;
        }

        private static void ToArray(string num1, int[] arrayNum1)
        {
            for (int i = 0, j = num1.Length - 1; j >= 0; i++, j--)
            {
                arrayNum1[i] = num1[j] - '0';
            }
        }
    }
