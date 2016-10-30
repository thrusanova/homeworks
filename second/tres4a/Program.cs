using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tres4a
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            List<string> tres4a = new List<string>();
            if (number==0)
            {
                Console.WriteLine("LON+");
            }
           while (number>0)
            {
                switch (number%9)
                {
                    case 0: tres4a.Add("LON+"); break;
                    case 1:tres4a.Add ("VK-"); break;
                    case 2: tres4a.Add("*ACAD"); break;
                    case 3: tres4a.Add("^MIM"); break;
                    case 4: tres4a.Add("ERIK|"); break;
                    case 5: tres4a.Add("SEY&"); break;
                    case 6: tres4a.Add("EMY>>"); break;
                    case 7: tres4a.Add("/TEL"); break;
                    case 8: tres4a.Add("<<DON"); break;
                       
                }
                number /= 9;
            }
           tres4a.Reverse();
           foreach (var nums in tres4a)
           {
               Console.Write(nums);
           }
           Console.WriteLine();

        }
    }
}
