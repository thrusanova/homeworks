//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

using System; 
 using System.Collections.Generic; 
 using System.IO; 
 using System.Linq;

class DeleteOddLine
{

    static List<string> list = new List<string>();
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\start.txt");
        using (reader)
        {
            string line = reader.ReadLine();
            int lineCount = 1;
             while (line != null) 
            {
                if (lineCount % 2 == 0)
                {
                    list.Add(line);
                }
                lineCount++;
                line = reader.ReadLine();
            }
        }

        StreamWriter writer = new StreamWriter(@"..\..\start.txt");
        using (writer)
        {
            for (int i = 0; i < list.Count; i++)
            {
                writer.WriteLine(list[i]);
            }

        }
        Console.WriteLine("Process completed!");
    }
   
}
 