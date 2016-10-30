using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages_in_a_Bottle
{
    class MessageBottle
    {
        static string secretMessage;
        static string cypher;
        static  Dictionary<string, char> dict = new Dictionary<string, char>();
        static SortedSet<string> result = new SortedSet<string>();
        static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            ReadInput();
            GenerateMessage(0);
            Console.WriteLine(result.Count);
            foreach (var message in result)
            {
                Console.WriteLine(message);
            }
        }

        private static void GenerateMessage(int index)
        {
            if (index == secretMessage.Length)
            {
                result.Add(sb.ToString());
                return;
            }

            for (int i = 0; i + index <= secretMessage.Length; i++)
            {
                if (dict.ContainsKey(secretMessage.Substring(index, i)))
                {
                    sb.Append(dict[secretMessage.Substring(index, i)]);
                    GenerateMessage(index + i);
                    sb.Remove(sb.Length - 1, 1);
                }
            }

        }

        private static void ReadInput()
        {
            secretMessage = Console.ReadLine();
            cypher = Console.ReadLine();
            int index = 0;
            //A1B12C11D2
            while (index<cypher.Length)
            {
                if (char.IsLetter(cypher[index]))
                {
                    char value = cypher[index];
                    index++;
                    while (index<cypher.Length && char.IsDigit(cypher[index]))
                    {
                        sb.Append(cypher[index]);
                        index++;
                    }
                    if (!dict.ContainsValue(value))
                    {
                        dict.Add(sb.ToString(),value);
                    }
                    sb.Clear();
                }
            }


        }
    }
}
