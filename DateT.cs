using System;
using System.Collections.Generic;
using System.Text;

namespace TemaDateTime
{
    public static class DateT
    {
        public static DateTime CurrentDateTime(this DateTime dateTime)
        {
            return DateTime.Now;
        }
     
        
        public static DateTime GetStart(this DateTime dateTime)
        {
            return dateTime.Date;
        }
        public static DateTime GetEnd(this DateTime dateTime)
        {
            return GetStart(dateTime).AddDays(1).AddTicks(-1);
        }

        public static DateTime FirstDayOfWeek(DateTime dt)
        {
            var culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            var diff = dt.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;
            if (diff < 0)
                diff += 7;
            return dt.AddDays(-diff).Date;
        }
    }
}
