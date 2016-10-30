using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static string Decode(string encodeMessage)
        {
            var result = new StringBuilder();
            var count = 0;
            foreach (var ch in encodeMessage)
            {
                if (char.IsDigit(ch))
                {
                    count *= 10;
                    count += int.Parse(ch.ToString());
                }
                else
                {
                    if (count == 0)
                    {
                        result.Append(ch);//if AAABB
                    }
                    else
                    {
                        result.Append(ch, count);//if A6B=ABBBBBB,count =6;
                        count = 0;
                    }

                }

            }
            return result.ToString();
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(Decode("ABBAA6BA") == "ABBAABBBBBBA");
            string input = Console.ReadLine();
            var digits = new List<int>();
            for (int i = input.Length-1; i >0; i--)
            {
                if (char.IsDigit(input[i]))
                {
                    digits.Add(int.Parse(input[i].ToString()));
                    //or digits.Add(input[i] - '0');
                }
                else
                {
                    break;
                }
            }
            digits.Reverse();
            int lenghtOfCypher = 0;//take the last digits of the list ch
            foreach (var digit in digits)
            {
                lenghtOfCypher *= 10;
                lenghtOfCypher += digit;
            }
           // Console.WriteLine(lenghtOfCypher);
            //o	Encode(Encrypt(message, cypher) + cypher) + lengthOfCypher-ABBAA6BA7=ABBAABBBBBBA+cypher.lenght=7;
            var encodeMessage = input.Substring(0,input.Length - digits.Count);//ABBAA6BA
            var decodeMessage=Decode(encodeMessage);//ABBAABBBBBBBA
            var encryptedMessage = decodeMessage.Substring(0, decodeMessage.Length - lenghtOfCypher);
                var cypher=decodeMessage.Substring(decodeMessage.Length-lenghtOfCypher);

               // Console.WriteLine(encryptedMessage);
               // Console.WriteLine(cypher);
                var message = Encrypt(encryptedMessage, cypher);
                Console.WriteLine(message);
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
    }
}
