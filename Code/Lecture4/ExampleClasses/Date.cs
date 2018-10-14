using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3.ExampleClasses
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        // Default constructor
        public Date()
        {
            day = 1;
            month = 1;
            year = 1;
        }
        // Copy constructor
        public Date(Date d)
        {
            day = d.day;
            month = d.month;
            year = d.year;
        }

        private static bool IsValidDate(int day, int month, int year)
        {
            // do some checks
            //something basic (and not entirely correct!) could be:
            if (day > 0 && day <= 31 && month > 0 && month <= 12 && year > 0)
            {
                return true;
            }
            return false;
        }

        public static Date CreateDate(int day, int month, int year)
        {
            Date d = new Date();
            if (IsValidDate(day, month, year))
            {
                d.day = day; d.month = month; d.year = year;
                return d;
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("Invalid date!");
            }
        }

        public int GetDayOfMonth()
        {
            return day;
        }

        public void SetDayOfMonth(int inputDay)
        {
            if (IsValidDate(inputDay, this.month, this.year))
            {
                day = inputDay;
            }
            else
                throw new System.ArgumentOutOfRangeException("Invalid date!");
        }
    }
}
