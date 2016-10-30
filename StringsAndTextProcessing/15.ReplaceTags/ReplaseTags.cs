//Write a program that replaces in a HTML document given as string all the tags  <a href="…">…</a>  with corresponding tags  [URL=…]…/URL] .
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ReplaceTags
{
    class ReplaseTags
    {
        static void Main()
        {
            /*/<p>Please visit <a href="http://academy.telerik. 
            //com">our site</a> to choose a training course. Also 
            //visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p> 
             */
            StringBuilder result = new StringBuilder();
            string text = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course.Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
            result.Append(text);
            result.Replace(@"<a href=""", "[URL=");
            result.Replace("</a>", "[/URL]");
            result.Replace(@""">", "]");
            Console.WriteLine(result);
        }
    }
}