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
            this.txt_WorkoutType = new System.Windows.Forms.TextBox();
            this.lbl_Duration = new System.Windows.Forms.Label();
            this.txt_Duration = new System.Windows.Forms.TextBox();
            this.lbl_Repetitions = new System.Windows.Forms.Label();
            this.txt_Repetitions = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_WorkoutDate = new System.Windows.Forms.DateTimePicker();
            this.btn_AddWorkout = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_ViewHistory = new System.Windows.Forms.Button();

            // 
            // lbl_WorkoutType
            // 
            this.lbl_WorkoutType.AutoSize = true;
            this.lbl_WorkoutType.Location = new System.Drawing.Point(20, 20);
            this.lbl_WorkoutType.Name = "lbl_WorkoutType";
            this.lbl_WorkoutType.Size = new System.Drawing.Size(100, 20);
            this.lbl_WorkoutType.TabIndex = 0;
            this.lbl_WorkoutType.Text = "Workout Type:";

            // 
            // txt_WorkoutType
            // 
            this.txt_WorkoutType.Location = new System.Drawing.Point(150, 20);
            this.txt_WorkoutType.Name = "txt_WorkoutType";
            this.txt_WorkoutType.Size = new System.Drawing.Size(200, 26);
            this.txt_WorkoutType.TabIndex = 1;

            // 
            // lbl_Duration
            // 
            this.lbl_Duration.AutoSize = true;
            this.lbl_Duration.Location = new System.Drawing.Point(20, 60);
            this.lbl_Duration.Name = "lbl_Duration";
            this.lbl_Duration.Size = new System.Drawing.Size(120, 20);
            this.lbl_Duration.TabIndex = 2;
            this.lbl_Duration.Text = "Duration (mins):";

            // 
            // txt_Duration
            // 
            this.txt_Duration.Location = new System.Drawing.Point(150, 60);
            this.txt_Duration.Name = "txt_Duration";
            this.txt_Duration.Size = new System.Drawing.Size(200, 26);
            this.txt_Duration.TabIndex = 3;

            // 
            // lbl_Repetitions
            // 
            this.lbl_Repetitions.AutoSize = true;
            this.lbl_Repetitions.Location = new System.Drawing.Point(20, 100);
            this.lbl_Repetitions.Name = "lbl_Repetitions";
            this.lbl_Repetitions.Size = new System.Drawing.Size(90, 20);
            this.lbl_Repetitions.TabIndex = 4;
            this.lbl_Repetitions.Text = "Repetitions:";

            // 
            // txt_Repetitions
            // 
            this.txt_Repetitions.Location = new System.Drawing.Point(150, 100);
            this.txt_Repetitions.Name = "txt_Repetitions";
            this.txt_Repetitions.Size = new System.Drawing.Size(200, 26);
            this.txt_Repetitions.TabIndex = 5;

            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(20, 140);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(45, 20);
            this.lbl_Date.TabIndex = 6;
            this.lbl_Date.Text = "Date:";

            // 
            // dtp_WorkoutDate
            // 
            this.dtp_WorkoutDate.Location = new System.Drawing.Point(150, 140);
            this.dtp_WorkoutDate.Name = "dtp_WorkoutDate";
            this.dtp_WorkoutDate.Size = new System.Drawing.Size(200, 26);
            this.dtp_WorkoutDate.TabIndex = 7;

            // 
            // btn_AddWorkout
            // 
            this.btn_AddWorkout.Location = new System.Drawing.Point(20, 200);
            this.btn_AddWorkout.Name = "btn_AddWorkout";
            this.btn_AddWorkout.Size = new System.Drawing.Size(120, 30);
            this.btn_AddWorkout.TabIndex = 8;
            this.btn_AddWorkout.Text = "Add Workout";
            this.btn_AddWorkout.UseVisualStyleBackColor = true;
            this.btn_AddWorkout.Click += new System.EventHandler(this.btn_AddWorkout_Click);

            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(20, 250);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 30);
            this.btn_Back.TabIndex = 9;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);

            // 
            // btn_ViewHistory
            // 
            this.btn_ViewHistory.Location = new System.Drawing.Point(250, 250);
            this.btn_ViewHistory.Name = "btn_ViewHistory";
            this.btn_ViewHistory.Size = new System.Drawing.Size(120, 30);
            this.btn_ViewHistory.TabIndex = 10;
            this.btn_ViewHistory.Text = "View History";
            this.btn_ViewHistory.UseVisualStyleBackColor = true;
            this.btn_ViewHistory.Click += new System.EventHandler(this.btn_ViewHistory_Click);

            // 
            // LogWorkoutPage
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lbl_WorkoutType);
            this.Controls.Add(this.txt_WorkoutType);
            this.Controls.Add(this.lbl_Duration);
            this.Controls.Add(this.txt_Duration);
            this.Controls.Add(this.lbl_Repetitions);
            this.Controls.Add(this.txt_Repetitions);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.dtp_WorkoutDate);
            this.Controls.Add(this.btn_AddWorkout);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_ViewHistory);
            this.Name = "LogWorkoutPage";
            this.Text = "Log Workout";
        }

        #endregion

        private System.Windows.Forms.Label lbl_WorkoutType;
        private System.Windows.Forms.TextBox txt_WorkoutType;
        private System.Windows.Forms.Label lbl_Duration;
        private System.Windows.Forms.TextBox txt_Duration;
        private System.Windows.Forms.Label lbl_Repetitions;
        private System.Windows.Forms.TextBox txt_Repetitions;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dtp_WorkoutDate;
        private System.Windows.Forms.Button btn_AddWorkout;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_ViewHistory;
    }
}