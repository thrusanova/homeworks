using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relevance_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());//",", ".", "(", ")", ";", "-", "!", "?" 
            string[] sequense = new string[number];
      
            Dictionary<string, int> dict = new Dictionary<string, int>();
            int count = 0;
            for (int i = 0; i < number; i++)
            {
                sequense[i] = Console.ReadLine();
            }
            for (int j = 0; j < sequense.Length; j++)
            {
                string[] paragraph = sequense[j].Split(new char[] { ',', '.', '(', ')', ';', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < paragraph.Length; i++)
                {
                    if (string.Equals(paragraph[i],word,StringComparison.CurrentCultureIgnoreCase))
                    {
                        paragraph[i] = paragraph[i].ToUpper();
                        count++;
                    }
                }
                dict.Add(string.Join(" ", paragraph), count);
                count = 0;
            }
            var result=dict.OrderByDescending(x=>x.Value).ToDictionary(t=>t.Key,t=>t.Value);
            Console.WriteLine(string.Join("\n", result.Keys));
        }
    }
}
