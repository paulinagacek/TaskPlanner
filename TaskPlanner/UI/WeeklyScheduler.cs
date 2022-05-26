using System;
using System.Collections.Generic;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace TaskPlanner
{
    public partial class WeeklyScheduler : UserControl
    {
        SchedulerHandler schedulerHandler = new SchedulerHandler();
        public static WeeklyScheduler instance = null;
        public WeeklyScheduler()
        {
            InitializeComponent();
            InitialiseLabelsOnGrid();
            instance = this;
        }

        public void InitialiseLabelsOnGrid()
        {
            tbl_time_table.Visible = false;
            PaintWeekdaysLabel(tableLayout_headers);
            PaintTimeSlotLabels(tbl_time_table);
            PaintEmptyLabels(tbl_time_table);
            tbl_time_table.Visible = true;
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

            for (int i = task.getStartSlotId(); i < task.getEndSlotId(); ++i)
            {
                tbl_time_table.Controls.Remove(schedulerHandler.getEmptyLabel(task.getWeekdayId()-1, i));
            }
            tbl_time_table.Controls.Add(label, task.getWeekdayId(), task.getStartSlotId());
            tbl_time_table.SetRowSpan(label, task.getEndSlotId() - task.getStartSlotId());
        }

        public void undrawTask(Label label)
        {
            tbl_time_table.Controls.Remove(label);
            Task task = schedulerHandler.getTaskFromLabel(label);
            for (int i = task.getStartSlotId(); i < task.getEndSlotId(); ++i)
            {
                tbl_time_table.Controls.Add(schedulerHandler.getEmptyLabel(task.getWeekdayId() - 1, i));
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
                        return i;
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
        private void WeeklyScheduler_Load(object sender, EventArgs e)
        {
            DayOfWeek wk = DateTime.Today.DayOfWeek;
            schedulerHandler.currentDayOfWeek = wk;

            System.Timers.Timer t = new System.Timers.Timer();
            t.Start();
            t.Interval = 1000*60; // one tick per 1min
            t.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() => {
                Task task = schedulerHandler.getTaskToRemind(DateTime.Now);
                if (task != null)
                {
                    MessageBox.Show("You have task to do now: " + task.getTitle());
                }
                else
                {
                    Console.WriteLine("No tasks for: "+ DateTime.Now);
                }
            }));
        }

        private void PaintWeekdaysLabel( TableLayoutPanel headers)
        {
            tableLayout_headers.ColumnCount = schedulerHandler.getNrOfDays() + 1;
            for (int i = 1; i <= schedulerHandler.getNrOfDays(); i++)
            {
                tableLayout_headers.Controls.Add(schedulerHandler.getWeekdayLabel(i - 1), i, 0);
            }
        }

        private void PaintTimeSlotLabels(TableLayoutPanel panel)
        {
            panel.RowCount = schedulerHandler.getNrOfTimeSlots();
            panel.ColumnCount = schedulerHandler.getNrOfDays() + 1;
            for (int i = 0; i < schedulerHandler.getNrOfTimeSlots(); i++)
            {
                panel.Controls.Add(schedulerHandler.getTimeSlotLabel(i), 0, i);
            }
        }

        private void PaintEmptyLabels(TableLayoutPanel panel)
        {
            for (int i = 0; i < schedulerHandler.getNrOfTimeSlots(); i++)
            {
                List<Label> emptyLabelRow = new List<Label>();
                for (int j = 1; j <= schedulerHandler.getNrOfDays(); j++)
                {
                    Label label = new Label();
                    label.Dock = DockStyle.Fill;
                    label.BackColor = Color.Transparent;
                    label.Click += new EventHandler(this.OnEmptykLabelClick);
                    panel.Controls.Add(label, j, i);
                    emptyLabelRow.Add(label);
                }
                schedulerHandler.emptyLabels.Add(emptyLabelRow);
            }
        }
    }
}
