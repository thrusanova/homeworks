using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ftml
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in a  <upcase> yellow submarine </upcase> . We don't have  <upcase> anything </upcase>  else.";
            int firstIndex = 0;
            int lastIndex = 0;
            for (int i = 0; i < text.Length - 8; i++)
            {
                if (text.Substring(i, 8) == "<upcase>")
                {
                    i += 8;
                    firstIndex = i;
                }
                else if (text.Substring(i, 9) == "</upcase>")
                {
                    lastIndex = i;
                    string upper = text.Substring(firstIndex, lastIndex - firstIndex).ToUpper();
                    text = text.Replace(text.Substring(firstIndex, lastIndex - firstIndex), upper);
                    text = text.Remove(firstIndex - 8, 8);
                    text = text.Remove(lastIndex - 8, 9);
                }
            }
            Console.WriteLine(text);
        }
    }
}
