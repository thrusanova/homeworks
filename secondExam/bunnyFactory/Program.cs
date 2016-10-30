using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace bunnyFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cages = new List<int>();
            string input = Console.ReadLine();
            while (input!="END")
            {
               cages.Add(int.Parse(input));
               input = Console.ReadLine();
            }
            int startIndex = 0;
            while (true)
            {
                StringBuilder sb = new StringBuilder();
                if (startIndex>=cages.Count)
                {
                    break;
                }
                int sum = 0;
                for (int i = 0; i <= startIndex; i++)
                {
                    sum+=cages[i];
                }
                if (sum>=cages.Count)
                {
                    break;
                }
                int totalSum = 0;
                BigInteger product = 1;
                for (int i = startIndex+1; i <=sum+startIndex; i++)
                {
                    totalSum +=cages[i];
                    product *= cages[i];
                }
                sb.Append(totalSum);
                sb.Append(product);
                for (int i = sum+startIndex+1; i < cages.Count; i++)
                {
                    sb.Append(cages[i]);
                }
                cages.Clear();
                for (int i = 0; i < sb.Length; i++)
                {
                    if (sb[i]!='1' && sb[i]!='0')
                    {
                        cages.Add(int.Parse(sb[i].ToString()));
                    }
                }
                startIndex++;
            }
            Console.WriteLine(String.Join(" ", cages));
        }
    }
}
