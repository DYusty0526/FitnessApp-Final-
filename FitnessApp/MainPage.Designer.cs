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
            this.grp_Workout = new System.Windows.Forms.GroupBox();
            this.lbl_WorkoutToday = new System.Windows.Forms.Label();
            this.lbl_WorkoutHours = new System.Windows.Forms.Label();
            this.btn_LogWorkout = new System.Windows.Forms.Button();
            this.grp_Nutrition = new System.Windows.Forms.GroupBox();
            this.lbl_NutritionToday = new System.Windows.Forms.Label();
            this.lbl_TotalCalories = new System.Windows.Forms.Label();
            this.btn_LogMeals = new System.Windows.Forms.Button();
            this.btn_MyProgress = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.grp_Workout.SuspendLayout();
            this.grp_Nutrition.SuspendLayout();
            this.SuspendLayout();

            // 
            // grp_Workout
            // 
            this.grp_Workout.Controls.Add(this.lbl_WorkoutToday);
            this.grp_Workout.Controls.Add(this.lbl_WorkoutHours);
            this.grp_Workout.Controls.Add(this.btn_LogWorkout);
            this.grp_Workout.Location = new System.Drawing.Point(20, 20);
            this.grp_Workout.Name = "grp_Workout";
            this.grp_Workout.Size = new System.Drawing.Size(300, 150);
            this.grp_Workout.TabIndex = 0;
            this.grp_Workout.TabStop = false;
            this.grp_Workout.Text = "Today's Workout";

            // 
            // lbl_WorkoutToday
            // 
            this.lbl_WorkoutToday.AutoSize = true;
            this.lbl_WorkoutToday.Location = new System.Drawing.Point(10, 30);
            this.lbl_WorkoutToday.Name = "lbl_WorkoutToday";
            this.lbl_WorkoutToday.Size = new System.Drawing.Size(200, 20);
            this.lbl_WorkoutToday.TabIndex = 0;
            this.lbl_WorkoutToday.Text = "Workout: Arm Curls (4 Sets)";

            // 
            // lbl_WorkoutHours
            // 
            this.lbl_WorkoutHours.AutoSize = true;
            this.lbl_WorkoutHours.Location = new System.Drawing.Point(10, 60);
            this.lbl_WorkoutHours.Name = "lbl_WorkoutHours";
            this.lbl_WorkoutHours.Size = new System.Drawing.Size(100, 20);
            this.lbl_WorkoutHours.TabIndex = 1;
            this.lbl_WorkoutHours.Text = "Total Hours: 1";

            // 
            // btn_LogWorkout
            // 
            this.btn_LogWorkout.Location = new System.Drawing.Point(10, 100);
            this.btn_LogWorkout.Name = "btn_LogWorkout";
            this.btn_LogWorkout.Size = new System.Drawing.Size(120, 30);
            this.btn_LogWorkout.TabIndex = 2;
            this.btn_LogWorkout.Text = "Log Workout";
            this.btn_LogWorkout.UseVisualStyleBackColor = true;
            this.btn_LogWorkout.Click += new System.EventHandler(this.btn_LogWorkout_Click);

            // 
            // grp_Nutrition
            // 
            this.grp_Nutrition.Controls.Add(this.lbl_NutritionToday);
            this.grp_Nutrition.Controls.Add(this.lbl_TotalCalories);
            this.grp_Nutrition.Controls.Add(this.btn_LogMeals);
            this.grp_Nutrition.Location = new System.Drawing.Point(350, 20);
            this.grp_Nutrition.Name = "grp_Nutrition";
            this.grp_Nutrition.Size = new System.Drawing.Size(300, 150);
            this.grp_Nutrition.TabIndex = 1;
            this.grp_Nutrition.TabStop = false;
            this.grp_Nutrition.Text = "Today's Nutrition";

            // 
            // lbl_NutritionToday
            // 
            this.lbl_NutritionToday.AutoSize = true;
            this.lbl_NutritionToday.Location = new System.Drawing.Point(10, 30);
            this.lbl_NutritionToday.Name = "lbl_NutritionToday";
            this.lbl_NutritionToday.Size = new System.Drawing.Size(200, 20);
            this.lbl_NutritionToday.TabIndex = 0;
            this.lbl_NutritionToday.Text = "Meal: Breakfast (310 Calories)";

            // 
            // lbl_TotalCalories
            // 
            this.lbl_TotalCalories.AutoSize = true;
            this.lbl_TotalCalories.Location = new System.Drawing.Point(10, 60);
            this.lbl_TotalCalories.Name = "lbl_TotalCalories";
            this.lbl_TotalCalories.Size = new System.Drawing.Size(150, 20);
            this.lbl_TotalCalories.TabIndex = 1;
            this.lbl_TotalCalories.Text = "Total Calories: 1200";

            // 
            // btn_LogMeals
            // 
            this.btn_LogMeals.Location = new System.Drawing.Point(10, 100);
            this.btn_LogMeals.Name = "btn_LogMeals";
            this.btn_LogMeals.Size = new System.Drawing.Size(120, 30);
            this.btn_LogMeals.TabIndex = 2;
            this.btn_LogMeals.Text = "Log Meals";
            this.btn_LogMeals.UseVisualStyleBackColor = true;
            this.btn_LogMeals.Click += new System.EventHandler(this.btn_LogMeals_Click);

            // 
            // btn_MyProgress
            // 
            this.btn_MyProgress.Location = new System.Drawing.Point(260, 200);
            this.btn_MyProgress.Name = "btn_MyProgress";
            this.btn_MyProgress.Size = new System.Drawing.Size(120, 30);
            this.btn_MyProgress.TabIndex = 3;
            this.btn_MyProgress.Text = "My Progress";
            this.btn_MyProgress.UseVisualStyleBackColor = true;
            this.btn_MyProgress.Click += new System.EventHandler(this.btn_MyProgress_Click);

            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Location = new System.Drawing.Point(20, 200);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(100, 30);
            this.btn_LogOut.TabIndex = 4;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);

            // 
            // MainPage
            // 
            this.ClientSize = new System.Drawing.Size(680, 250);
            this.Controls.Add(this.grp_Workout);
            this.Controls.Add(this.grp_Nutrition);
            this.Controls.Add(this.btn_MyProgress);
            this.Controls.Add(this.btn_LogOut);
            this.Name = "MainPage";
            this.Text = "Main Page";
            this.grp_Workout.ResumeLayout(false);
            this.grp_Workout.PerformLayout();
            this.grp_Nutrition.ResumeLayout(false);
            this.grp_Nutrition.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Workout;
        private System.Windows.Forms.Label lbl_WorkoutToday;
        private System.Windows.Forms.Label lbl_WorkoutHours;
        private System.Windows.Forms.Button btn_LogWorkout;
        private System.Windows.Forms.GroupBox grp_Nutrition;
        private System.Windows.Forms.Label lbl_NutritionToday;
        private System.Windows.Forms.Label lbl_TotalCalories;
        private System.Windows.Forms.Button btn_LogMeals;
        private System.Windows.Forms.Button btn_MyProgress;
        private System.Windows.Forms.Button btn_LogOut;
    }
}