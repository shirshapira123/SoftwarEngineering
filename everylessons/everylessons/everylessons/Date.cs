using System;
using System.Collections.Generic;
using System.Text;

namespace everylessons
{
    class Date
    {
        int year, month, day;
        public Date (int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        
        public int GetYear() => year;
        public int GetMonth() => month;
        public int GetDay() => day;
        public void SetYear(int year)
        {
            this.year = year;
        }
        public void SetMonth(int month)
        {
            this.month = month;
        }
        public void SetDay(int day)
        {
            this.day = day;
        }
        public int CompareTo(Date other)
        {
            int checkYear = year - other.GetYear();
            int checkMonth = month - other.GetMonth();
            int checkDay = day - other.GetDay();
            if (checkYear != 0)
                return checkYear;
            if (checkMonth != 0)
                return checkMonth;
            return checkDay;
        }
        public override string ToString() => (day + "." + month + "." + year);
    }
}
