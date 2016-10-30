using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slide3D
{
    class slide3D
    {
        static void Main(string[] args)
        {
            string [] line = Console.ReadLine().Split(' ');
            int cuboidWeight = int.Parse(line[0]);
            int cuboidHeight = int.Parse(line[1]);
            int cuboidDepth = int.Parse(line[2]);
             
            //read cuboid
            string  [ , , ]cuboid =new string [cuboidWeight,cuboidHeight,cuboidDepth];
            for (int h = 0; h < cuboidHeight; h++)
            {
                string[] row = Console.ReadLine().Split('|');
                for (int d = 0; d < cuboidDepth; d++)
                {
                    string[] cubes = row[d].Trim().Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                    for (int w = 0; w < cuboidWeight; w++)
                    {
                        string cube = cubes[w];
                        cuboid[w, h, d] = cube;
                    }
                }
            }
            line  = Console.ReadLine().Split(' ');
            int ballW = 0;
            int balH = 0;
            int ballD = 0;
            string currentCuboid = "";
            int nextW = int.Parse(line[0]);
            int nextH = balH;
            int nextD = int.Parse(line[1]);
            bool canDrop = true;
            //main logic

           
            while (canDrop)
            {
                if (nextH==cuboidHeight)
                {
                    break;
                }
                if (nextW<0 || nextW>cuboidWeight-1 || nextD<0 || nextD>cuboidDepth-1)//check 
                {
                    canDrop = false;
                    break;
                }
                ballW = nextW;
                balH = nextH;
                ballD = nextD;

                currentCuboid = cuboid[nextW, nextH, nextD];
                char command = currentCuboid[0];
                switch (command)
                {
                    case 'B': canDrop = false; break;
                    case 'E': nextH++; break;
                    case 'T':
                        int [] coord = currentCuboid.Substring(2).Split(' ').Select(x => int.Parse(x)).ToArray();
                        nextW = coord[0];
                        nextD=coord[1];
                        break;
                    case 'S'://l,r,b,f,bl...
                        nextH++;
                        string direction = currentCuboid.Substring(2);
                        switch (direction)
                        {
                            case "L": nextW--; break;
                            case "R": nextW++; break;
                            case "F": nextD--; break;
                            case "B": nextD++; break;
                            case "FL": nextW--; nextD--; break;
                            case "FR": nextW++; nextD--; break;
                            case "BL": nextW--; nextD++; break;
                            case "BR": nextW++; nextD++; break;
                        }
                        break;
                }

            }
            Console.WriteLine(canDrop ? "Yes":"No");
            Console.WriteLine("{0} {1} {2}",ballW,balH,ballD);
        }
    }
}
