using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laser
{
    class laser


    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(' ');
            int cubeWidth = int.Parse(input[0]);
            int cubeHeight = int.Parse(input[1]);
            int cubeDepth = int.Parse(input[2]);
            string[] start = Console.ReadLine().Split(' ');
            int nextWidth = int.Parse(start[0])-1;
            int nextHeight = int.Parse(start[1])-1;
            int nextDepth = int.Parse(start[2])-1;
            string[] direction = Console.ReadLine().Split(' ');
            int dirWidth = int.Parse(direction[0]);
            int dirHeight = int.Parse(direction[1]);
            int dirDepth = int.Parse(direction[2]);
            bool  [ , , ] cube=new bool[cubeWidth,cubeHeight,cubeDepth];
            for (int w = 0; w < cubeWidth; w++)
            {
                cube[w, 0, 0] = true;
                cube[w, 0, cubeDepth - 1] = true;
                cube[w, cubeHeight - 1, 0] = true;
                cube[w, cubeHeight - 1, cubeDepth - 1] = true;
            }
            for (int h = 0; h < cubeHeight; h++)
            {
                cube[0, h, 0] = true;
                cube[0, h, cubeDepth - 1] = true;
                cube[cubeWidth - 1, h, 0] = true;
                cube[cubeWidth - 1, h, cubeDepth - 1] = true;
            }
            for (int d = 0; d < cubeDepth; d++)
            {
                cube[0, 0, d] = true;
                cube[0, cubeHeight - 1, d] = true;
                cube[cubeWidth - 1, 0, d] = true;
                cube[cubeWidth - 1, cubeHeight - 1, d] = true;
            }
            int currentWidth;
            int currenrHeight;
            int currentDepth;
   
            while (true)
            {
                currentWidth = nextWidth;
                currenrHeight = nextHeight;
                currentDepth = nextDepth;
                cube[currentWidth, currenrHeight, currentDepth] = true;
                if (nextWidth+dirWidth<0 || nextWidth+dirWidth>=cube.GetLength(0))
                {
                    dirWidth *= -1;
                }
                if (nextHeight + dirHeight < 0 || nextHeight + dirHeight >= cube.GetLength(1))
                {
                    dirHeight *= -1;
                }
                if (nextDepth + dirDepth < 0 || nextDepth + dirDepth >= cube.GetLength(2))
                {
                    dirDepth *= -1;
                }
                nextWidth += dirWidth;
                nextHeight += dirHeight;
                nextDepth += dirDepth;
                if (cube[nextWidth,nextHeight,nextDepth])
                {
                    break;
                }
            }
            Console.WriteLine("{0} {1} {2}",currentWidth+1,currenrHeight+1,currentDepth+1);
        }
    }
}
