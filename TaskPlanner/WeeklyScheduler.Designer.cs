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
            this.pnl_timetable = new System.Windows.Forms.Panel();
            this.tbl_time_table = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_Title.SuspendLayout();
            this.pnl_timetable.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_weeklyscheduler
            // 
            this.lbl_weeklyscheduler.AutoSize = true;
            this.lbl_weeklyscheduler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_weeklyscheduler.Location = new System.Drawing.Point(35, 27);
            this.lbl_weeklyscheduler.Name = "lbl_weeklyscheduler";
            this.lbl_weeklyscheduler.Size = new System.Drawing.Size(391, 55);
            this.lbl_weeklyscheduler.TabIndex = 0;
            this.lbl_weeklyscheduler.Text = "Week Scheduler";
            // 
            // pnl_Title
            // 
            this.pnl_Title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Title.Controls.Add(this.lbl_weeklyscheduler);
            this.pnl_Title.Location = new System.Drawing.Point(4, 4);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(1986, 100);
            this.pnl_Title.TabIndex = 1;
            // 
            // pnl_timetable
            // 
            this.pnl_timetable.AutoScroll = true;
            this.pnl_timetable.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_timetable.Controls.Add(this.tbl_time_table);
            this.pnl_timetable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_timetable.Location = new System.Drawing.Point(0, 110);
            this.pnl_timetable.Name = "pnl_timetable";
            this.pnl_timetable.Size = new System.Drawing.Size(1993, 1084);
            this.pnl_timetable.TabIndex = 2;
            this.pnl_timetable.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnl_timetable_Scroll);
            this.pnl_timetable.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_timetable_Paint);
            // 
            // tbl_time_table
            // 
            this.tbl_time_table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tbl_time_table.BackColor = System.Drawing.SystemColors.Control;
            this.tbl_time_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tbl_time_table.ColumnCount = 8;
            this.tbl_time_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.671955F));
            this.tbl_time_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.22751F));
            this.tbl_time_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.22751F));
            this.tbl_time_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.22751F));
            this.tbl_time_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.22751F));
            this.tbl_time_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.22751F));
            this.tbl_time_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.22751F));
            this.tbl_time_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.96296F));
            this.tbl_time_table.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbl_time_table.Location = new System.Drawing.Point(0, 0);
            this.tbl_time_table.Name = "tbl_time_table";
            this.tbl_time_table.RowCount = 49;
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.899683F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.899683F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.899683F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.899683F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.899683F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.864428F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.311891F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.110759F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.894934F));
            this.tbl_time_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_time_table.Size = new System.Drawing.Size(1942, 2686);
            this.tbl_time_table.TabIndex = 3;
            // 
            // WeeklyScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_timetable);
            this.Controls.Add(this.pnl_Title);
            this.Name = "WeeklyScheduler";
            this.Size = new System.Drawing.Size(1993, 1194);
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
    }
}
