//пишете програма, която пресмята N!*K!/(N-K)! за дадени N и K (1<K<N).
using System;

    class Factoriel

    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
           long result =1;
           long result2 =1;
           long finalResult;
        
            for (int i = (N-K+1); i <= N;i++)
            {
                result *= i;
              
            }
            for (int j = 1; j <= K; j++)
                {
                    result2 *= j;
                }

            finalResult = result * result2;
            Console.WriteLine(finalResult);
        }
    }
