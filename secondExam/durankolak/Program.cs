using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaspichan_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder number = new StringBuilder(Console.ReadLine().Split(' ').ToArray());
            ulong num = 0;
           // string currNum = "";
            for (int i = 0; i < number.Length; i++)
            {
                num *= 17;
                if (Char.IsLower(number[i]))
                {
                    num += (ulong)(number[i] - 'A');
                }
                else
                {
                    num += (ulong)(number[i] - 'a' +1) * 26;
                    i+=1;
                    num += (ulong)(number[i] - 'A');
                }
            }
            Console.WriteLine(num);
        }

    }
}
