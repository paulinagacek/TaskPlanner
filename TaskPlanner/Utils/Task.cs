using System;
using System.Collections.Generic;
using System.Drawing;

namespace TaskPlanner
{
    public class Task
    {
        string Title = null;
        string Category = null;
        int Weekday = 0; // from 1 to 7
        int TimeSlotStart = 0; // from 1 to 48
        int TimeSlotStop = 0; // from 1 to 48

        static List<string> categories = new List<string>() { "Job", "House", "Hobby", "Health", "Sport" };
        static Dictionary<string, Color> categoryToColor = new Dictionary<string, Color>();

        public Task() { }

        public Task(string title, string category, int weekDay, int start, int end)
        {
            if(categoryToColor.Count == 0)
            {
                InitialiseCategoriesColors();
            }
            this.Title = title;
            this.Category = category;
            this.Weekday = weekDay;
            this.TimeSlotStart = start;
            this.TimeSlotStop = end;
            ValidateData();
        }

        private void ValidateData()
        {
            if(Weekday < 1 || Weekday > 7)
            {
                throw new Exception("Wrong weekday");
            }
            if(TimeSlotStart < 1 || TimeSlotStop < 1 || TimeSlotStart > 48 || TimeSlotStop > 48)
            {
                throw new Exception("Wrong time slot");
            }
            if(TimeSlotStart > TimeSlotStop)
            {
                throw new Exception("Start cannot be after end");
            }
            
        }

        public static void InitialiseCategoriesColors()
        {
            categoryToColor["Job"] = Color.LightSalmon;
            categoryToColor["House"] = Color.Beige;
            categoryToColor["Hobby"] = Color.AliceBlue;
            categoryToColor["Health"] = Color.Magenta;
            categoryToColor["Sport"] = Color.Yellow;
        }

        public static List<string> getCategories()
        {
            return categories;
        }

        public string getTitle()
        {
            return Title;
        }

        public string getCategory()
        {
            return Category;
        }

        public int getWeekdayId()
        {
            return Weekday;
        }

        public int getStartSlotId()
        {
            return TimeSlotStart;
        }

        public int getEndSlotId()
        {
            return TimeSlotStop;
        }

        public static Color getColorFromCategory(string category)
        {
            System.Console.WriteLine(category);
            return categoryToColor[category];
        }

        public void setTitle(string title)
        {
            Title = title;
        }

        public void setCategory(string category)
        {
            Category = category;
        }

        public void setWeekdayId(int dayId)
        {
            Weekday = dayId;
        }

        public void setStartId(int startId)
        {
            TimeSlotStart = startId;
        }

        public void setEndId(int endId)
        {
            TimeSlotStop = endId;
        }
    }
}
