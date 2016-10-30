using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleJustification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            List<string> words = new List<string>();
            for (int i = 0; i < rows; i++)
            {
                string[] line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < line.Length; j++)
                {
                    words.Add(line[j]);
                }
            }
            StringBuilder result = new StringBuilder();
            int spaceToAddd;
            string currLine = string.Empty;
            int spaceIndex;
            int currLineWordCount = 0;
            for (int i = 0; i < words.Count; i++)
            {
                if (currLine.Length+words[i].Length<=width)
                {
                    currLine += string.Format("{0} ", words[i]);
                    currLineWordCount++;
                    continue;
                }
                currLine = currLine.Trim();
                spaceToAddd = width - currLine.Length;
                spaceIndex = currLine.IndexOf(" ");
                if (currLineWordCount != 1)
                {
                    for (int j = 0; j < currLineWordCount && spaceToAddd > 0; j++)
                    {
                        int space = (int)Math.Ceiling(spaceToAddd / (double)(currLineWordCount - j - 1));
                        currLine = currLine.Insert(spaceIndex, new string(' ', space));
                        spaceIndex = currLine.IndexOf(' ', spaceIndex + space + 1);
                        spaceToAddd -= space;
                    }
                }
                result.AppendLine(currLine);
                currLine = string.Format("{0} ", words[i]);
                currLineWordCount = 1;
    

            }
            currLine = currLine.Trim();
            spaceToAddd = width - currLine.Length;
            spaceIndex = currLine.IndexOf(" ");
            if (currLineWordCount != 1)
            {
                for (int j = 0; j < currLineWordCount && spaceToAddd > 0; j++)
                {
                    int space = (int)Math.Ceiling(spaceToAddd / (double)(currLineWordCount - j - 1));
                    currLine = currLine.Insert(spaceIndex, new string(' ', space));
                    spaceIndex = currLine.IndexOf(' ', spaceIndex + space + 1);
                    spaceToAddd -= space;
                }
            }
            result.Append(currLine);
            Console.WriteLine(result);
        }

    }
}
