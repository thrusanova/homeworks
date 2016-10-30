//Write a method that adds two polynomials.
// Represent them as arrays of their coefficients.
//Example:
//x2 + 5 =  1 x2 +  0 x +  5  => { 5 ,  0 ,  1 }

using System;

    class AddingPolynomials
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two polynomials as a sequance of their coefficiens:"); 
            string firstPol = Console.ReadLine();
            string secondPol = Console.ReadLine();
            AddPolynom(firstPol, secondPol);
            Console.WriteLine();
        }
        static void AddPolynom(string first, string second)
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
                result[i] = (first[i] - '0') + (second[i] - '0');
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