using System.Windows.Forms;

namespace TaskPlanner
{
    public partial class WeeklyScheduler: UserControl
    {
        SchedulerHandler schedulerHandler = new SchedulerHandler();
        int NrOfTimeSlots = 48;
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

        }

        private void pnl_timetable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_timetable_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void btn_add_task_Click(object sender, System.EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm(schedulerHandler);
            addTaskForm.Show();
        }
    }
}
