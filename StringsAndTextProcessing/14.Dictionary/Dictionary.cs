//A dictionary is stored as a sequence of text lines containing words and their explanations.
// Write a program that enters a word and translates it by using the dictionary.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Dictionary
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add(".NET", "platform for applications from Microsoft ");
            dict.Add("CLR", " managed execution environment for .NET ");
            dict.Add("namespace", " hierarchical organization of classes ");
            string result = dict[key];
            Console.Write( result);
            Console.WriteLine();
        }
    }
}
