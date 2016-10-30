using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MollyDolly
{
    class Program
    {
        static void Main()
        {
            //input

            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            BigInteger[] flowers = new BigInteger[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                flowers[i] = BigInteger.Parse(input[i]);
            }

            //solve
            int moli = 0;
            BigInteger moliResult = 0;
            int doli = flowers.Length - 1;
            BigInteger doliResult = 0;

            string result = "";
            while (true)
            {
                if (flowers[moli]==0 && flowers[doli]==0)
                {
                    result = "Draw";
                    break;
                }
                else if (flowers[moli]==0 )
                {
                    result = "Dolly";
                    doliResult += flowers[doli];
                    break;
                }
                else if (flowers[doli] == 0)
                {
                    result = "Molly";
                    moliResult += flowers[moli];
                    break;
                }
                BigInteger pathMoli = flowers[moli];
                BigInteger pathDoli = flowers[doli];
                if (moli==doli)
                {
                    if (flowers[moli] %2==0)
                    {
                        moliResult += flowers[moli] / 2;
                        doliResult += flowers[moli] / 2;
                        flowers[moli] = 0;
                    }
                    else
                    {
                        moliResult += flowers[moli] / 2;
                        doliResult += flowers[moli] / 2;
                        flowers[moli] = 1;
                    }
                }
                else
                {
                    moliResult += flowers[moli];
                    flowers[moli] = 0;
                    doliResult += flowers[doli];
                    flowers[doli] = 0;
                }
                moli = (int)((moli + pathMoli) % flowers.Length);
                doli = (int)(doli - pathDoli % flowers.Length);
                if (doli<0)
                {
                    doli = flowers.Length + doli;
                }
            }
            Console.WriteLine(result);
            Console.WriteLine("{0} {1}",moliResult,doliResult);
        }
    }

}