namespace TaskPlanner
{
    partial class WeeklyScheduler
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_weeklyscheduler = new System.Windows.Forms.Label();
            this.pnl_Title = new System.Windows.Forms.Panel();
            this.btn_add_task = new System.Windows.Forms.Button();
            this.pnl_timetable = new System.Windows.Forms.Panel();
            this.tbl_time_table = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_headers = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_Title.SuspendLayout();
            this.pnl_timetable.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_weeklyscheduler
            // 
            this.lbl_weeklyscheduler.AutoSize = true;
            this.lbl_weeklyscheduler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_weeklyscheduler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_weeklyscheduler.Location = new System.Drawing.Point(35, 27);
            this.lbl_weeklyscheduler.Name = "lbl_weeklyscheduler";
            this.lbl_weeklyscheduler.Size = new System.Drawing.Size(391, 55);
            this.lbl_weeklyscheduler.TabIndex = 0;
            this.lbl_weeklyscheduler.Text = "Week Scheduler";
            // 
            // pnl_Title
            // 
            this.pnl_Title.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_Title.Controls.Add(this.btn_add_task);
            this.pnl_Title.Controls.Add(this.lbl_weeklyscheduler);
            this.pnl_Title.Location = new System.Drawing.Point(0, 0);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(2008, 104);
            this.pnl_Title.TabIndex = 1;
            // 
            // btn_add_task
            // 
            this.btn_add_task.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add_task.FlatAppearance.BorderSize = 0;
            this.btn_add_task.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_task.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_add_task.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_task.Location = new System.Drawing.Point(1820, 6);
            this.btn_add_task.Name = "btn_add_task";
            this.btn_add_task.Size = new System.Drawing.Size(86, 98);
            this.btn_add_task.TabIndex = 1;
            this.btn_add_task.Text = "+";
            this.btn_add_task.UseVisualStyleBackColor = false;
            this.btn_add_task.Click += new System.EventHandler(this.btn_add_task_Click);
            // 
            // pnl_timetable
            // 
            this.pnl_timetable.AutoScroll = true;
            this.pnl_timetable.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_timetable.Controls.Add(this.tbl_time_table);
            this.pnl_timetable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_timetable.Location = new System.Drawing.Point(0, 196);
            this.pnl_timetable.Name = "pnl_timetable";
            this.pnl_timetable.Size = new System.Drawing.Size(1993, 998);
            this.pnl_timetable.TabIndex = 2;
            // 
            // tbl_time_table
            // 
            this.tbl_time_table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tbl_time_table.BackColor = System.Drawing.SystemColors.Control;
            this.tbl_time_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tbl_time_table.ColumnCount = 8;
            this.tbl_time_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.772489F));
            this.tbl_time_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.92658F));
            this.tbl_time_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.92658F));
            this.tbl_time_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.92658F));
            this.tbl_time_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.92658F));
            this.tbl_time_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.92658F));
            this.tbl_time_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.92658F));
            this.tbl_time_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.66805F));
            this.tbl_time_table.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbl_time_table.Location = new System.Drawing.Point(0, 0);
            this.tbl_time_table.Name = "tbl_time_table";
            this.tbl_time_table.RowCount = 49;
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.909787F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.842558F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.842558F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.842558F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.842558F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.808363F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.242371F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.047287F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.837952F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.939858F));
            this.tbl_time_table.Size = new System.Drawing.Size(1942, 2686);
            this.tbl_time_table.TabIndex = 3;
            this.tbl_time_table.Paint += new System.Windows.Forms.PaintEventHandler(this.tbl_time_table_Paint);
            // 
            // tableLayout_headers
            // 
            this.tableLayout_headers.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableLayout_headers.ColumnCount = 8;
            this.tableLayout_headers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.90099F));
            this.tableLayout_headers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.87129F));
            this.tableLayout_headers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.87129F));
            this.tableLayout_headers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.87129F));
            this.tableLayout_headers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.87129F));
            this.tableLayout_headers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.87129F));
            this.tableLayout_headers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.87129F));
            this.tableLayout_headers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.87129F));
            this.tableLayout_headers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableLayout_headers.Location = new System.Drawing.Point(3, 110);
            this.tableLayout_headers.Name = "tableLayout_headers";
            this.tableLayout_headers.RowCount = 1;
            this.tableLayout_headers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_headers.Size = new System.Drawing.Size(1941, 80);
            this.tableLayout_headers.TabIndex = 3;
            this.tableLayout_headers.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayout_headers_Paint);
            // 
            // WeeklyScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayout_headers);
            this.Controls.Add(this.pnl_timetable);
            this.Controls.Add(this.pnl_Title);
            this.Name = "WeeklyScheduler";
            this.Size = new System.Drawing.Size(1993, 1194);
            this.Load += new System.EventHandler(this.WeeklyScheduler_Load);
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            this.pnl_timetable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_weeklyscheduler;
        private System.Windows.Forms.Panel pnl_Title;
        private System.Windows.Forms.Panel pnl_timetable;
        private System.Windows.Forms.TableLayoutPanel tbl_time_table;
        private System.Windows.Forms.Button btn_add_task;
        private System.Windows.Forms.TableLayoutPanel tableLayout_headers;
    }
}
