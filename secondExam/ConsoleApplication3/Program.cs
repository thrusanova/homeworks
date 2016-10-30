using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class BunnyFactory
{
    public static List<int> nums = new List<int>();
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        while (input != "END")
        {
            nums.Add(int.Parse(input));
            input = Console.ReadLine();
        }

        int startIndex = 0;

        while (true)
        {
            StringBuilder tempRes = new StringBuilder();

            if (startIndex >= nums.Count)
            {
                break;
            }
            int sum = 0;
            for (int i = 0; i <= startIndex; i++)
            {
                sum += nums[i];
            }

            if (sum >= nums.Count)
            {
                break;
            }

            int totalSum = 0;
            BigInteger prod = 1;

            for (int i = startIndex + 1; i <= sum + startIndex; i++)
            {
                totalSum += nums[i];
                prod *= nums[i];
            }

            tempRes.Append(totalSum);
            tempRes.Append(prod);

            for (int i = sum + startIndex + 1; i < nums.Count; i++)
            {
                tempRes.Append(nums[i]);
            }

            nums.Clear();

            for (int i = 0; i < tempRes.Length; i++)
            {

                if (tempRes[i] != '0' && tempRes[i] != '1')
                {
                    nums.Add(int.Parse(tempRes[i].ToString()));
                }
            }
            startIndex++;
        }

        Console.WriteLine(string.Join(" ", nums));
    }
}