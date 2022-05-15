using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaskPlanner
{
    public partial class AddTaskForm : Form
    {
        SchedulerHandler schedulerHandler;
        string Title = null;
        string Category = null;
        int dayId = 0;
        int startId = 0;
        int endId = 0;
        public AddTaskForm(SchedulerHandler schedulerHandler)
        {
            InitializeComponent();
            this.schedulerHandler = schedulerHandler;
            InitialiseCmbBoxes();
            System.Console.WriteLine("New object");
        }
        private void InitialiseCmbBoxes()
        {
            foreach(var category in Task.getCategories())
            {
                cmbBox_categories.Items.Add(category);
            }

            foreach (var day in schedulerHandler.getWeekdays())
            {
                cmbBox_day.Items.Add(day);
            }

            foreach (var slot in schedulerHandler.getTimeSlots())
            {
                cmbBox_start.Items.Add(slot);
            }

            foreach (var slot in schedulerHandler.getTimeSlots())
            {
                cmbBox_end.Items.Add(slot);
            }

            cmbBox_categories.Text = "";
            cmbBox_day.Text = "";
            cmbBox_start.Text = "";
            cmbBox_end.Text = "";
        }
        private bool AreAllFieldsSelected()
        {
            if (Title == null || Title.Length == 0 || Category == null || Category.Length == 0)
            {
                System.Console.WriteLine("napis null");
                return false;
            }
            if (startId == 0 || endId == 0 || dayId == 0)
            {
                System.Console.WriteLine("id 0");
                return false;
            }
            return true;
        }

        private void txtBox_taskTitle_TextChanged_1(object sender, EventArgs e)
        {
            Title = txtBox_taskTitle.Text;
        }

        private void cmbBox_categories_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Category = Task.getCategories()[cmbBox_categories.SelectedIndex];
            System.Console.WriteLine(Category);
        }

        private void cmbBox_day_SelectedIndexChanged(object sender, EventArgs e)
        {
            dayId = cmbBox_day.SelectedIndex + 1;
        }

        private void cmbBox_start_SelectedIndexChanged(object sender, EventArgs e)
        {
            startId = cmbBox_start.SelectedIndex + 1;
        }

        private void cmbBox_end_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            endId = cmbBox_end.SelectedIndex + 1;
        }

        private void btn_saveTask_Click_1(object sender, EventArgs e)
        {
            if (AreAllFieldsSelected())
            {
                Task task = new Task(Title, Category, dayId, startId, endId);
                schedulerHandler.AddTask(task);
                this.Close();
            }
            else
            {
                MessageBox.Show("All fields have to be filled");
            }
        }
    }
}
