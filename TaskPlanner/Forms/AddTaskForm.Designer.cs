namespace TaskPlanner
{
    partial class AddTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbBox_end = new System.Windows.Forms.ComboBox();
            this.cmbBox_start = new System.Windows.Forms.ComboBox();
            this.lbl_end = new System.Windows.Forms.Label();
            this.lbl_start = new System.Windows.Forms.Label();
            this.cmbBox_day = new System.Windows.Forms.ComboBox();
            this.lbl_day = new System.Windows.Forms.Label();
            this.btn_saveTask = new System.Windows.Forms.Button();
            this.cmbBox_categories = new System.Windows.Forms.ComboBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_taskTitle = new System.Windows.Forms.Label();
            this.txtBox_taskTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbBox_end
            // 
            this.cmbBox_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbBox_end.FormattingEnabled = true;
            this.cmbBox_end.Location = new System.Drawing.Point(370, 478);
            this.cmbBox_end.Name = "cmbBox_end";
            this.cmbBox_end.Size = new System.Drawing.Size(174, 48);
            this.cmbBox_end.TabIndex = 21;
            this.cmbBox_end.SelectedIndexChanged += new System.EventHandler(this.cmbBox_end_SelectedIndexChanged_1);
            // 
            // cmbBox_start
            // 
            this.cmbBox_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbBox_start.FormattingEnabled = true;
            this.cmbBox_start.Location = new System.Drawing.Point(122, 478);
            this.cmbBox_start.Name = "cmbBox_start";
            this.cmbBox_start.Size = new System.Drawing.Size(174, 48);
            this.cmbBox_start.TabIndex = 20;
            this.cmbBox_start.SelectedIndexChanged += new System.EventHandler(this.cmbBox_start_SelectedIndexChanged);
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_end.Location = new System.Drawing.Point(363, 405);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(91, 40);
            this.lbl_end.TabIndex = 19;
            this.lbl_end.Text = "End:";
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_start.Location = new System.Drawing.Point(115, 405);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(103, 40);
            this.lbl_start.TabIndex = 18;
            this.lbl_start.Text = "Start:";
            // 
            // cmbBox_day
            // 
            this.cmbBox_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbBox_day.FormattingEnabled = true;
            this.cmbBox_day.Location = new System.Drawing.Point(372, 317);
            this.cmbBox_day.Name = "cmbBox_day";
            this.cmbBox_day.Size = new System.Drawing.Size(313, 48);
            this.cmbBox_day.TabIndex = 17;
            this.cmbBox_day.SelectedIndexChanged += new System.EventHandler(this.cmbBox_day_SelectedIndexChanged);
            // 
            // lbl_day
            // 
            this.lbl_day.AutoSize = true;
            this.lbl_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_day.Location = new System.Drawing.Point(114, 317);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.Size = new System.Drawing.Size(91, 40);
            this.lbl_day.TabIndex = 16;
            this.lbl_day.Text = "Day:";
            // 
            // btn_saveTask
            // 
            this.btn_saveTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_saveTask.Location = new System.Drawing.Point(584, 478);
            this.btn_saveTask.Name = "btn_saveTask";
            this.btn_saveTask.Size = new System.Drawing.Size(155, 77);
            this.btn_saveTask.TabIndex = 15;
            this.btn_saveTask.Text = "Add";
            this.btn_saveTask.UseVisualStyleBackColor = true;
            this.btn_saveTask.Click += new System.EventHandler(this.btn_saveTask_Click_1);
            // 
            // cmbBox_categories
            // 
            this.cmbBox_categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbBox_categories.FormattingEnabled = true;
            this.cmbBox_categories.Location = new System.Drawing.Point(372, 221);
            this.cmbBox_categories.Name = "cmbBox_categories";
            this.cmbBox_categories.Size = new System.Drawing.Size(313, 48);
            this.cmbBox_categories.TabIndex = 14;
            this.cmbBox_categories.SelectedIndexChanged += new System.EventHandler(this.cmbBox_categories_SelectedIndexChanged_1);
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_category.Location = new System.Drawing.Point(114, 221);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(173, 40);
            this.lbl_category.TabIndex = 13;
            this.lbl_category.Text = "Category:";
            // 
            // lbl_taskTitle
            // 
            this.lbl_taskTitle.AutoSize = true;
            this.lbl_taskTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_taskTitle.Location = new System.Drawing.Point(114, 129);
            this.lbl_taskTitle.Name = "lbl_taskTitle";
            this.lbl_taskTitle.Size = new System.Drawing.Size(95, 40);
            this.lbl_taskTitle.TabIndex = 12;
            this.lbl_taskTitle.Text = "Title:";
            // 
            // txtBox_taskTitle
            // 
            this.txtBox_taskTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBox_taskTitle.Location = new System.Drawing.Point(282, 129);
            this.txtBox_taskTitle.Name = "txtBox_taskTitle";
            this.txtBox_taskTitle.Size = new System.Drawing.Size(403, 48);
            this.txtBox_taskTitle.TabIndex = 11;
            this.txtBox_taskTitle.TextChanged += new System.EventHandler(this.txtBox_taskTitle_TextChanged_1);
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 649);
            this.Controls.Add(this.cmbBox_end);
            this.Controls.Add(this.cmbBox_start);
            this.Controls.Add(this.lbl_end);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.cmbBox_day);
            this.Controls.Add(this.lbl_day);
            this.Controls.Add(this.btn_saveTask);
            this.Controls.Add(this.cmbBox_categories);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_taskTitle);
            this.Controls.Add(this.txtBox_taskTitle);
            this.Name = "AddTaskForm";
            this.Text = "AddTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBox_end;
        private System.Windows.Forms.ComboBox cmbBox_start;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.ComboBox cmbBox_day;
        private System.Windows.Forms.Label lbl_day;
        private System.Windows.Forms.Button btn_saveTask;
        private System.Windows.Forms.ComboBox cmbBox_categories;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_taskTitle;
        private System.Windows.Forms.TextBox txtBox_taskTitle;
    }
}