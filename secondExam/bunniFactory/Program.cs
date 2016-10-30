using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bunniFactory
{
    class Program
    {
        static List<int> BunnyCage;
        static string result = "";
        static void Main(string[] args)
        {
            ReadInput();
            Calculate();

        }

       

        private static void Calculate()
        {
            while (true)
            {
                StringBuilder sb = new StringBuilder();
                int counter = 0;
                if (counter >= BunnyCage.Count)
                {
                    break;
                }
                int sum = 0;
                int product = 1;
                int totalsum = 0;
                for (int i = 0; i <= counter; i++)
                {
                    sum += BunnyCage[i];
                }
                if (sum>=BunnyCage.Count)
                {
                    break;
                }
                for (int i = counter; i <= counter+sum; i++)
			{
			         totalsum+=BunnyCage[i];
                    product*=BunnyCage[i];
			}
                sb.Append(totalsum);
                sb.Append(product);
                for (int i = sum+counter+1; i < BunnyCage.Count; i++)
                {
                    sb.Append(BunnyCage[i]);
                }
                BunnyCage.Clear();
                for (int i = 0; i < sb.Length; i++)
                {
                    if (sb[i]!='1' ||sb[i]!='0')
                    {
                        BunnyCage.Add(int.Parse(sb[i].ToString()));
                    }
                }
                counter++;
            }
            result = string.Join(" ", BunnyCage);
            Console.WriteLine(result);
        }

        private static void ReadInput()
        {
            BunnyCage = new List<int>();
            string currCage = Console.ReadLine();
            while (currCage!="END")
            {
                BunnyCage.Add(int.Parse(currCage));
                currCage = Console.ReadLine();
            }


        }
    }
}