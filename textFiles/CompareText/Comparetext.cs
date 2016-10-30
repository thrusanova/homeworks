//Write a program that compares two text files line by line and prints the number of lines that are the same and
//the number of lines that are different.
//• Assume the files have equal number of lines.

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CompareText
{
    class Comparetext
    {
        static void Main()
        {
            StreamReader firstFile = new StreamReader(@"..\..\text.txt");
            using (firstFile)
            {
                StreamReader secondFile = new StreamReader(@"..\..\name.txt");
                using (secondFile)
                {
                    int sameRows = 0;
                    int differentRows = 0;
                    string lineFirstFile = firstFile.ReadLine();
                    string lineSecondFile = secondFile.ReadLine();
                    while (lineFirstFile != null)
                    {
                        if (lineFirstFile == lineSecondFile)
                        {
                            sameRows++;
                        }
                        else
                        {
                            differentRows++;
                        }
                        lineFirstFile = firstFile.ReadLine();
                        lineSecondFile = secondFile.ReadLine();
                    }
                    Console.WriteLine("Same rows: {0}", sameRows);
                    Console.WriteLine("Different rows: {0}", differentRows);
                }
            }
        }
    }
}