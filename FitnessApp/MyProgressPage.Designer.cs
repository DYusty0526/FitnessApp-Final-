namespace FitnessApp
{
    partial class MyProgressPage
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
            rbtn_Weekly = new RadioButton();
            rbtn_Monthly = new RadioButton();
            lbl_NutritionProgress = new Label();
            progressBar_Calories = new ProgressBar();
            lbl_Calories = new Label();
            progressBar_Meals = new ProgressBar();
            lbl_Meals = new Label();
            lbl_MacrosAverage = new Label();
            lbl_FitnessProgress = new Label();
            progressBar_DaysExercised = new ProgressBar();
            lbl_DaysExercised = new Label();
            progressBar_ExercisesDone = new ProgressBar();
            lbl_ExercisesDone = new Label();
            lbl_AverageExerciseTime = new Label();
            btn_Back = new Button();
            btn_LogOut = new Button();
            SuspendLayout();
            
            // Weekly Radio Button
            rbtn_Weekly.AutoSize = true;
            rbtn_Weekly.Location = new Point(20, 20);
            rbtn_Weekly.Name = "rbtn_Weekly";
            rbtn_Weekly.Size = new Size(78, 24);
            rbtn_Weekly.TabIndex = 0;
            rbtn_Weekly.TabStop = true;
            rbtn_Weekly.Text = "Weekly";
            rbtn_Weekly.UseVisualStyleBackColor = true;
            rbtn_Weekly.CheckedChanged += ToggleGoalType;
            
            // Monthly Radio Button
            rbtn_Monthly.AutoSize = true;
            rbtn_Monthly.Location = new Point(120, 20);
            rbtn_Monthly.Name = "rbtn_Monthly";
            rbtn_Monthly.Size = new Size(82, 24);
            rbtn_Monthly.TabIndex = 1;
            rbtn_Monthly.TabStop = true;
            rbtn_Monthly.Text = "Monthly";
            rbtn_Monthly.UseVisualStyleBackColor = true;
            rbtn_Monthly.CheckedChanged += ToggleGoalType;
            
            // Nutrition Progress Label
            lbl_NutritionProgress.AutoSize = true;
            lbl_NutritionProgress.Location = new Point(20, 60);
            lbl_NutritionProgress.Name = "lbl_NutritionProgress";
            lbl_NutritionProgress.Size = new Size(124, 20);
            lbl_NutritionProgress.TabIndex = 2;
            lbl_NutritionProgress.Text = "Nutrition Progress";
            lbl_NutritionProgress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lbl_NutritionProgress.ForeColor = System.Drawing.Color.White;

            // Calories Progress Bar
            progressBar_Calories.Location = new Point(160, 90);
            progressBar_Calories.Name = "progressBar_Calories";
            progressBar_Calories.Size = new Size(300, 20);
            progressBar_Calories.TabIndex = 3;
            progressBar_Calories.ForeColor = System.Drawing.Color.OrangeRed;
            progressBar_Calories.BackColor = System.Drawing.Color.White;


            // Calories Label
            lbl_Calories.AutoSize = true;
            lbl_Calories.Location = new Point(20, 90);
            lbl_Calories.Name = "lbl_Calories";
            lbl_Calories.Size = new Size(68, 20);
            lbl_Calories.TabIndex = 4;
            lbl_Calories.Text = "Calories";
            
            // Meals Progress Bar
            progressBar_Meals.Location = new Point(160, 120);
            progressBar_Meals.Name = "progressBar_Meals";
            progressBar_Meals.Size = new Size(300, 20);
            progressBar_Meals.TabIndex = 5;
            progressBar_Meals.ForeColor = System.Drawing.Color.OrangeRed;
            progressBar_Meals.BackColor = System.Drawing.Color.White;


            // Meals Label
            lbl_Meals.AutoSize = true;
            lbl_Meals.Location = new Point(20, 120);
            lbl_Meals.Name = "lbl_Meals";
            lbl_Meals.Size = new Size(49, 20);
            lbl_Meals.TabIndex = 6;
            lbl_Meals.Text = "Meals";
            
            // Macros Average Label
            lbl_MacrosAverage.AutoSize = true;
            lbl_MacrosAverage.Location = new Point(20, 150);
            lbl_MacrosAverage.Name = "lbl_MacrosAverage";
            lbl_MacrosAverage.Size = new Size(200, 20);
            lbl_MacrosAverage.TabIndex = 7;
            lbl_MacrosAverage.Text = "Macros Average: P: 0% C: 0% F: 0%";
            
            // Fitness Progress Label
            lbl_FitnessProgress.AutoSize = true;
            lbl_FitnessProgress.Location = new Point(20, 190);
            lbl_FitnessProgress.Name = "lbl_FitnessProgress";
            lbl_FitnessProgress.Size = new Size(115, 20);
            lbl_FitnessProgress.TabIndex = 8;
            lbl_FitnessProgress.Text = "Fitness Progress";
            lbl_FitnessProgress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lbl_FitnessProgress.ForeColor = System.Drawing.Color.White;

            // Days Exercised Progress Bar
            progressBar_DaysExercised.Location = new Point(160, 220);
            progressBar_DaysExercised.Name = "progressBar_DaysExercised";
            progressBar_DaysExercised.Size = new Size(300, 20);
            progressBar_DaysExercised.TabIndex = 9;
            progressBar_DaysExercised.ForeColor = System.Drawing.Color.OrangeRed;
            progressBar_DaysExercised.BackColor = System.Drawing.Color.White;


            // Days Exercised Label
            lbl_DaysExercised.AutoSize = true;
            lbl_DaysExercised.Location = new Point(20, 220);
            lbl_DaysExercised.Name = "lbl_DaysExercised";
            lbl_DaysExercised.Size = new Size(110, 20);
            lbl_DaysExercised.TabIndex = 10;
            lbl_DaysExercised.Text = "Days Exercised";
            
            // Exercises Done Progress Bar
            progressBar_ExercisesDone.Location = new Point(160, 250);
            progressBar_ExercisesDone.Name = "progressBar_ExercisesDone";
            progressBar_ExercisesDone.Size = new Size(300, 20);
            progressBar_ExercisesDone.TabIndex = 11;
            progressBar_ExercisesDone.ForeColor = System.Drawing.Color.OrangeRed;
            progressBar_ExercisesDone.BackColor = System.Drawing.Color.White;


            // Exercises Done Label
            lbl_ExercisesDone.AutoSize = true;
            lbl_ExercisesDone.Location = new Point(20, 250);
            lbl_ExercisesDone.Name = "lbl_ExercisesDone";
            lbl_ExercisesDone.Size = new Size(113, 20);
            lbl_ExercisesDone.TabIndex = 12;
            lbl_ExercisesDone.Text = "Exercises Done";
            
            // Average Exercise Time Label
            lbl_AverageExerciseTime.AutoSize = true;
            lbl_AverageExerciseTime.Location = new Point(20, 280);
            lbl_AverageExerciseTime.Name = "lbl_AverageExerciseTime";
            lbl_AverageExerciseTime.Size = new Size(197, 20);
            lbl_AverageExerciseTime.TabIndex = 13;
            lbl_AverageExerciseTime.Text = "Average Exercise Time: 0 hrs";
            
            // Back Button
            btn_Back.Location = new Point(20, 420);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(100, 30);
            btn_Back.TabIndex = 14;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            btn_Back.BackColor = System.Drawing.Color.White;
            btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Back.ForeColor = System.Drawing.Color.DarkOrange;


            // Logout Button
            btn_LogOut.Location = new Point(400, 420);
            btn_LogOut.Name = "btn_LogOut";
            btn_LogOut.Size = new Size(100, 30);
            btn_LogOut.TabIndex = 15;
            btn_LogOut.Text = "Logout";
            btn_LogOut.UseVisualStyleBackColor = true;
            btn_LogOut.Click += btn_LogOut_Click;
            btn_LogOut.BackColor = System.Drawing.Color.White;
            btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_LogOut.ForeColor = System.Drawing.Color.DarkOrange;

            // MyProgressPage
            ClientSize = new Size(500, 370);
            Controls.Add(rbtn_Weekly);
            Controls.Add(rbtn_Monthly);
            Controls.Add(lbl_NutritionProgress);
            Controls.Add(progressBar_Calories);
            Controls.Add(lbl_Calories);
            Controls.Add(progressBar_Meals);
            Controls.Add(lbl_Meals);
            Controls.Add(lbl_MacrosAverage);
            Controls.Add(lbl_FitnessProgress);
            Controls.Add(progressBar_DaysExercised);
            Controls.Add(lbl_DaysExercised);
            Controls.Add(progressBar_ExercisesDone);
            Controls.Add(lbl_ExercisesDone);
            Controls.Add(lbl_AverageExerciseTime);
            Controls.Add(btn_Back);
            Controls.Add(btn_LogOut);
            Name = "MyProgressPage";
            Text = "My Progress";
            ResumeLayout(false);
            PerformLayout();
            this.BackColor = System.Drawing.Color.DarkOrange;

            // Goals Overview Label
            lbl_GoalsOverview = new Label();
            lbl_GoalsOverview.AutoSize = true;
            lbl_GoalsOverview.Location = new Point(20, 320);
            lbl_GoalsOverview.Name = "lbl_GoalsOverview";
            lbl_GoalsOverview.Size = new Size(110, 20);
            lbl_GoalsOverview.TabIndex = 16;
            lbl_GoalsOverview.Text = "Goals Overview";
            lbl_GoalsOverview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lbl_GoalsOverview.ForeColor = System.Drawing.Color.White;

            // Exercise Goals Label
            lbl_ExerciseGoals = new Label();
            lbl_ExerciseGoals.AutoSize = true;
            lbl_ExerciseGoals.Location = new Point(20, 350);
            lbl_ExerciseGoals.Name = "lbl_ExerciseGoals";
            lbl_ExerciseGoals.Size = new Size(150, 20);
            lbl_ExerciseGoals.TabIndex = 17;
            lbl_ExerciseGoals.Text = "Exercise Goals: -";
            
            // Nutrition Goals Label
            lbl_NutritionGoals = new Label();
            lbl_NutritionGoals.AutoSize = true;
            lbl_NutritionGoals.Location = new Point(20, 380);
            lbl_NutritionGoals.Name = "lbl_NutritionGoals";
            lbl_NutritionGoals.Size = new Size(150, 20);
            lbl_NutritionGoals.TabIndex = 18;
            lbl_NutritionGoals.Text = "Nutrition Goals: -";
            
            // Add all controls to the form
            Controls.Add(lbl_GoalsOverview);
            Controls.Add(lbl_ExerciseGoals);
            Controls.Add(lbl_NutritionGoals);
            ClientSize = new Size(500, 450);
            Name = "MyProgressPage";
            Text = "Your Progress";
        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_Weekly;
        private System.Windows.Forms.RadioButton rbtn_Monthly;
        private System.Windows.Forms.Label lbl_NutritionProgress;
        private System.Windows.Forms.ProgressBar progressBar_Calories;
        private System.Windows.Forms.Label lbl_Calories;
        private System.Windows.Forms.ProgressBar progressBar_Meals;
        private System.Windows.Forms.Label lbl_Meals;
        private System.Windows.Forms.Label lbl_MacrosAverage;
        private System.Windows.Forms.Label lbl_FitnessProgress;
        private System.Windows.Forms.ProgressBar progressBar_DaysExercised;
        private System.Windows.Forms.Label lbl_DaysExercised;
        private System.Windows.Forms.ProgressBar progressBar_ExercisesDone;
        private System.Windows.Forms.Label lbl_ExercisesDone;
        private System.Windows.Forms.Label lbl_AverageExerciseTime;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Label lbl_GoalsOverview;
        private System.Windows.Forms.Label lbl_ExerciseGoals;
        private System.Windows.Forms.Label lbl_NutritionGoals;

    }
}