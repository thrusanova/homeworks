//Write a program for extracting all email addresses from given text.
// All sub-strings that match the format  <identifier>@<host>…<domain>  should be recognized as emails.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _18.ExtractMails
{
    class Mails

    {
        static void Main()
        {
             StringBuilder str = new StringBuilder(); 
           string text = "my name.com,new.mail.bg,new@hotmail.bg, hello,office@abv.bg, pingbg , my@gmail.com"; 
             MatchCollection matches = Regex.Matches(text, @"(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})"); 
          
             foreach (var mails in Regex.Matches(text, @"(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})")) 
             { 
              Console.WriteLine(mails); 
           } 

        }
    }
}
