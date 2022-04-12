using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClass
{
   public class Time 
    {
        //public class Time
         int year;
        int month;
        int date;
         int hour;
         int minute;
         int second;

        //public accessor methods
        public void 
            DisplayCurrentTimw()
        {
            System.Console.WriteLine("{0}/{1}/{2} {3}:{4}:{5}", month, date, year, hour, minute, second);
        }

        //constructor
        public Time (System.DateTime dt)
        {
            year = dt.Year;
            month = dt.Month;
            date = dt.Day;
            hour = dt.Hour;
            minute = dt.Minute;
            second = dt.Second;
        }
        
        
        //constructor
        public Time (string strTime)
        {
            Console.WriteLine(strTime);
        }
        public Time (int year, int month, int date, int hour, int minute, int second)
        {
            this.year = year;
            this.month = month;
            this.date = date;
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
    }
}
