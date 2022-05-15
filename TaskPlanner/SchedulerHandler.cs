using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskPlanner
{
    public class SchedulerHandler
    {
        List<String> weekDays = new List<String>() { "Monday", "Tuesday", "Wednesday", 
            "Thursday", "Friday", "Saturday", "Sunday" };
        List<String> timeSlots = new List<String>() { "12 AM","0:30 AM", "1 AM", "1:30 AM", "2 AM",
        "2:30 AM", "3 AM", "3:30 AM", "4 AM", "4:30 AM", "5AM", "5:30 AM", "6 AM", "6:30 AM",
        "7 AM", "7:30 AM", "8 AM", "8:30 AM", "9 AM", "9:30 AM", "10 AM", "10:30 AM", "11 AM",
        "11:30 AM", "12 PM",
        "12 PM","0:30 PM", "1 PM", "1:30 PM", "2 PM",
        "2:30 PM", "3 PM", "3:30 PM", "4 PM", "4:30 PM", "5PM", "5:30 PM", "6 PM", "6:30 PM",
        "7 PM", "7:30 PM", "8 PM", "8:30 PM", "9 PM", "9:30 PM", "10 PM", "10:30 PM", "11 PM",
        "11:30 PM"};
        List<Label> weekdaysLabels = new List<Label>();
        List<Label> timeSlotsLabels = new List<Label>();
        
        List<Task> tasks = new List<Task>();
        Dictionary<Task, Label> taskToLabel = new Dictionary<Task, Label>();    

        public SchedulerHandler()
        {
            InitialiseWeekdaysLabels();
            InitialiseTimeSLots();
        }

        private void InitialiseWeekdaysLabels()
        {
            foreach(var day in weekDays)
            {
                Label label = new Label();
                label.Text = day.ToString();
                weekdaysLabels.Add(label);
            }
        }

        private void InitialiseTimeSLots()
        {
            foreach(var time in timeSlots)
            {
                Label timeLabel = new Label();
                timeLabel.Text = time.ToString();
                timeSlotsLabels.Add(timeLabel);
            }
        }

        public Label getWeekdayLabel(int index)
        {
            if(index < 0 || index >= weekdaysLabels.Count)
            {
                return null;
            }
            return weekdaysLabels[index];
        }

        public Label getTimeSlotLabel(int index)
        {
            if (index < 0 || index >= timeSlotsLabels.Count)
            {
                return null;
            }
            return timeSlotsLabels[index];
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
            WeeklyScheduler.instance.drawTask(task);
        }

        public void AddTaskLabel(Task task, Label label)
        {
            taskToLabel.Add(task, label);
        }

        public List<string> getWeekdays()
        {
            return weekDays;
        }

        public List<string> getTimeSlots()
        {
            return timeSlots;  
        }

        public void deleteTaskAndAssociatedLabel(Label label)
        {
            string taskName = label.Text;
            foreach(var task in tasks)
            {
                if(task.getTitle() == taskName)
                {
                    taskToLabel.Remove(task);
                    tasks.Remove(task);
                    break;
                }
            }
        }
    }
}
