using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace TRES4_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            List<string> tres4Number = new List<string>();
            if (number == 0)
            {
                Console.WriteLine("LON+");
                
            }
            while (number>0)
            {
              

                switch (number%9)
                {
                    case 0: tres4Number.Add("LON+"); break;
                    case 1:  tres4Number.Add("VK-");break;
                    case 2: tres4Number.Add("*ACAD"); break;
                    case 3: tres4Number.Add("^MIM"); break;
                    case 4: tres4Number.Add("ERIK|"); break;
                    case 5: tres4Number.Add("SEY&"); break;
                    case 6: tres4Number.Add("EMY>>"); break;
                    case 7: tres4Number.Add("/TEL"); break;
                    case 8: tres4Number.Add("<<DON"); break;
                       
                }
                number /= 9;
            
                
            }
            tres4Number.Reverse();
                for (int i = 0; i < tres4Number.Count; i++)
                {
                    Console.Write(tres4Number[i]);
                }
              Console.WriteLine();
            }
        }
    }
