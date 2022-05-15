using System;
using System.Windows.Forms;

namespace TaskPlanner
{
    public partial class WeeklyScheduler : UserControl
    {
        SchedulerHandler schedulerHandler = new SchedulerHandler();
        int NrOfTimeSlots = 48;
        public static WeeklyScheduler instance = null;
        public WeeklyScheduler()
        {
            InitializeComponent();
            for (int i = 1; i <= 7; i++)
            {
                tbl_time_table.Controls.Add(schedulerHandler.getWeekdayLabel(i - 1), i, 0);
            }
            for (int i = 1; i < NrOfTimeSlots + 1; i++)
            {
                tbl_time_table.Controls.Add(schedulerHandler.getTimeSlotLabel(i - 1), 0, i);
            }
            instance = this;
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

            tbl_time_table.Controls.Add(label, task.getWeekdayId(), task.getStartSlotId());
            tbl_time_table.SetRowSpan(label, task.getEndSlotId() - task.getStartSlotId() + 1);
            schedulerHandler.AddTaskLabel(task, label);
        }

        public void undrawTask(Label label)
        {
            tbl_time_table.Controls.Remove(label);
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
    }
}
