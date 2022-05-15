using System.Windows.Forms;

namespace TaskPlanner
{
    public partial class WeeklyScheduler: UserControl
    {
        SchedulerHandler schedulerHandler = new SchedulerHandler();
        int NrOfTimeSlots = 48;
        public static WeeklyScheduler instance = null;
        public WeeklyScheduler()
        {
            InitializeComponent();
            for(int i = 1; i <= 7; i++)
            {
                tbl_time_table.Controls.Add(schedulerHandler.getWeekdayLabel(i-1), i, 0);
            }
            for(int i = 1; i < NrOfTimeSlots + 1; i++)
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
            tbl_time_table.Controls.Add(label, task.getWeekdayId(), task.getStartSlotId());
            tbl_time_table.SetRowSpan(label, task.getEndSlotId() - task.getStartSlotId() + 1);
            System.Console.WriteLine(task.getStartSlotId().ToString() + " to " + task.getEndSlotId().ToString());
        }
    }
}
