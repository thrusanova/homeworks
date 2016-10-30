//You are given a text. Write a program that changes the text in all regions surrounded by the tags  
//<upcase>  and  </upcase>  to upper-case.
// The tags cannot be nested.
//Example: We are living in a  <upcase> yellow submarine </upcase> . We don't have  <upcase> anything </upcase>  else.
//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;
    class ParseTags
    {
        static void Main()
        {
            string text = "We are living in a  <upcase> yellow submarine </upcase> . We don't have  <upcase> anything </upcase>  else.";
            int firstIndex = 0;
            int lastIndex = 0;
            for (int i = 0; i < text.Length-8; i++)
            {
                if (text.Substring(i,8)=="<upcase>")
                {
                    i += 8;
                    firstIndex = i;
                }
                else if (text.Substring(i,9)=="</upcase>")
                {
                    lastIndex = i;
                    string upper = text.Substring(firstIndex, lastIndex - firstIndex).ToUpper();
                    text = text.Replace(text.Substring(firstIndex, lastIndex - firstIndex), upper);
                    text = text.Remove(firstIndex- 8,8);
                    text = text.Remove(lastIndex - 8, 9);
                }
            }
            Console.WriteLine(text);
        }
    }

