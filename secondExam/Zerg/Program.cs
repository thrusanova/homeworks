using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zerg
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabet = new List<string> { "Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr",
                "Mrrr", "Psst", "Uaah", "Uaha", "Zzzz", "Bauu", "Djav", "Myau", "Gruh" };
            var input = Console.ReadLine();
            long decimalRepresentation = 0;
            for (int i = 0; i < input.Length; i+=4)
            {
                var digitIn15 = input.Substring(i, 4);
                var decimalValue = alphabet.IndexOf(digitIn15);
                decimalRepresentation *= 15;
                decimalRepresentation += decimalValue;

            }
            Console.WriteLine(decimalRepresentation);
        }
    }
}








