using System;

namespace Task01._2
{
    class DateYears
    {
        private int year = 0;
        public DateYears(int year)
        {
            this.year = year;
        }

        public int GetSet { get { return year; } set { year = value; } }

        public string CheckForLeap (int year)
        {
            if (year != 0 && year % 4 == 0)
            {
                return "The year is leap";
            }
            else
            {
                return "The year is not leap";
            }
        }


    }
}
