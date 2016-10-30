using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diff
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var digit = new List<long>();
            var result = new List<long>();
            bool isDif = false;
            for (int i = 0; i < n; i++)
            {
                string [] line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
               // int num = int.Parse(line[0]);
                for (int j = 0; j < line.Length; j++)

   
                {
                    int number = int.Parse(line[j]);
                    digit.Add(number);
                }
                    for (int c = 0; c < digit.Count-1; c++)
                    {
                        long dif = Math.Abs(digit[c] - digit[c + 1]);
                        result.Add(dif);
                       
                    }
                    for (int k = 0; k < result.Count - 1; k++)
                    {
                        if (result[k] >= result[k + 1])
                        {
                            if (Math.Abs(result[k]-result[k+1])>1)
                            {
                                isDif = false;
                                break;
                            }
                            else
                            {
                                isDif = true;
                            }
                                                    
                        }

                        else
                        {
                            isDif = false;
                            

                        }
                    }
                            if (isDif==true)
                            {
                                Console.WriteLine("True");
                            }
                            else
                            {
                                Console.WriteLine("False");
                            }

                            digit.Clear();
                            result.Clear();
                    
                   
                }

            }

        }
    }

