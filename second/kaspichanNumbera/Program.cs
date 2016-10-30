using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaspichanNumbera
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong kaspichanNumber=ulong.Parse(Console.ReadLine());
            List<string> letters = new List<string>();
            for (char i = 'A'; i <= 'Z'; i++)
            {
                letters.Add(i.ToString());
            }
            for (char i = 'a'; i <= 'z'; i++)
            {
                for (char j = 'A'; j <= 'Z'; j++)
                {
                    letters.Add(i.ToString()+j.ToString());
                }
            }
            string result = "";
            if (kaspichanNumber==0)
            {
                Console.WriteLine('A');
            }
            while (kaspichanNumber!=0)
            {
                result = letters[(int)(kaspichanNumber % 256)]+result;
                kaspichanNumber /= 256;
            }
          //  result.Reverse();
            Console.WriteLine(result);       
        }
    }
}
