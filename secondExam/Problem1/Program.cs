using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabet = new List<string> { "Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr",
                "Mrrr", "Psst", "Uaah", "Uaha", "Zzzz", "Bauu", "Djav", "Myau", "Gruh" };
            string input = Console.ReadLine();
            long decimalRepresentation = 0;
            for (int i = 0; i < input.Length; i+=4)
            {
                var digit15 = input.Substring(i, 4);
                var decimalVAlue = alphabet.IndexOf(digit15);
                decimalRepresentation *= 15;
                decimalRepresentation += decimalVAlue;
            }
            Console.WriteLine(decimalRepresentation);

        }

    }
}
