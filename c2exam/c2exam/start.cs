using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2exam
{
    class start
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var digits = new List<string>();
            for (char k = 'a'; k <= 'z'; k++)
            {
                digits.Add(k.ToString());
            }
            StringBuilder number = new StringBuilder();
            for (int i = 0; i < line.Length; i++)
            {
                number.Append(line[i]);


                ulong num = 0;
                for (int j = 0; j < number.Length; j++)
                {
                    num *= 17;
                    num += (ulong)(number[j] - 'a');

                }
               
                string result = string.Empty;
                while (num != 0)
                {

                    result = digits[(int)(num % 26)] + result;
                    num /= 26;

                }

                Console.Write(result + " ");
                number.Clear();
                

            }
            Console.WriteLine();
        }
    }
}
