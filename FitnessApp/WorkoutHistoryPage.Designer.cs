namespace FitnessApp
{
    partial class WorkoutHistoryPage
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

        private void InitializeComponent()
        {
            this.dgv_WorkoutLog = new System.Windows.Forms.DataGridView();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_MyGoals = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgv_WorkoutLog)).BeginInit();
            this.SuspendLayout();

            // DataGridView: Workout Log
            this.dgv_WorkoutLog.Location = new System.Drawing.Point(20, 380);
            this.dgv_WorkoutLog.Name = "dgv_WorkoutLog";
            this.dgv_WorkoutLog.Size = new System.Drawing.Size(460, 150);
            this.dgv_WorkoutLog.TabIndex = 0;

            // Button: Back
            this.btn_Back.Location = new System.Drawing.Point(20, 550);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 30);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);

            // Button: My Goals
            this.btn_MyGoals.Location = new System.Drawing.Point(380, 550);
            this.btn_MyGoals.Name = "btn_MyGoals";
            this.btn_MyGoals.Size = new System.Drawing.Size(100, 30);
            this.btn_MyGoals.TabIndex = 2;
            this.btn_MyGoals.Text = "My Goals";
            this.btn_MyGoals.UseVisualStyleBackColor = true;
            this.btn_MyGoals.Click += new System.EventHandler(this.btn_MyGoals_Click);

            // WorkoutHistoryPage
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.dgv_WorkoutLog);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_MyGoals);
            this.Name = "WorkoutHistoryPage";
            this.Text = "Workout History";

            ((System.ComponentModel.ISupportInitialize)(this.dgv_WorkoutLog)).EndInit();
            this.ResumeLayout(false);
            // WorkoutHistoryPage.Designer.cs
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WorkoutHistoryPage_Paint);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_WorkoutLog;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_MyGoals;
    }
}