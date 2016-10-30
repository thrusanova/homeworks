//Write a program that replaces all occurrences of the sub-string  start  with the sub-string  finish  in a text file.
// Ensure it will work with large files (e.g.  100 MB ).

using System;
using System.IO;
   class SubString
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
                    
                    while (line!=null) 
                     { 
                         writeFile.WriteLine(line.Replace("start","finish")); 
                        line = readFile.ReadLine(); 
                    } 
                } 
             } 

        }
    }
