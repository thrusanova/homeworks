//Write a method that calculates the number of workdays between today and given date, passed as parameter.
// Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Collections.Generic;
using System.Linq;
class WorkDays
    {
        static void Main()
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate);
            Console.WriteLine("Write date in this format month\\date\\year-2\\13\\2015");//the second slash is escaping symbol
            DateTime newDate = DateTime.Parse(Console.ReadLine());
             int countDays = Math.Abs((currentDate - newDate).Days);
            Console.WriteLine(CountWorkDays(currentDate,newDate,countDays));
        }
        static int CountWorkDays(DateTime currentDate, DateTime newDate, int lenght)
    {
        bool Holiday = false;
        int countWorkDays = 0;
        for (int i = 0; i < lenght; i++)
        {
            currentDate = currentDate.AddDays(1);
            if ((currentDate.DayOfWeek != DayOfWeek.Saturday) && (currentDate.DayOfWeek != DayOfWeek.Sunday))
            {
                for (int j = 0; j < Holidays().Length; j++)//cycle to chek if the current day is a Public Holiday
                {
                    if (currentDate == Holidays()[j])
                    {
                        Holiday = true;
                        break;
                    }
                }
                if (!Holiday)//if it is not holiday count one more work day
                {
                    countWorkDays++;
                }
                Holiday = false;//restart the boolen expresiion
            }
        }
        return countWorkDays;
    }
    static DateTime[] Holidays()
    {
        DateTime[] holidays = new DateTime[]{
        new DateTime(2015, 03, 03),
        new DateTime(2015, 03, 02),
        new DateTime(2015, 04, 11),
        new DateTime(2015, 04, 12)};
        return holidays;
    }


    }


 

        
       
       
       


