using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingLetterr
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();
            var maxWordLen = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (maxWordLen < input[i].Length)
                {
                    maxWordLen = input[i].Length;
                }
            }
            for (int i = 0; i < maxWordLen; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    string currentWord = input[j];
                    if (i < currentWord.Length)
                    {
                        int lastLetter = currentWord.Length - 1 - i;
                        result.Append(currentWord[lastLetter]);
                    }
                }
                
            }
          //  StringBuilder finalResult = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                char currentSymbol = result[i];
                var transition = char.ToLower(currentSymbol) - 'a' + 1;
                var position = (i + transition) % result.Length;
                result.Remove(i, 1);
                result.Insert(position,currentSymbol);
            }
            Console.WriteLine(result);

        }
    }
}