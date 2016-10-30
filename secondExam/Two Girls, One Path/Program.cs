using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Girls__One_Path
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            long[] path = new long[input.Length];//4 17 4 2 7 11 3 2
            for (int index = 0; index < input.Length; index++)
            {
                path[index] = long.Parse(input[index]);
            }
            long moliPosition = 0;
            long moliFlower = path[moliPosition];
            long dolliPosition = path.Length - 1;
            long dolliFlower = path[dolliPosition];
            //bool moliEnd = false;
          //  bool dolliEnd = false;
            while (true)
            {
                moliPosition += path[moliPosition];
                if (moliPosition>path.Length)
                {
                    moliPosition %= path[moliPosition];
                }

            }
        }
    }
}
