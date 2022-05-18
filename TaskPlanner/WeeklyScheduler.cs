using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TaskPlanner
{
    public partial class WeeklyScheduler : UserControl
    {
        SchedulerHandler schedulerHandler = new SchedulerHandler();
        int NrOfTimeSlots = 48;
        int NrOfWeekDays = 7;
        public static WeeklyScheduler instance = null;
        public WeeklyScheduler()
        {
            InitializeComponent();
            for (int i = 1; i <= NrOfWeekDays; i++)
            {
                tbl_time_table.Controls.Add(schedulerHandler.getWeekdayLabel(i - 1), i, 0);
            }
            for (int i = 1; i < NrOfTimeSlots + 1; i++)
            {
                tbl_time_table.Controls.Add(schedulerHandler.getTimeSlotLabel(i - 1), 0, i);
            }
            InitialiseEmptyLabelsOnGrid();
            instance = this;
            //this.DoubleBuffered = true;
        }

        public void InitialiseEmptyLabelsOnGrid()
        {
            for(int i = 1; i <= NrOfTimeSlots; i++)
            {
                List<Label> emptyLabelRow = new List<Label>();
                for(int j = 1; j <= NrOfWeekDays; j++)
                {
                    Label label = new Label();
                    label.Dock = DockStyle.Fill;
                    label.BackColor = Color.Transparent;
                    label.Click += new EventHandler(this.OnEmptykLabelClick);
                    //label.MouseHover += new EventHandler(this.OnMouseHover);
                    //label.MouseLeave += new EventHandler(this.OnMouseLeave);
                    tbl_time_table.Controls.Add(label, j, i);
                    emptyLabelRow.Add(label);
                }
                schedulerHandler.emptyLabels.Add(emptyLabelRow);
            }
        }

        private void btn_add_task_Click(object sender, System.EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm(schedulerHandler);
            addTaskForm.Show();
        }

        public void drawTask(Task task)
        {
            Label label = new Label();
            label.Text = task.getTitle();
            label.Dock = DockStyle.Fill;
            label.BackColor = Task.getColorFromCategory(task.getCategory());
            label.Click += new EventHandler(this.OnTaskLabelClick);

            for(int i = task.getStartSlotId(); i < task.getEndSlotId(); ++i)
            {
                tbl_time_table.Controls.Remove(schedulerHandler.getEmptyLabel(
                    task.getWeekdayId()-1, i - 1));
            }
            tbl_time_table.Controls.Add(label, task.getWeekdayId(), task.getStartSlotId());
            tbl_time_table.SetRowSpan(label, task.getEndSlotId() - task.getStartSlotId());
            schedulerHandler.AddTaskLabel(task, label);
        }

        public void undrawTask(Label label)
        {
            tbl_time_table.Controls.Remove(label);
            Task task = schedulerHandler.getTaskFromLabel(label);
            for (int i = task.getStartSlotId(); i < task.getEndSlotId(); ++i)
            {
                tbl_time_table.Controls.Add(schedulerHandler.getEmptyLabel(
                    task.getWeekdayId() - 1, i - 1));
            }
            schedulerHandler.deleteTaskAndAssociatedLabel(label);
        }

        private void OnTaskLabelClick(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            string message = "Do you want to delete task:\n " + clickedLabel.Text + "?";
            string caption = "Delete task";
            var result = MessageBox.Show(message, caption,
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                undrawTask(clickedLabel);
                MessageBox.Show("Task was successfully deleted");
            }
        }

        private void OnEmptykLabelClick(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            int startId = getStartSlotIdFromEptyLabel(clickedLabel);
            int weekDayId = getWeekdayIdFromEptyLabel(clickedLabel);
            AddTaskForm addTaskForm = new AddTaskForm(schedulerHandler, weekDayId, startId);
            System.Console.WriteLine("Start id: " + startId);
            addTaskForm.Show();
        }

        private int getStartSlotIdFromEptyLabel(Label label)
        {
            for(int i = 0; i < schedulerHandler.emptyLabels.Count; i++)
            {
                for(int j = 0; j < schedulerHandler.emptyLabels[i].Count; j++)
                {
                    if(schedulerHandler.emptyLabels[i][j] == label)
                    {
                        return i + 1;
                    }
                }
            }
            return -1;
        }

        private int getWeekdayIdFromEptyLabel(Label label)
        {
            for (int i = 0; i < schedulerHandler.emptyLabels.Count; i++)
            {
                for (int j = 0; j < schedulerHandler.emptyLabels[i].Count; j++)
                {
                    if (schedulerHandler.emptyLabels[i][j] == label)
                    {
                        return j + 1;
                    }
                }
            }
            return -1;
        }

        private void OnMouseHover(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            clickedLabel.BackColor = Color.White;
            clickedLabel.Text = "+";
            clickedLabel.Font = new Font("Arial", 12);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            clickedLabel.BackColor = Color.Transparent;
            clickedLabel.Text = "";
        }

        private void WeeklyScheduler_Load(object sender, EventArgs e)
        {
            System.Threading.TimerCallback callback = new TimerCallback(schedulerHandler.ProcessTimerEvent);
            DayOfWeek wk = DateTime.Today.DayOfWeek;
            schedulerHandler.currentDayOfWeek = wk;

            var dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 0, 0);

            if (DateTime.Now < dt)
            {
                var timer = new System.Threading.Timer(callback, null, dt - DateTime.Now, TimeSpan.FromDays(7));
            }
        }
    }
}
