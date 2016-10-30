//Write a program that extracts from a given text all dates that match the format  DD.MM.YYYY .
// Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _19.Canada
{
    class DAte
    {
        static void Main()
        {
                 string text = "Today is 31.12.2014 and the they after today is 01.01.2015"; 
           MatchCollection dates = Regex.Matches(text, @"(0?[1-9]|[12][0-9]|3[01])[.](0?[1-9]|1[012])[.]\d{4}");
           foreach (Match date in dates)
           {
               string result = date.ToString();
               Console.WriteLine(result);
           }
        }
    }
}
