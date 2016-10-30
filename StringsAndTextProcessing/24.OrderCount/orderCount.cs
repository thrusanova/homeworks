//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.OrderCount
{
    class orderCount
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            String[] words = text.Split(new char[] { ' ', ',', '.', '!' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i]+ " ");
            }
            Console.WriteLine();
        }
    }
}
