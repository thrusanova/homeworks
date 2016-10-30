//Extend the previous program to support also subtraction and multiplication of polynomials.
using System;

    class SubtractingPolynomials
    {
       
            static void Main(string[] args)
        {
            Console.WriteLine("Enter two polynomials as a sequance of their coefficiens:"); 
            string firstPol = Console.ReadLine();
            string secondPol = Console.ReadLine();
            Console.WriteLine("Choose operation:substact or multiply?");
            string input = Console.ReadLine(); 
            if (input == "substract")
            {
                SubstractPolynom(firstPol, secondPol);
            }
            else
            {
                MultiplyPolynom(firstPol, secondPol);
            }
          
            Console.WriteLine();
        }
            
        static void SubstractPolynom(string first, string second)
        {
            int resLen;
            int indexOut;
            string tmp;
            if (first.Length >= second.Length)
            {
                resLen = first.Length;
                indexOut = second.Length;
                tmp = first;
            }
            else
            {
                resLen = second.Length;
                indexOut = first.Length;
                tmp = second;
            }

            int[] result = new int[resLen];
            for (int i = 0; i < indexOut; i++)
            {
                result[i] = Math.Abs((first[i] - '0') - (second[i] - '0'));
            }
            for (int j = indexOut; j < result.Length; j++)
            {
                result[j] = (tmp[j] - '0');
            }

            PrintPolynom(result);
        }
        static void MultiplyPolynom(string first, string second)
        {
            int resLen;
            int indexOut;
            string tmp;
            if (first.Length >= second.Length)
            {
                resLen = first.Length;
                indexOut = second.Length;
                tmp = first;
            }
            else
            {
                resLen = second.Length;
                indexOut = first.Length;
                tmp = second;
            }

            int[] result = new int[resLen];
            for (int i = 0; i < indexOut; i++)
            {
                result[i] = (first[i] - '0') * (second[i] - '0');
            }
            for (int j = indexOut; j < result.Length; j++)
            {
                result[j] = (tmp[j] - '0');
            }

            PrintPolynom(result);
        }
        static void PrintPolynom(int[] pol)
        {
            for (int i = pol.Length - 1; i > 0; i--)
            {
                if (pol[i] != 0)
                    Console.Write("{0}*x^{1} + ", pol[i], i);
            }

            Console.WriteLine(pol[0]);
        }
    }

