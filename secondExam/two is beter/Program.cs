using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_is_beter
{
    class two_is_beter
    {
        static void Main(string[] args)
        {
            string inputOne = Console.ReadLine();
            string[] input=inputOne.Split(' ');

            long first = long.Parse(input[0]);
            long second = long.Parse(input[1]);
            int count=LuckyNum( first, second);
            string[] inputTwo = Console.ReadLine().Split(',');
            var numbers = new List<int>();
            for (int i = 0; i < inputTwo.Length; i++)
            {
                numbers.Add(int.Parse(inputTwo[i]));
            }
            int percent = int.Parse(Console.ReadLine());
           
            int answer=SmallerNum(numbers, percent);

            Console.WriteLine(count);
            Console.WriteLine(answer);

        }

        private static int SmallerNum(List<int> numbers, int percent)
        {
            
            numbers.Sort();
            for (int i = 0; i < numbers.Count; i++)
            {
                int smaller = 0;
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[i]>=numbers[j])
                    {
                        smaller++;
                    }
                    
                }
                if (smaller >= numbers.Count *(percent / 100.00))
                {
                    return numbers[i];
                }
               
            }
            return numbers[numbers.Count - 1];
        }

        static bool IsPalindrom(long number)
        {
            string num = number.ToString();
            for (int i = 0; i < num.Length / 2; i++)
            {
                if (num[i] != num[num.Length - (i + 1)])
                {
                    return false;
                }
            }
            return true;
        }
        static int LuckyNum(long first, long second)
        {
            int count = 0;
            int left = 0;
            long maxNum = second;
            var result = new List<long> { 3, 5 };
            while (left < result.Count)
            {
                int right = result.Count;
                for (int i = left; i < right; i++)
                {
                    if (result[i] <= maxNum)
                    {
                        result.Add(result[i] * 10 + 3);
                        result.Add(result[i] * 10 + 5);
                    }
                    left = right;
                }

            }
            foreach (var item in result)
            {
                if (item >= first && item <= second && IsPalindrom(item))
                {
                    count++;
                }
            }
            return count;
        }
    }
}

