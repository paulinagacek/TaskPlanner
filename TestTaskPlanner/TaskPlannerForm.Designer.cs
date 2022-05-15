namespace TestTaskPlanner
{
    partial class TaskPlannerForm
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.weeklyScheduler1 = new TaskPlanner.WeeklyScheduler();
            this.SuspendLayout();
            // 
            // weeklyScheduler1
            // 
            this.weeklyScheduler1.Location = new System.Drawing.Point(42, 36);
            this.weeklyScheduler1.Name = "weeklyScheduler1";
            this.weeklyScheduler1.Size = new System.Drawing.Size(2000, 1194);
            this.weeklyScheduler1.TabIndex = 0;
            // 
            // TaskPlannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2199, 1321);
            this.Controls.Add(this.weeklyScheduler1);
            this.Name = "TaskPlannerForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private TaskPlanner.WeeklyScheduler weeklyScheduler1;
    }
}

