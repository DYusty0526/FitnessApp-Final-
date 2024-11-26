namespace FitnessApp
{
    partial class MainPage
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
            workoutGroupBox = new GroupBox();
            workoutTodayLabel = new Label();
            workoutHoursLabel = new Label();
            btn_LogWorkout = new Button();
            nutritionGroupBox = new GroupBox();
            nutritionTodayLabel = new Label();
            totalCaloriesLabel = new Label();
            btn_LogMeals = new Button();
            btn_LogOut = new Button();
            btn_MyProgress = new Button();
            workoutGroupBox.SuspendLayout();
            nutritionGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // workoutGroupBox
            // 
            workoutGroupBox.Controls.Add(workoutTodayLabel);
            workoutGroupBox.Controls.Add(workoutHoursLabel);
            workoutGroupBox.Controls.Add(btn_LogWorkout);
            workoutGroupBox.Location = new Point(12, 12);
            workoutGroupBox.Name = "workoutGroupBox";
            workoutGroupBox.Size = new Size(350, 300);
            workoutGroupBox.TabIndex = 0;
            workoutGroupBox.TabStop = false;
            workoutGroupBox.Text = "Today's Workout";
            // 
            // workoutTodayLabel
            // 
            workoutTodayLabel.AutoSize = true;
            workoutTodayLabel.Location = new Point(15, 30);
            workoutTodayLabel.Name = "workoutTodayLabel";
            workoutTodayLabel.Size = new Size(126, 20);
            workoutTodayLabel.TabIndex = 1;
            workoutTodayLabel.Text = "Arm Curls - 4 Sets";
            // 
            // workoutHoursLabel
            // 
            workoutHoursLabel.AutoSize = true;
            workoutHoursLabel.Location = new Point(15, 60);
            workoutHoursLabel.Name = "workoutHoursLabel";
            workoutHoursLabel.Size = new Size(137, 20);
            workoutHoursLabel.TabIndex = 2;
            workoutHoursLabel.Text = "Total Hours: 1 Hour";
            // 
            // btn_LogWorkout
            // 
            btn_LogWorkout.Location = new Point(15, 250);
            btn_LogWorkout.Name = "btn_LogWorkout";
            btn_LogWorkout.Size = new Size(120, 30);
            btn_LogWorkout.TabIndex = 3;
            btn_LogWorkout.Text = "Log Workout";
            btn_LogWorkout.UseVisualStyleBackColor = true;
            btn_LogWorkout.Click += btn_LogWorkout_Click;
            // 
            // nutritionGroupBox
            // 
            nutritionGroupBox.Controls.Add(nutritionTodayLabel);
            nutritionGroupBox.Controls.Add(totalCaloriesLabel);
            nutritionGroupBox.Controls.Add(btn_LogMeals);
            nutritionGroupBox.Location = new Point(380, 12);
            nutritionGroupBox.Name = "nutritionGroupBox";
            nutritionGroupBox.Size = new Size(350, 300);
            nutritionGroupBox.TabIndex = 1;
            nutritionGroupBox.TabStop = false;
            nutritionGroupBox.Text = "Today's Nutrition";
            // 
            // nutritionTodayLabel
            // 
            nutritionTodayLabel.AutoSize = true;
            nutritionTodayLabel.Location = new Point(15, 30);
            nutritionTodayLabel.Name = "nutritionTodayLabel";
            nutritionTodayLabel.Size = new Size(158, 20);
            nutritionTodayLabel.TabIndex = 4;
            nutritionTodayLabel.Text = "Breakfast: 310 Calories";
            // 
            // totalCaloriesLabel
            // 
            totalCaloriesLabel.AutoSize = true;
            totalCaloriesLabel.Location = new Point(15, 60);
            totalCaloriesLabel.Name = "totalCaloriesLabel";
            totalCaloriesLabel.Size = new Size(138, 20);
            totalCaloriesLabel.TabIndex = 5;
            totalCaloriesLabel.Text = "Total Calories: 1200";
            // 
            // btn_LogMeals
            // 
            btn_LogMeals.Location = new Point(15, 250);
            btn_LogMeals.Name = "btn_LogMeals";
            btn_LogMeals.Size = new Size(120, 30);
            btn_LogMeals.TabIndex = 6;
            btn_LogMeals.Text = "Log Meals";
            btn_LogMeals.UseVisualStyleBackColor = true;
            btn_LogMeals.Click += btn_LogMeals_Click;
            // 
            // btn_LogOut
            // 
            btn_LogOut.Location = new Point(12, 360);
            btn_LogOut.Name = "btn_LogOut";
            btn_LogOut.Size = new Size(100, 30);
            btn_LogOut.TabIndex = 7;
            btn_LogOut.Text = "Log Out";
            btn_LogOut.UseVisualStyleBackColor = true;
            btn_LogOut.Click += btn_LogOut_Click;
            // 
            // btn_MyProgress
            // 
            btn_MyProgress.Location = new Point(320, 320);
            btn_MyProgress.Name = "btn_MyProgress";
            btn_MyProgress.Size = new Size(120, 30);
            btn_MyProgress.TabIndex = 8;
            btn_MyProgress.Text = "My Progress";
            btn_MyProgress.UseVisualStyleBackColor = true;
            //btn_MyProgress.Click += btn_MyProgress_Click;
            // 
            // MainPage
            // 
            ClientSize = new Size(750, 400);
            Controls.Add(workoutGroupBox);
            Controls.Add(nutritionGroupBox);
            Controls.Add(btn_MyProgress);
            Controls.Add(btn_LogOut);
            Name = "MainPage";
            Text = "Main Page";
            workoutGroupBox.ResumeLayout(false);
            workoutGroupBox.PerformLayout();
            nutritionGroupBox.ResumeLayout(false);
            nutritionGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox workoutGroupBox;
        private System.Windows.Forms.GroupBox nutritionGroupBox;
        private System.Windows.Forms.Button btn_LogWorkout;
        private System.Windows.Forms.Button btn_LogMeals;
        private System.Windows.Forms.Button btn_MyProgress;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Label workoutTodayLabel;
        private System.Windows.Forms.Label workoutHoursLabel;
        private System.Windows.Forms.Label nutritionTodayLabel;
        private System.Windows.Forms.Label totalCaloriesLabel;
    }
}