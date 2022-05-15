using System;
using System.Collections.Generic;
using System.Drawing;
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
                    label.MouseHover += new EventHandler(this.OnMouseHover);
                    label.MouseLeave += new EventHandler(this.OnMouseLeave);
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
            MessageBox.Show("Click");
        }

        private void OnMouseHover(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            clickedLabel.BackColor = Color.White;
            clickedLabel.Text = "+";
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            clickedLabel.BackColor = Color.Transparent;
            clickedLabel.Text = "";
        }
    }
}
