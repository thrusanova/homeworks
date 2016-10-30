//Write a program that reads two dates in the format:  day.month.year  and calculates the number of days between them.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace _16.DateDifference
{
    class DateDifference
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Enter a first date in  the current format:d.MM.yyyy");
            string firstDate = Console.ReadLine();
            DateTime first = DateTime.ParseExact(firstDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Enter a second date in  the current format:d.MM.yyyy");
            string secondDate = Console.ReadLine();
            DateTime second = DateTime.ParseExact(secondDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine((second - first).TotalDays+" days");
        }
    }
}