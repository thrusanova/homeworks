using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magicWord
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var words = new List<string>();
            for (int i = 0; i < N; i++)
            {
                words.Add(Console.ReadLine());
            }
            for (int i = 0; i < N; i++)
            {
                var word = words[i];
                var newIndex = word.Length % (N + 1);
                words[i] = null;
                words.Insert(newIndex, word);
                words.Remove(null);
            }
            //printing
            var longestWord = words.Max(x=>x.Length);
            var result = new StringBuilder();
                for (int i = 0; i < longestWord; i++)
			{
                foreach (var word in words)
                {
                    if (word.Length>i)
                    {
                        result.Append(word[i]);
                    }
                }
			}
                Console.WriteLine(result.ToString());
            
        }
    }
}
