using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cats
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 =Console.ReadLine();
            int C = int.Parse(line1.Substring(0,1));
            string line2 = Console.ReadLine();
            int S = int.Parse(line2.Substring(0,1));
            string input = Console.ReadLine();
            while (input != "Mew!")
            {
                input = Console.ReadLine();
            }
            Console.WriteLine("No concert!");

        }
    }
}
