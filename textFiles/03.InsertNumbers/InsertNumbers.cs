//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//he result should be written to another text file.

using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class InsertNumbers
    {
        static void Main()
        {
             StreamReader readFile = new StreamReader(@"..\..\name.txt"); 
            using (readFile) 
           { 
                StreamWriter writeFile = new StreamWriter(@"..\..\WithNumbers.txt"); 
                using (writeFile) 
                { 
                    int currentLine = 1; 
                    string line = readFile.ReadLine(); 
                     while (line != null) 
                     { 
                        writeFile.WriteLine("Line {0}: {1}", currentLine, line); 
                         line = readFile.ReadLine(); 
                        currentLine++; 
                  } 
                 } 
            }
            Console.WriteLine("the problem is solved!");

        }
    }

