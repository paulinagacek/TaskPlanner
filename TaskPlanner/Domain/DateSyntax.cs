using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TaskPlanner.Utils
{
    public class DateSyntax
    {
        public List<string> weekDays { get; set; }
        public List<string> timeSlots { get; set; }

        public DateSyntax(List<string> weekDays, List<string> timeSlots)
        {
            this.weekDays = weekDays;
            this.timeSlots = timeSlots;
        }

        public List<string> getWeekdays()
        {
            return weekDays;
        }

        public List<string> getTimeSlots()
        {
            return timeSlots;
        }

        public int getNrOfWeekdays()
        {
            return weekDays.Count;
        }

        public int getNrOfTimeSlots()
        {
            return timeSlots.Count;
        }

        public DayOfWeek getDayOfTheWeekFromString(string day)
        {
            if (day == weekDays[0])
            {
                return DayOfWeek.Monday;
            }
            else if (day == weekDays[1])
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

        public DayOfWeek getDayOfTheWeekFromId(int id)
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

        public int getHourFromSlotLabel(int slotId)
        {
            Regex rx = new Regex(@"(?<digit>\d+)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            int hour = Int32.Parse(rx.Matches(getTimeSlots()[slotId - 1])[0].Groups["digit"].Value);
            if(Regex.Match(getTimeSlots()[slotId - 1], "PM").Success)
            {
                hour += 12;
            }
            return hour;
        }

        public int getMinutesFromSlotLabel(int slotId)
        {
            if(!Regex.Match(getTimeSlots()[slotId - 1], ":").Success)
            {
                return 0;
            }
            Regex rx = new Regex(@"(?<digit>\d+)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return Int32.Parse(rx.Matches(getTimeSlots()[slotId - 1])[1].Groups["digit"].Value);
        }
    }
}
