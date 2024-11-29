namespace FitnessApp
{
    partial class LogWorkoutPage
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
            this.lbl_WorkoutType = new System.Windows.Forms.Label();
            this.cmb_WorkoutType = new System.Windows.Forms.ComboBox();
            this.lbl_Repetitions = new System.Windows.Forms.Label();
            this.txt_Repetitions = new System.Windows.Forms.TextBox();
            this.lbl_Duration = new System.Windows.Forms.Label();
            this.txt_Duration = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_WorkoutDate = new System.Windows.Forms.DateTimePicker();
            this.btn_AddWorkout = new System.Windows.Forms.Button();
            this.btn_DeleteWorkout = new System.Windows.Forms.Button();
            this.btn_UpdateWorkout = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_WorkoutHistory = new System.Windows.Forms.Button();
            this.dgv_Workouts = new System.Windows.Forms.DataGridView();
            this.btn_Back = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgv_Workouts)).BeginInit();
            this.SuspendLayout();

            // Label: Workout Type
            this.lbl_WorkoutType.AutoSize = true;
            this.lbl_WorkoutType.Location = new System.Drawing.Point(20, 20);
            this.lbl_WorkoutType.Name = "lbl_WorkoutType";
            this.lbl_WorkoutType.Size = new System.Drawing.Size(98, 20);
            this.lbl_WorkoutType.TabIndex = 0;
            this.lbl_WorkoutType.Text = "Workout Type";

            // ComboBox: Workout Type
            this.cmb_WorkoutType.Location = new System.Drawing.Point(150, 20);
            this.cmb_WorkoutType.Name = "cmb_WorkoutType";
            this.cmb_WorkoutType.Size = new System.Drawing.Size(200, 28);
            this.cmb_WorkoutType.TabIndex = 1;

            // Label: Repetitions
            this.lbl_Repetitions.AutoSize = true;
            this.lbl_Repetitions.Location = new System.Drawing.Point(20, 60);
            this.lbl_Repetitions.Name = "lbl_Repetitions";
            this.lbl_Repetitions.Size = new System.Drawing.Size(82, 20);
            this.lbl_Repetitions.TabIndex = 2;
            this.lbl_Repetitions.Text = "Repetitions";

            // TextBox: Repetitions
            this.txt_Repetitions.Location = new System.Drawing.Point(150, 60);
            this.txt_Repetitions.Name = "txt_Repetitions";
            this.txt_Repetitions.Size = new System.Drawing.Size(200, 26);
            this.txt_Repetitions.TabIndex = 3;

            // Label: Duration
            this.lbl_Duration.AutoSize = true;
            this.lbl_Duration.Location = new System.Drawing.Point(20, 100);
            this.lbl_Duration.Name = "lbl_Duration";
            this.lbl_Duration.Size = new System.Drawing.Size(64, 20);
            this.lbl_Duration.TabIndex = 4;
            this.lbl_Duration.Text = "Duration";

            // TextBox: Duration
            this.txt_Duration.Location = new System.Drawing.Point(150, 100);
            this.txt_Duration.Name = "txt_Duration";
            this.txt_Duration.Size = new System.Drawing.Size(200, 26);
            this.txt_Duration.TabIndex = 5;

            // Label: Date
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(20, 140);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(38, 20);
            this.lbl_Date.TabIndex = 6;
            this.lbl_Date.Text = "Date";

            // DateTimePicker: Workout Date
            this.dtp_WorkoutDate.Location = new System.Drawing.Point(150, 140);
            this.dtp_WorkoutDate.Name = "dtp_WorkoutDate";
            this.dtp_WorkoutDate.Size = new System.Drawing.Size(200, 26);
            this.dtp_WorkoutDate.TabIndex = 7;

            // Button: Add Workout
            this.btn_AddWorkout.Location = new System.Drawing.Point(20, 200);
            this.btn_AddWorkout.Name = "btn_AddWorkout";
            this.btn_AddWorkout.Size = new System.Drawing.Size(100, 30);
            this.btn_AddWorkout.TabIndex = 8;
            this.btn_AddWorkout.Text = "Add Workout";
            this.btn_AddWorkout.UseVisualStyleBackColor = true;
            this.btn_AddWorkout.Click += new System.EventHandler(this.btn_AddWorkout_Click);

            // Button: Delete Workout
            this.btn_DeleteWorkout.Location = new System.Drawing.Point(130, 200);
            this.btn_DeleteWorkout.Name = "btn_DeleteWorkout";
            this.btn_DeleteWorkout.Size = new System.Drawing.Size(100, 30);
            this.btn_DeleteWorkout.TabIndex = 9;
            this.btn_DeleteWorkout.Text = "Delete";
            this.btn_DeleteWorkout.UseVisualStyleBackColor = true;
            this.btn_DeleteWorkout.Click += new System.EventHandler(this.btn_DeleteWorkout_Click);

            // Button: Update Workout
            this.btn_UpdateWorkout.Location = new System.Drawing.Point(240, 200);
            this.btn_UpdateWorkout.Name = "btn_UpdateWorkout";
            this.btn_UpdateWorkout.Size = new System.Drawing.Size(100, 30);
            this.btn_UpdateWorkout.TabIndex = 10;
            this.btn_UpdateWorkout.Text = "Update";
            this.btn_UpdateWorkout.UseVisualStyleBackColor = true;
            this.btn_UpdateWorkout.Click += new System.EventHandler(this.btn_UpdateWorkout_Click);

            // Button: Refresh
            this.btn_Refresh.Location = new System.Drawing.Point(350, 200);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(100, 30);
            this.btn_Refresh.TabIndex = 11;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);

            // Button: Workout History
            this.btn_WorkoutHistory.Location = new System.Drawing.Point(460, 200);
            this.btn_WorkoutHistory.Name = "btn_WorkoutHistory";
            this.btn_WorkoutHistory.Size = new System.Drawing.Size(150, 30);
            this.btn_WorkoutHistory.TabIndex = 12;
            this.btn_WorkoutHistory.Text = "View History";
            this.btn_WorkoutHistory.UseVisualStyleBackColor = true;
            this.btn_WorkoutHistory.Click += new System.EventHandler(this.btn_WorkoutHistory_Click);

            // DataGridView: Workouts
            this.dgv_Workouts.Location = new System.Drawing.Point(20, 250);
            this.dgv_Workouts.Name = "dgv_Workouts";
            this.dgv_Workouts.Size = new System.Drawing.Size(600, 200);
            this.dgv_Workouts.TabIndex = 13;

            // Button: Back
            this.btn_Back.Location = new System.Drawing.Point(20, 470);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 30);
            this.btn_Back.TabIndex = 14;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);

            // LogWorkoutPage
            this.ClientSize = new System.Drawing.Size(650, 520);
            this.Controls.Add(this.lbl_WorkoutType);
            this.Controls.Add(this.cmb_WorkoutType);
            this.Controls.Add(this.lbl_Repetitions);
            this.Controls.Add(this.txt_Repetitions);
            this.Controls.Add(this.lbl_Duration);
            this.Controls.Add(this.txt_Duration);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.dtp_WorkoutDate);
            this.Controls.Add(this.btn_AddWorkout);
            this.Controls.Add(this.btn_DeleteWorkout);
            this.Controls.Add(this.btn_UpdateWorkout);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_WorkoutHistory);
            this.Controls.Add(this.dgv_Workouts);
            this.Controls.Add(this.btn_Back);
            this.Name = "LogWorkoutPage";
            this.Text = "Log Workout";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Workouts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_WorkoutType;
        private System.Windows.Forms.ComboBox cmb_WorkoutType;
        private System.Windows.Forms.Label lbl_Repetitions;
        private System.Windows.Forms.TextBox txt_Repetitions;
        private System.Windows.Forms.Label lbl_Duration;
        private System.Windows.Forms.TextBox txt_Duration;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dtp_WorkoutDate;
        private System.Windows.Forms.Button btn_AddWorkout;
        private System.Windows.Forms.Button btn_DeleteWorkout;
        private System.Windows.Forms.Button btn_UpdateWorkout;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_WorkoutHistory;
        private System.Windows.Forms.DataGridView dgv_Workouts;
        private System.Windows.Forms.Button btn_Back;
    }
}