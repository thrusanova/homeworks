using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    class Program
    {
        static void Main(string[] args)
        {
           // var list1 = new string[] { "1", "2", "3", "4", "5", "6" };
          //  var list2 = new string[] { "2", "3", "4" };
          //  var listCommon = list1.Intersect(list2);
          //  foreach (string s in listCommon) Console.WriteLine(s);
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine()); 
            string[] first = Console.ReadLine().Split(' ');
            var firstArray = new string[N];
            string[] second = Console.ReadLine().Split(' ');
            var secondArray = new string[M];
            int count = 0;
            var listCommon = first.Intersect(second);
            foreach (string s in listCommon)
            {
                Console.WriteLine(s);
                count++;
            }
        

        }

    }

}
