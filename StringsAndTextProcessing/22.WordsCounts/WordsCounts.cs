//Write a program that reads a string from the console 
//and lists all different words in the string along with information how many times each word is found.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.WordsCounts
{
    class WordsCounts
    {
        static void Main()
        {

            string text = Console.ReadLine();
            string [] words = text.Split(new char[] { ' ',',','.' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict.Add(word, 1);
                }
            }    
            foreach (var pair in dict)
            {
                Console.WriteLine("{0}->{1}", pair.Key, pair.Value);
            }    
        }
    }
}
