//Write a program that concatenates two text files into another text file.
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Concatenate
{
    static void Main()
    {
        StreamWriter writerFirst = new StreamWriter(@"..\..\new.txt", false);
        using (writerFirst)
        {
            StreamReader readFirstDoc = new StreamReader(@"..\..\text.txt"); //The first document is the text.txt. 
            using (readFirstDoc)
            {
                string line = readFirstDoc.ReadLine();
                while (line != null)
                {
                    writerFirst.WriteLine(line);
                    line = readFirstDoc.ReadLine();
                }
            }
                } 
             StreamWriter writerSecond = new StreamWriter(@"..\..\new.txt", true); 
            using(writerSecond) 
             { 
                 StreamReader readSecondDoc = new StreamReader(@"..\..\name.txt"); //The second document is name.txt
                { 
                     string line = readSecondDoc.ReadLine(); 
                    while (line!= null) 
                     { 
                         writerSecond.WriteLine(line); 
                        line= readSecondDoc.ReadLine(); 
                   } 
                 } 
           } 
             Console.WriteLine("Concatenation is done!"); 
        }
    }
