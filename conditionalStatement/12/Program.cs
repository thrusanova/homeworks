using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] numbers = Console.ReadLine().Split(' ');
            int a = int.Parse(numbers[0]);
            int b = int.Parse((numbers[1]));
            int c = int.Parse(numbers[2]);
            int d = int.Parse(numbers[3]);
            int e = int.Parse(numbers[4]);

            if (a + b == 0)
            {
                Console.WriteLine("{0}+{1}=0", a, b);
            }
            else if (a + c == 0)
            {
                Console.WriteLine("{0}+{1}=0", a, c);
            }
            else if (a + d == 0)
            {
                Console.WriteLine("{0}+{1}=0", a, d);
            }
            else if (a + e == 0)
            {
                Console.WriteLine("{0}+{1}=0", a, e);
            }
            else    if (b + c == 0)
            {
                Console.WriteLine("{0}+{1}=0", b, c);
            }
            else if (b + d == 0)
            {
                Console.WriteLine("{0}+{1}=0", b, d);
            }
            else if (b + e == 0)
            {
                Console.WriteLine("{0}+{1}=0", b, e);
            }
            else if (c + e == 0)
            {
                Console.WriteLine("{0}+{1}=0", c, e);
            }
            else if (c + d == 0)
            {
                Console.WriteLine("{0}+{1}=0", c, d);
            }
            if (d + e == 0)
            {
                Console.WriteLine("{0}+{1}=0", d, e);
            }
            else if (a + b + c == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", a, b,c);
            }
            else if (a + b + d == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", a, b, d);
            }
            else if (a + b + e == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", a, b, e);
            }
            else if (a + c + d == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", a,c,d);
            }
            else if (a + c + e == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", a, c,e);
            }
            else if (b + d + c == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", b, d,c);
            }
            else if (b + e + d == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", b, e,d);
            }
            else if (c + e + b == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", c, e,b);
            }
            else if (c + d + e == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", c, d,e);
            }
            else if (a + d + e == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", a,d, e);
            }
            else if (a + b + c + d == 0)
            {
                Console.WriteLine("{0}+{1}+{2}+{3}=0", a, b,c,d);
            }
            else if (a + b + c + e == 0)
            {
                Console.WriteLine("{0}+{1}+{2}+{3}=0", a, b, c, e);
            }
            else if (a + b + d + e == 0)
            {
                Console.WriteLine("{0}+{1}+{2}+{3}=0", a, b, d, e);
            }
            else if (a + d + c + e == 0)
            {
                Console.WriteLine("{0}+{1}+{2}+{3}=0", a, d, c, e);
            }
            else if (d + b + c + e == 0)
            {
                Console.WriteLine("{0}+{1}+{2}+{3}=0", d, b, c, e);
            }
            else if (a + b + c + e + d == 0)
            {
                Console.WriteLine("{0}+{1}+{2}+{3}+{4}=0", a, b, c, e,d);
            }
            else if (a == 0)
            {
                Console.WriteLine("{0}=0",a);
            }
            else if (b == 0)
            {
                Console.WriteLine("{0}=0", b);
            }
            else if (c == 0)
            {
                Console.WriteLine("{0}=0", c);
            }
            else if (d == 0)
            {
                Console.WriteLine("{0}=0", d);
            }
            else if (e == 0)
            {
                Console.WriteLine("{0}=0", e);
            }
            else
            {
                Console.WriteLine("no zero subset");
            }
        }
    }
}
