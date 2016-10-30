using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace tures4a1
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            var tre4aNum = new List<string> { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON" };
            var output = new List<string>();
            
            while (number!=0)
            {
                output.Add(tre4aNum[(int)number % 9]);
                number /= 9;
            }
            output.Reverse();
            
            Console.WriteLine(string.Join(string.Empty, output));
        }
    }
}
