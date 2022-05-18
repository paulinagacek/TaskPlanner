using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TaskPlanner.Utils;

namespace TaskPlanner
{
    public class SchedulerHandler
    {
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
        public List<List<Label>> emptyLabels = new List<List<Label>>();

        public DayOfWeek currentDayOfWeek = DayOfWeek.Monday;
        public DateTime currentDateTime = DateTime.Now;
        public Dictionary<DayOfWeek, HashSet<Task>> WeekdayToSetOfTasks = new Dictionary<DayOfWeek, HashSet<Task>>();

        public SchedulerHandler()
        {
            InitialiseWeekdaysLabels();
            InitialiseTimeSLots();
            Task.InitialiseCategoriesColors();
        }

        private void InitialiseWeekdaysLabels()
        {
            foreach(var day in DateUtils.getWeekdays())
            {
                Label label = new Label();
                label.Text = day.ToString();
                weekdaysLabels.Add(label);
            }
        }

        internal string getTimeSlotString(int slotId)
        {
            return timeSlots[slotId];
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

        public string getDayString(int dayId)
        {
            return DateUtils.getWeekdays()[dayId];
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
            AddTaskToWeekdayToTaskSetDict(task);
        }

        private void AddTaskToWeekdayToTaskSetDict(Task task)
        {
            string weekDay = getWeekdays()[task.getWeekdayId() - 1];
            DayOfWeek dayOfWeek = DateUtils.getDayOfTheWeekFromString(weekDay);
            if (WeekdayToSetOfTasks.ContainsKey(dayOfWeek)){
                WeekdayToSetOfTasks[dayOfWeek].Add(task);
            }
            else
            {
                WeekdayToSetOfTasks.Add(dayOfWeek, new HashSet<Task> { task });
            }
            System.Console.WriteLine("Task added on " + dayOfWeek);
        }

        public void AddTaskLabel(Task task, Label label)
        {
            taskToLabel.Add(task, label);
        }

        public List<string> getWeekdays()
        {
            return DateUtils.getWeekdays();
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
                    DayOfWeek dayOfWeek = DateUtils.getDayOfTheWeekFromId(task.getWeekdayId());
                    WeekdayToSetOfTasks[dayOfWeek].Remove(task);
                    break;
                }
            }
            
        }

        internal Task getTaskFromLabel(Label label)
        {
            foreach(var task in tasks)
            {
                if(task.getTitle() == label.Text)
                {
                    return task;
                }
            }
            return null;
        }

        public Label getEmptyLabel(int x, int y)
        {
            return emptyLabels[y][x];
        }

        public void ProcessTimerEvent(object obj)
        {
            MessageBox.Show("Hi Its Time");
        }
    }
}
