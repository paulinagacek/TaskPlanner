﻿using System;
using System.Windows.Forms;

namespace TaskPlanner
{
    public partial class AddTaskForm : Form
    {
        SchedulerHandler schedulerHandler;
        Task addedTask = new Task();
        int predefinedStartId = -1;
        int weekDayId = 0;

        public AddTaskForm(SchedulerHandler schedulerHandler)
        {
            InitializeComponent();
            this.schedulerHandler = schedulerHandler;
            InitialiseCmbBoxes();
            addedTask.dateSyntax = schedulerHandler.dateSyntax;
        }

        public AddTaskForm(SchedulerHandler schedulerHandler, int dayId, int StartId)
        {
            InitializeComponent();
            this.schedulerHandler = schedulerHandler;
            
            predefinedStartId = StartId;
            weekDayId = dayId;
            InitialiseCmbBoxes();
            addedTask.dateSyntax = schedulerHandler.dateSyntax;
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

            if(predefinedStartId >= 0)
            {
                cmbBox_start.Text = schedulerHandler.getTimeSlotString(predefinedStartId);
                cmbBox_end.Text = schedulerHandler.getTimeSlotString(predefinedStartId+1);
                cmbBox_day.Text = schedulerHandler.getDayString(weekDayId - 1);
            }
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
            if (addedTask.getEndSlotId() == -1 || addedTask.getStartSlotId() == -1 || addedTask.getWeekdayId() == 0)
            {
                return false;
            }
            return true;
        }

        private bool IsTimeSLotFree()
        {
            foreach(Task task in schedulerHandler.getTasks())
            {
                if(task.getWeekdayId() == addedTask.getWeekdayId())
                {
                    if(task.getStartSlotId() == addedTask.getStartSlotId())
                    {
                        return false;
                    }
                    if (task.getEndSlotId() == addedTask.getEndSlotId())
                    {
                        return false;
                    }
                    if(task.getStartSlotId() <= addedTask.getStartSlotId() && task.getEndSlotId() >= addedTask.getEndSlotId())
                    {
                        return false;
                    }
                    if (task.getStartSlotId() >= addedTask.getStartSlotId() && task.getEndSlotId() <= addedTask.getEndSlotId())
                    {
                        return false;
                    }
                }
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
            addedTask.setStartId(cmbBox_start.SelectedIndex);
        }

        private void cmbBox_end_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            addedTask.setEndId(cmbBox_end.SelectedIndex);
        }

        private void btn_saveTask_Click_1(object sender, EventArgs e)
        {
            if (AreAllFieldsSelected())
            {
                if(addedTask.getStartSlotId() < addedTask.getEndSlotId())
                {
                    if (IsTimeSLotFree())
                    {
                        schedulerHandler.AddTask(addedTask);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("There is already other task planned for provided time slot");
                    }
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
