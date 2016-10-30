//• Modify the solution of the previous problem to replace only whole words (not strings).
using System;
using System.IO;
using System.Text.RegularExpressions;
   class word
    {
        static void Main()
        {
            StreamReader readFile = new StreamReader(@"..\..\input.txt"); 
             using (readFile) 
           { 
                 StreamWriter writeFile = new StreamWriter(@"..\..\output.txt"); 
                 using (writeFile) 
                 { 
                     string line = readFile.ReadLine(); 
                       while (line != null) 
                   { 
                        writeFile.WriteLine(Regex.Replace(line,@"\bstart\b", "finish")); 
                        line = readFile.ReadLine(); 
                     } 
                } 
             } 
        }
    }

