using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private void InitialiseCategoriesColors()
        {
            categoryToColor["Job"] = Color.LightSalmon;
            categoryToColor["House"] = Color.Beige;
            categoryToColor["Hobby"] = Color.Lime;
            categoryToColor["Health"] = Color.Magenta;
            categoryToColor["Sport"] = Color.Yellow;
        }

        public static List<string> getCategories()
        {
            return categories;
        }
    }
}
