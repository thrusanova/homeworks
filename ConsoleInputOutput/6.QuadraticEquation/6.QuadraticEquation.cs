//Write a program that reads the coefficients  a ,  b  and  c  of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
using System;
    class QuadraticEquation
    {
        static void Main()
        {           
            double a = double.Parse(Console.ReadLine());    
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double D = Math.Sqrt(b * b -4 * a * c);
            double x1;
            double x2;
            if (D > 0)//     D>0 – уравнението има два реални корена, които намираме по формулите:
            {
                x1 = (-b + D) / (2 * a);
                x2 = (-b - D) / (2 * a);
                Console.WriteLine("{0:F2}",x2);
                Console.WriteLine("{0:F2}",x1);
            }
            else if (D == 0)//   D = 0 – уравнението има един двоен корен, който намираме по формулата:x = -b/2a
            {
                x1 = x2 = -b / (2 * a);
                Console.WriteLine("{0:F2}",x1);
            }
            else
            {
                Console.WriteLine("no real roots");//   D < 0 – уравнението няма реални корени
            }
        }
    }










 

