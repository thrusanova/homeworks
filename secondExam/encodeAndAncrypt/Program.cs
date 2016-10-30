using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encodeAndAncrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string cypher = Console.ReadLine();
            string text =Encrypt(message, cypher) + cypher;
           // Console.WriteLine(text);
            string result = Encode(text)+cypher.Length;
            Console.WriteLine(result);
          //  Console.WriteLine(Encode(result));
        }
        public static string Encrypt(string message, string cypher)
        {
            var result = new StringBuilder(message);
            var step = Math.Max(message.Length, cypher.Length);
            for (int i = 0; i < step; i++)
            {
                var messageIndex = i % message.Length;
                var cypherIndex = i % cypher.Length;
                result[messageIndex] = (char)(((result[messageIndex] - 'A') ^ (cypher[cypherIndex] - 'A')) + 'A');

            }
            return result.ToString();
        }
          public static string Encode(string text)
        {
            StringBuilder finalRez = new StringBuilder();
              char previousSymbol=text[0];
              int counter = 1;
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i]==previousSymbol)
                {
                    counter++;
                }
                else
                {
                    if (counter==1)
                    {
                        finalRez.Append(previousSymbol);
                    }
                    else if (counter==2)
                    {
                        finalRez.Append(previousSymbol, 2);
                    }
                    else
                    {
                        finalRez.Append(counter + previousSymbol.ToString());
                    }
                    previousSymbol = text[i];
                    counter = 1;
                }
            }
            if (counter == 1)
            {
                finalRez.Append(previousSymbol);
            }
            else if (counter == 2)
            {
                finalRez.Append(previousSymbol, 2);
            }
            else
            {
                finalRez.Append(counter + previousSymbol.ToString());
            }
            return finalRez.ToString();
        }
      
    }
}