﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaskPlanner
{
    public partial class AddTaskForm : Form
    {
        SchedulerHandler schedulerHandler;
        Task addedTask = new Task();

        public AddTaskForm(SchedulerHandler schedulerHandler)
        {
            InitializeComponent();
            this.schedulerHandler = schedulerHandler;
            InitialiseCmbBoxes();
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
            if (addedTask.getTitle() == null || addedTask.getTitle().Length == 0)
            {
                return false;
            }
            if (addedTask.getCategory() == null || addedTask.getCategory().Length == 0)
            {
                return false;
            }
            if (addedTask.getEndSlotId() == 0 || addedTask.getStartSlotId() == 0 || addedTask.getWeekdayId() == 0)
            {
                return false;
            }
            return true;
        }

        private void txtBox_taskTitle_TextChanged_1(object sender, EventArgs e)
        {
            addedTask.setTitle(txtBox_taskTitle.Text);
        }

        private void cmbBox_categories_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            addedTask.setCategory(Task.getCategories()[cmbBox_categories.SelectedIndex]);
        }

        private void cmbBox_day_SelectedIndexChanged(object sender, EventArgs e)
        {
            addedTask.setWeekdayId(cmbBox_day.SelectedIndex + 1);
        }

        private void cmbBox_start_SelectedIndexChanged(object sender, EventArgs e)
        {
            addedTask.setStartId(cmbBox_start.SelectedIndex + 1);
        }

        private void cmbBox_end_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            addedTask.setEndId(cmbBox_end.SelectedIndex + 1);
        }

        private void btn_saveTask_Click_1(object sender, EventArgs e)
        {
            if (AreAllFieldsSelected())
            {
                if(addedTask.getStartSlotId() < addedTask.getEndSlotId())
                {
                    schedulerHandler.AddTask(addedTask);
                    this.Close();
                }
                else if (addedTask.getStartSlotId() == addedTask.getEndSlotId())
                {
                    MessageBox.Show("Task cannot take 0 min");
                }
                else
                {
                    MessageBox.Show("Task cannot start after it ends");
                }
            }
            else
            {
                MessageBox.Show("All fields have to be filled");
            }
        }
    }
}
