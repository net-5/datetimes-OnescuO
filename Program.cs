using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace TemaDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
           // Write a program to display the:
           // a) Current date and time
           // b) Current year
            //c) Month of year
            //d) Week number of the year
            //e) Weekday of the week
            //f) Day of year
            //g) Day of the month
            //h) Day of week
            //j) if the current year is a leap year or not
            Console.WriteLine(DateTime.Now.CurrentDateTime());

            DateTime now = DateTime.Now;
            Console.WriteLine($"The current year is: {now.Year} ");

            Console.WriteLine($"The current month is: {now.ToString("MMMM")}");

            CultureInfo myCI = new CultureInfo("en-US");
            Calendar myCal = myCI.Calendar;
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
            DateTime LastDay = new System.DateTime(DateTime.Now.Year, 12, 31);
            Console.WriteLine($"There are {myCal.GetWeekOfYear(LastDay, myCWR, myFirstDOW)} weeks in the current year ({LastDay.Year}).");

            Console.WriteLine($"Weekday of the week: {now.DayOfWeek}");

            Console.WriteLine($"Day of year: {now.DayOfYear}");

            Console.WriteLine($"Day of the month: {now.Day}");

            Console.WriteLine($"Day of week: {now.DayOfWeek}");

            if (DateTime.IsLeapYear(now.Year))
            {
                Console.WriteLine("The current year is leap");
            }
            else
            {
                Console.WriteLine("The current year is not leap");
            }
            //Write a program to add N year(s) to the current date and display the new date.
            DateTime newDate = now.AddYears(3);
            Console.WriteLine(newDate);
            //Write a program to display the date and time in a human-friendly string.
            Console.WriteLine($"The time is {DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss")}");
            //rite a program to add 5 seconds to the current time and print it to the console.
            DateTime date1 = new DateTime(2019 ,06, 26, 19, 56, 00);
            Console.WriteLine($"Original date: {date1}");
            DateTime date2 = date1.AddSeconds(5);
            Console.WriteLine($"Add 5 seconds: {date2}");
            //Write a program to get current time in milliseconds.
            string dateFormat = "dd/MM/yyyy hh:mm:ss.fffffff";
            Console.WriteLine("Current time in millisec: {0}",now.ToString(dateFormat));
            //Write a program that calculates the date six months from the current date.
            for (int ctr = 0; ctr <= 6; ctr++)
                Console.WriteLine(now.AddMonths(ctr).ToString("d"));
            //Write a program to get the first and last second of a day.
            DateTime today = new DateTime(2019, 06, 26);
            Console.WriteLine("Start : " + today.GetStart().ToString());
            Console.WriteLine("End : " + today.GetEnd().ToString());
            //Write a program to calculate two date difference in seconds.
            DateTime dateTime1 = new DateTime(2019, 06, 26);
            DateTime dateTime2 = new DateTime(2019, 06, 25);
            var diffInSeconds = (dateTime1 - dateTime2).TotalSeconds;
            Console.WriteLine(diffInSeconds);
            //Given a date of birth, calculate the age of a person.
            //Input: 10, 09, 1989
            //Output: 30
            string dateOfBirth = "10.09.1989";
            DateTime birthDate = DateTime.Parse(dateOfBirth);
            var age = now.Year - birthDate.Year;
            Console.WriteLine($"The age is : {age}");
            //Write a program to get the dates 30 days before and after from the current date, and display it to the console
            Console.WriteLine("The date of Today : {0}", now.ToString("dd/MM/yyyy"));
            Console.WriteLine("30 days after are :");
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"{now.ToString("dd/MM/yyyy")}");
                now = now.AddDays(1);
            }

            Console.WriteLine("30 days before are :");
            for (int i = 30; i >= 0; i--)
            {
                Console.WriteLine($"{now.ToString("dd/MM/yyyy")}");
                now = now.AddDays(-1);
            }
            //Write a program to calculate a number of days between two dates.
            DateTime start = new DateTime(2019, 06, 26);
            DateTime end = new DateTime(2018, 06, 26);

            TimeSpan difference = start - end;
            Console.WriteLine("Number of days between two dates: " + difference.Days);
            //Write a program to print yesterday, today, tomorrow.
            DateTime today1 = DateTime.Now;
            DateTime tomorrow = DateTime.Now.AddDays(1);
            DateTime yesterday = DateTime.Now.AddDays(-1);
            Console.WriteLine($"Yesterday: {yesterday}");
            Console.WriteLine($"Today: {today1}");
            Console.WriteLine($"Tomorrow: {tomorrow}");
            //Write program to print next 5 days starting from today.
            Console.WriteLine("Print next 5 days:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{now.ToString("dd/MM/yyyy")}");
                now = now.AddDays(1);
            }
            //Write a program to find the date of the first Monday of a given week
            DateTime d = new DateTime(2015, 12, 01);
            Console.WriteLine(" The formatted Date is : {0}", d.ToString("dd/MM/yyyy"));
            Console.WriteLine(" The first day of the week for the above date is : {0}\n", DateT.FirstDayOfWeek(d).ToString("dddd/MM/yyyy"));
            //Write a program to get days between two dates.
            DateTime start1 = new DateTime(2001, 02, 28);
            DateTime end1 = new DateTime(2000, 02, 02);

            TimeSpan getDays = start1 - end1;
            Console.WriteLine("Number of days between two dates: " + getDays.Days);
            Sunday();
            
     

            }
        ///Write a program to select all the Sundays of a specified year and display their dates
        public static void Sunday()
        {
            Console.WriteLine("Your date: MM/dd/yyyy");
            DateTime myDate = DateTime.Parse(Console.ReadLine());
            int year = myDate.Year;
            DateTime firstDay = new DateTime(year, 1, 1);
            while (year == firstDay.Year)
            {
                if (firstDay.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine($"Sunday : {firstDay.ToShortDateString()}");

                }
                firstDay = firstDay.AddDays(1);
            }
        }

        }
    }
