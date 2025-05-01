using System;
using System.Media;
using System.Windows.Forms;


namespace Lab9
{
    class MyDate
    {
        private int day;
        private int month;
        private int year;

        private bool IsValidDate(int d, int m, int y)
        {
            string dateStr = y + "-" + m + "-" + d;
            DateTime tempDate;
            return DateTime.TryParse(dateStr, out tempDate);
        }

        public int Day
        {
            get { return day; }
            set
            {
                if (!IsValidDate(value, month, year))
                    throw new ArgumentException("Недопустимий день.");
                day = value;
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentException("Місяць має бути від 1 до 12.");
                if (!IsValidDate(day, value, year))
                    throw new ArgumentException("Недопустимий місяць для заданого дня.");
                month = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (!IsValidDate(day, month, value))
                    throw new ArgumentException("Недопустимий рік.");
                year = value;
            }
        }
        public int CountDays
        {
            get
            {
                return day + month * 30 + year * 12 * 30;
            }
        }

        public MyDate(int d, int m, int y)
        {
            if (!IsValidDate(d, m, y))
                throw new ArgumentException("Неправильна дата.");

            day = d;
            month = m;
            year = y;
        }

        public MyDate()
        {
            DateTime now = DateTime.Now;
            day = now.Day;
            month = now.Month;
            year = now.Year;
        }

        public MyDate(int d) : this(d, DateTime.Now.Month, DateTime.Now.Year) { }

        public MyDate(int d, int m) : this(d, m, DateTime.Now.Year) { }

        public void AddDays(int days)
        {
            DateTime current = new DateTime(year, month, day);
            DateTime newDate = current.AddDays(days);
            Day = newDate.Day;
            Month = newDate.Month;
            Year = newDate.Year;
            
        }

        public void AddMonths(int months)
        {
            DateTime current = new DateTime(year, month, day);
            DateTime newDate = current.AddMonths(months);
            Day = newDate.Day;
            Month = newDate.Month;  
            Year = newDate.Year;
        }

        public void AddYears(int years)
        {
            DateTime current = new DateTime(year, month, day);
            DateTime newDate = current.AddYears(years);
            Day = newDate.Day;
            Month = newDate.Month;
            Year = newDate.Year;
        }

        public override string ToString()
        {
            string dayStr = day.ToString("D2");
            string monthStr = month.ToString("D2");
            string yearStr = year.ToString();
            return dayStr + "." + monthStr + "." + yearStr;
        }
    }
}
