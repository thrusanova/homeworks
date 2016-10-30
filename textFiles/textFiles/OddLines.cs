﻿//Write a program that reads a text file and prints on the console its odd lines.
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textFiles
{
    class OddLines
    {
        static void Main()
        {
            StreamReader reader =
                new StreamReader("decode.cs");
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    if (lineNumber%2!=0)
                    {
                        Console.WriteLine("Line {0}: {1}", lineNumber, line);
                        line = reader.ReadLine();
                    }
                    
                }
            }
        }
    }
}
