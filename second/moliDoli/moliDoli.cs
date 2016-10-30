using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace moliDoli
{
    class moliDoli
    {
        static void Main(string[] args)
        {
            //string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            BigInteger[] numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            int moliIbdex = 0;
            int doliIndex = numbers.Length-1;
         
            BigInteger totalMoliFlowers = 0;
            BigInteger totalDoliFlowers = 0;
            string winner = string.Empty;
            while (true)
            {
                if (numbers[moliIbdex]==0 || numbers[doliIndex]==0)
                {

                    if (numbers[moliIbdex]==0 && numbers[doliIndex]==0)
                    {
                        winner = "Draw";
                    }
                 else   if (numbers[moliIbdex] == 0)
                    {
                        winner="Dolly";
                    }
                    else if (numbers[doliIndex] == 0)
                    {
                        winner="Molly";
                    }
                    
                    totalMoliFlowers += numbers[moliIbdex];
                    totalDoliFlowers += numbers[doliIndex];
                    break;
                }
                BigInteger currMoliFlowers = numbers[moliIbdex];
                BigInteger currDoliFlowers = numbers[doliIndex];
                if (moliIbdex == doliIndex)
                {
                    numbers[moliIbdex] = currMoliFlowers % 2;
                    totalMoliFlowers += currMoliFlowers / 2;
                    totalDoliFlowers += currDoliFlowers / 2;
                }
                else
                {
                    numbers[moliIbdex] = 0;
                    numbers[doliIndex] = 0;
                    totalMoliFlowers += currMoliFlowers;
                    totalDoliFlowers += currDoliFlowers;
                }

              

                moliIbdex = (int)((moliIbdex + currMoliFlowers) % numbers.Length);
                doliIndex = (int)((doliIndex - currDoliFlowers) % numbers.Length);
                if (doliIndex<0)
                {
                    doliIndex += numbers.Length;
                }
              
            }
            Console.WriteLine(winner);
            Console.WriteLine("{0} {1}",totalMoliFlowers,totalDoliFlowers);
        }
    }
}
