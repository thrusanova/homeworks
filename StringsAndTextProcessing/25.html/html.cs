//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

//Example input:
/*<html>
  <head><title>News</title></head>
  <body><p><a href="http://academy.telerik.com">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skilful .NET software engineers.</p></body>
</html>
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _25.html
{
    class html
    {
        static void Main(string[] args)
        {
             string text= @"<html><head><title>News</title></head> <body><p><a href=""http://academy.telerik.com"">Telerik   Academy</a>aims to provide free real-world practical  training for young people who want to turn into skilful .NET software engineers.</p></body></html>"; 
           StringBuilder result = new StringBuilder(); 
             MatchCollection values = Regex.Matches(text, "(?<=^|>)[^><]+?(?=<|$)"); 
            int count = 1;
        foreach (Match value in values) 
         { 
             if (count == 1) 
             { 
                Console.WriteLine("Title: {0}", value);
                Console.WriteLine();
              Console.Write("Text: "); 
            } 
             else 
             { 
                 Console.Write(value + " "); 
            } 
             count++; 
         }
        Console.WriteLine();
        }
    }
}
