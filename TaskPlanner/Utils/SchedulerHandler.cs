using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TaskPlanner.Utils;

namespace TaskPlanner
{
    public class SchedulerHandler
    {
        List<Label> weekdaysLabels = new List<Label>();
        List<Label> timeSlotsLabels = new List<Label>();
        
        List<Task> tasks = new List<Task>();
        Dictionary<Task, Label> taskToLabel = new Dictionary<Task, Label>();
        public List<List<Label>> emptyLabels = new List<List<Label>>();

        public DayOfWeek currentDayOfWeek = DayOfWeek.Monday;
        public DateTime currentDateTime = DateTime.Now;
        public Dictionary<DayOfWeek, HashSet<Task>> WeekdayToSetOfTasks = new Dictionary<DayOfWeek, HashSet<Task>>();

        const string configFile = "C:\\Users\\pauli\\OneDrive\\Pulpit\\4tySEM\\TaskPlanner\\TaskPlanner\\Utils\\configDateSyntax.json";
        DateSyntax dateSyntax;

        public SchedulerHandler()
        {
            dateSyntax = JsonExtensions.ToObject<DateSyntax>(JsonExtensions.ReadFileToString(configFile));
            InitialiseWeekdaysLabels();
            InitialiseTimeSLots();
            Task.InitialiseCategoriesColors();
        }

        private void InitialiseWeekdaysLabels()
        {
            foreach(var day in dateSyntax.getWeekdays())
            {
                Label label = new Label();
                label.Text = day.ToString();
                weekdaysLabels.Add(label);
            }
        }

        private void InitialiseTimeSLots()
        {
            foreach (var time in dateSyntax.getTimeSlots())
            {
                Label timeLabel = new Label();
                timeLabel.Text = time.ToString();
                timeSlotsLabels.Add(timeLabel);
            }
        }

        internal string getTimeSlotString(int slotId)
        {
            return dateSyntax.getTimeSlots()[slotId];
        }

        public string getDayString(int dayId)
        {
            return dateSyntax.getWeekdays()[dayId];
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
            DayOfWeek dayOfWeek = dateSyntax.getDayOfTheWeekFromString(weekDay);
            if (WeekdayToSetOfTasks.ContainsKey(dayOfWeek)){
                WeekdayToSetOfTasks[dayOfWeek].Add(task);
            }
            else
            {
                WeekdayToSetOfTasks.Add(dayOfWeek, new HashSet<Task> { task });
            }
        }

        public void AddTaskLabel(Task task, Label label)
        {
            taskToLabel.Add(task, label);
        }

        public List<string> getWeekdays()
        {
            return dateSyntax.getWeekdays();
        }

        public List<string> getTimeSlots()
        {
            return dateSyntax.getTimeSlots();  
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
                    DayOfWeek dayOfWeek = dateSyntax.getDayOfTheWeekFromId(task.getWeekdayId());
                    if(WeekdayToSetOfTasks.ContainsKey(dayOfWeek) && WeekdayToSetOfTasks[dayOfWeek].Contains(task))
                    {
                        WeekdayToSetOfTasks[dayOfWeek].Remove(task);
                    }
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

        public Task getTaskToRemind(DateTime currentTime)
        {
            if (WeekdayToSetOfTasks.ContainsKey(currentDayOfWeek))
            {
                int hour = currentTime.Hour;
                int minute = currentTime.Minute;
                foreach(Task task in WeekdayToSetOfTasks[currentDayOfWeek])
                {
                    if(hour == (task.getStartSlotId() - 1) / 2)
                    {
                        if((minute == 0 && (task.getStartSlotId()-1) %2 == 0)
                            || (minute == 30 && (task.getStartSlotId()-1) % 2 == 1))
                        {
                            WeekdayToSetOfTasks[currentDayOfWeek].Remove(task);
                            return task;
                        }
                    }
                }
                return null;
            }
            else
            {
                return null;
            }
        }

        public int getNrOfDays()
        {
            return dateSyntax.getNrOfWeekdays();
        }

        public int getNrOfTimeSlots()
        {
            return dateSyntax.getNrOfTimeSlots();
        }
    }
}
