//• Write a program that extracts from a given text all palindromes, e.g.  ABBA ,  lamal ,  exe .
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Palindromes
{
    class Palindromes
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                string reversed = "";
                for (int j = word.Length-1; j >=0 ; j--)
                {
                     reversed +=word[j];
                }
                if (word==reversed && word.Length>1)
                {
                    result.AppendLine(word);
                }
            }
            Console.WriteLine(result);
        }
    }
}
