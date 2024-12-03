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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_WorkoutType = new System.Windows.Forms.Label();
            this.cmb_WorkoutType = new System.Windows.Forms.ComboBox();
            this.lbl_Duration = new System.Windows.Forms.Label();
            this.txt_Duration = new System.Windows.Forms.TextBox();
            this.lbl_Repetitions = new System.Windows.Forms.Label();
            this.txt_Repetitions = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_WorkoutDate = new System.Windows.Forms.DateTimePicker();
            this.btn_AddWorkout = new System.Windows.Forms.Button();
            this.btn_DeleteWorkout = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dgv_Workouts = new System.Windows.Forms.DataGridView();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_WorkoutHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Workouts)).BeginInit();
            this.SuspendLayout();

            // Title Label
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(180, 20);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(200, 30);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Log Your Workouts";

            // Workout Type Label
            this.lbl_WorkoutType.AutoSize = true;
            this.lbl_WorkoutType.ForeColor = System.Drawing.Color.White;
            this.lbl_WorkoutType.Location = new System.Drawing.Point(20, 80);
            this.lbl_WorkoutType.Name = "lbl_WorkoutType";
            this.lbl_WorkoutType.Size = new System.Drawing.Size(95, 20);
            this.lbl_WorkoutType.TabIndex = 1;
            this.lbl_WorkoutType.Text = "Workout Type";

            // Workout Type ComboBox
            this.cmb_WorkoutType.FormattingEnabled = true;
            this.cmb_WorkoutType.Location = new System.Drawing.Point(150, 80);
            this.cmb_WorkoutType.Name = "cmb_WorkoutType";
            this.cmb_WorkoutType.Size = new System.Drawing.Size(200, 28);
            this.cmb_WorkoutType.TabIndex = 2;

            // Duration Label
            this.lbl_Duration.AutoSize = true;
            this.lbl_Duration.ForeColor = System.Drawing.Color.White;
            this.lbl_Duration.Location = new System.Drawing.Point(20, 120);
            this.lbl_Duration.Name = "lbl_Duration";
            this.lbl_Duration.Size = new System.Drawing.Size(65, 20);
            this.lbl_Duration.TabIndex = 3;
            this.lbl_Duration.Text = "Duration";

            // Duration TextBox
            this.txt_Duration.Location = new System.Drawing.Point(150, 120);
            this.txt_Duration.Name = "txt_Duration";
            this.txt_Duration.PlaceholderText = "In Minutes";
            this.txt_Duration.Size = new System.Drawing.Size(200, 26);
            this.txt_Duration.TabIndex = 4;

            // Repetitions Label
            this.lbl_Repetitions.AutoSize = true;
            this.lbl_Repetitions.ForeColor = System.Drawing.Color.White;
            this.lbl_Repetitions.Location = new System.Drawing.Point(20, 160);
            this.lbl_Repetitions.Name = "lbl_Repetitions";
            this.lbl_Repetitions.Size = new System.Drawing.Size(78, 20);
            this.lbl_Repetitions.TabIndex = 5;
            this.lbl_Repetitions.Text = "Repetitions";

            // Repetitions TextBox
            this.txt_Repetitions.Location = new System.Drawing.Point(150, 160);
            this.txt_Repetitions.Name = "txt_Repetitions";
            this.txt_Repetitions.Size = new System.Drawing.Size(200, 26);
            this.txt_Repetitions.TabIndex = 6;

            // Date Label
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.ForeColor = System.Drawing.Color.White;
            this.lbl_Date.Location = new System.Drawing.Point(20, 200);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(38, 20);
            this.lbl_Date.TabIndex = 7;
            this.lbl_Date.Text = "Date";

            // DateTimePicker
            this.dtp_WorkoutDate.Location = new System.Drawing.Point(150, 200);
            this.dtp_WorkoutDate.Name = "dtp_WorkoutDate";
            this.dtp_WorkoutDate.Size = new System.Drawing.Size(200, 26);
            this.dtp_WorkoutDate.TabIndex = 8;

            // Add Workout Button
            this.btn_AddWorkout.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_AddWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddWorkout.ForeColor = System.Drawing.Color.White;
            this.btn_AddWorkout.Location = new System.Drawing.Point(20, 250);
            this.btn_AddWorkout.Name = "btn_AddWorkout";
            this.btn_AddWorkout.Size = new System.Drawing.Size(120, 30);
            this.btn_AddWorkout.TabIndex = 9;
            this.btn_AddWorkout.Text = "Add Workout";
            this.btn_AddWorkout.UseVisualStyleBackColor = false;
            this.btn_AddWorkout.Click += new System.EventHandler(this.btn_AddWorkout_Click);

            // Delete Workout Button
            this.btn_DeleteWorkout.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_DeleteWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteWorkout.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteWorkout.Location = new System.Drawing.Point(160, 250);
            this.btn_DeleteWorkout.Name = "btn_DeleteWorkout";
            this.btn_DeleteWorkout.Size = new System.Drawing.Size(120, 30);
            this.btn_DeleteWorkout.TabIndex = 10;
            this.btn_DeleteWorkout.Text = "Delete Workout";
            this.btn_DeleteWorkout.UseVisualStyleBackColor = false;
            this.btn_DeleteWorkout.Click += new System.EventHandler(this.btn_DeleteWorkout_Click);
            
            // Refresh Button
            this.btn_Refresh.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(440, 250);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(120, 30);
            this.btn_Refresh.TabIndex = 11;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);

            // DataGridView: Workouts
            this.dgv_Workouts.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Workouts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Workouts.Location = new System.Drawing.Point(20, 300);
            this.dgv_Workouts.Name = "dgv_Workouts";
            this.dgv_Workouts.Size = new System.Drawing.Size(540, 150);
            this.dgv_Workouts.TabIndex = 13;

            // Back Button
            this.btn_Back.BackColor = System.Drawing.Color.White;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_Back.Location = new System.Drawing.Point(20, 470);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(120, 30);
            this.btn_Back.TabIndex = 14;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);

            // Workout History Button
            this.btn_WorkoutHistory.BackColor = System.Drawing.Color.White;
            this.btn_WorkoutHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WorkoutHistory.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_WorkoutHistory.Location = new System.Drawing.Point(440, 470);
            this.btn_WorkoutHistory.Name = "btn_WorkoutHistory";
            this.btn_WorkoutHistory.Size = new System.Drawing.Size(120, 30);
            this.btn_WorkoutHistory.TabIndex = 15;
            this.btn_WorkoutHistory.Text = "History";
            this.btn_WorkoutHistory.UseVisualStyleBackColor = false;
            this.btn_WorkoutHistory.Click += new System.EventHandler(this.btn_WorkoutHistory_Click);

            // LogWorkoutPage Form Design
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(600, 520);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_WorkoutType);
            this.Controls.Add(this.cmb_WorkoutType);
            this.Controls.Add(this.lbl_Duration);
            this.Controls.Add(this.txt_Duration);
            this.Controls.Add(this.lbl_Repetitions);
            this.Controls.Add(this.txt_Repetitions);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.dtp_WorkoutDate);
            this.Controls.Add(this.btn_AddWorkout);
            this.Controls.Add(this.btn_DeleteWorkout);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dgv_Workouts);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_WorkoutHistory);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogWorkoutPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log Workout";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Workouts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_WorkoutType;
        private System.Windows.Forms.ComboBox cmb_WorkoutType;
        private System.Windows.Forms.Label lbl_Duration;
        private System.Windows.Forms.TextBox txt_Duration;
        private System.Windows.Forms.Label lbl_Repetitions;
        private System.Windows.Forms.TextBox txt_Repetitions;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dtp_WorkoutDate;
        private System.Windows.Forms.Button btn_AddWorkout;
        private System.Windows.Forms.Button btn_DeleteWorkout;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridView dgv_Workouts;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_WorkoutHistory;

    }
}