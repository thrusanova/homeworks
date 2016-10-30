//Write a program that reads a string from the console and prints all different letters 
//in the string along with information how many times each letter is found. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _21.LetterCount
{
    class LetterCount
    {
        static void Main()
       {
            string text = Console.ReadLine();
            int[] letters = new int['z' - 'a' + 1];
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 'a' && text[i] <= 'z') 
                {
                    letters[text[i] - 'a']++;
                }
            }
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] !=0)
                {
                   // Console.WriteLine("{0} => {1}",(char)(i+'a'),letters[i]);
                    dict.Add((char)(i + 'a'), letters[i]);
                }
            }
            foreach (var pair in dict)
            {
                Console.WriteLine("{0}->{1}",pair.Key,pair.Value);
            }    
        }
    }
}
