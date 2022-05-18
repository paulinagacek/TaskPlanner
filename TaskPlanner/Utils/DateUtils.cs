using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TaskPlanner.Utils
{
    public class DateUtils
    {
        static List<String> weekDays = new List<String>() { "Monday", "Tuesday", "Wednesday",
            "Thursday", "Friday", "Saturday", "Sunday" };

        public static List<String> getWeekdays()
        {
            return weekDays;
        }
        public static DateTime getDateTimeFromString(string date)
        {
            bool isPM = Regex.Match(date, @"PM").Success;
            bool isFull = !Regex.Match(date, @":").Success;
            if (isFull)
            {
                Match m = Regex.Match(date, @"\d+");
                Group g = m.Groups[0];
                System.Console.WriteLine(g);
            }
            else
            {

            }
            return DateTime.Parse(date);
        }

        public static DayOfWeek getDayOfTheWeekFromString(string day)
        {
            if(day == weekDays[0])
            {
                return DayOfWeek.Monday;
            }
            else if(day == weekDays[1])
            {
                return DayOfWeek.Tuesday;
            }
            else if (day == weekDays[2])
            {
                return DayOfWeek.Wednesday;
            }
            else if (day == weekDays[3])
            {
                return DayOfWeek.Thursday;
            }
            else if (day == weekDays[4])
            {
                return DayOfWeek.Friday;
            }
            else if (day == weekDays[5])
            {
                return DayOfWeek.Saturday;
            }
            else if (day == weekDays[6])
            {
                return DayOfWeek.Sunday;
            }
            return DayOfWeek.Monday;
        }

        public static DayOfWeek getDayOfTheWeekFromId(int id)
        {
            if (id == 1)
            {
                return DayOfWeek.Monday;
            }
            else if (id == 2)
            {
                return DayOfWeek.Tuesday;
            }
            else if (id == 3)
            {
                return DayOfWeek.Wednesday;
            }
            else if (id == 4)
            {
                return DayOfWeek.Thursday;
            }
            else if (id == 5)
            {
                return DayOfWeek.Friday;
            }
            else if (id == 6)
            {
                return DayOfWeek.Saturday;
            }
            else if (id == 7)
            {
                return DayOfWeek.Sunday;
            }
            return DayOfWeek.Monday;
        }
    }

}
