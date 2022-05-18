using System;
using System.Collections.Generic;

namespace TaskPlanner.Utils
{
    public class DateUtils
    {
        static List<String> weekDays = new List<String>() { "Monday", "Tuesday", "Wednesday",
            "Thursday", "Friday", "Saturday", "Sunday" };

        static List<String> timeSlots = new List<String>() { "12 AM","0:30 AM", "1 AM", "1:30 AM", "2 AM",
        "2:30 AM", "3 AM", "3:30 AM", "4 AM", "4:30 AM", "5AM", "5:30 AM", "6 AM", "6:30 AM",
        "7 AM", "7:30 AM", "8 AM", "8:30 AM", "9 AM", "9:30 AM", "10 AM", "10:30 AM", "11 AM",
        "11:30 AM", "12 PM",
        "12 PM","0:30 PM", "1 PM", "1:30 PM", "2 PM",
        "2:30 PM", "3 PM", "3:30 PM", "4 PM", "4:30 PM", "5PM", "5:30 PM", "6 PM", "6:30 PM",
        "7 PM", "7:30 PM", "8 PM", "8:30 PM", "9 PM", "9:30 PM", "10 PM", "10:30 PM", "11 PM",
        "11:30 PM"};

        public static List<String> getWeekdays()
        {
            return weekDays;
        }

        public static List<String> getTimeSlots()
        {
            return timeSlots;
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
