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
            grp_Exercise = new GroupBox();
            lbl_TodayWorkout = new Label();
            btn_LogWorkout = new Button();
            grp_Nutrition = new GroupBox();
            lbl_TodayMeals = new Label();
            btn_LogMeals = new Button();
            btn_ViewGoals = new Button();
            btn_ViewProgress = new Button();
            btn_LogOut = new Button();
            grp_Exercise.SuspendLayout();
            grp_Nutrition.SuspendLayout();
            SuspendLayout();
            // 
            // grp_Exercise
            // 
            grp_Exercise.Controls.Add(lbl_TodayWorkout);
            grp_Exercise.Controls.Add(btn_LogWorkout);
            grp_Exercise.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grp_Exercise.ForeColor = Color.DarkOrange;
            grp_Exercise.Location = new Point(20, 20);
            grp_Exercise.Name = "grp_Exercise";
            grp_Exercise.Size = new Size(360, 100);
            grp_Exercise.TabIndex = 0;
            grp_Exercise.TabStop = false;
            grp_Exercise.Text = "Exercise";
            // 
            // lbl_TodayWorkout
            // 
            lbl_TodayWorkout.AutoSize = true;
            lbl_TodayWorkout.Location = new Point(10, 30);
            lbl_TodayWorkout.Name = "lbl_TodayWorkout";
            lbl_TodayWorkout.Size = new Size(196, 23);
            lbl_TodayWorkout.TabIndex = 0;
            lbl_TodayWorkout.Text = "Today's Workout: None";
            // 
            // btn_LogWorkout
            // 
            btn_LogWorkout.BackColor = Color.DarkOrange;
            btn_LogWorkout.ForeColor = Color.White;
            btn_LogWorkout.Location = new Point(212, 30);
            btn_LogWorkout.Name = "btn_LogWorkout";
            btn_LogWorkout.Size = new Size(128, 52);
            btn_LogWorkout.TabIndex = 1;
            btn_LogWorkout.Text = "Log Workout";
            btn_LogWorkout.UseVisualStyleBackColor = false;
            btn_LogWorkout.Click += btn_LogWorkout_Click;
            // 
            // grp_Nutrition
            // 
            grp_Nutrition.Controls.Add(lbl_TodayMeals);
            grp_Nutrition.Controls.Add(btn_LogMeals);
            grp_Nutrition.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grp_Nutrition.ForeColor = Color.DarkOrange;
            grp_Nutrition.Location = new Point(20, 130);
            grp_Nutrition.Name = "grp_Nutrition";
            grp_Nutrition.Size = new Size(360, 100);
            grp_Nutrition.TabIndex = 1;
            grp_Nutrition.TabStop = false;
            grp_Nutrition.Text = "Nutrition";
            // 
            // lbl_TodayMeals
            // 
            lbl_TodayMeals.AutoSize = true;
            lbl_TodayMeals.Location = new Point(10, 30);
            lbl_TodayMeals.Name = "lbl_TodayMeals";
            lbl_TodayMeals.Size = new Size(171, 23);
            lbl_TodayMeals.TabIndex = 0;
            lbl_TodayMeals.Text = "Today's Meals: None";
            // 
            // btn_LogMeals
            // 
            btn_LogMeals.BackColor = Color.DarkOrange;
            btn_LogMeals.ForeColor = Color.White;
            btn_LogMeals.Location = new Point(220, 30);
            btn_LogMeals.Name = "btn_LogMeals";
            btn_LogMeals.Size = new Size(120, 40);
            btn_LogMeals.TabIndex = 1;
            btn_LogMeals.Text = "Log Meals";
            btn_LogMeals.UseVisualStyleBackColor = false;
            btn_LogMeals.Click += btn_LogMeals_Click;
            // 
            // btn_ViewGoals
            // 
            btn_ViewGoals.BackColor = Color.DarkOrange;
            btn_ViewGoals.ForeColor = Color.White;
            btn_ViewGoals.Location = new Point(20, 250);
            btn_ViewGoals.Name = "btn_ViewGoals";
            btn_ViewGoals.Size = new Size(120, 40);
            btn_ViewGoals.TabIndex = 2;
            btn_ViewGoals.Text = "My Goals";
            btn_ViewGoals.UseVisualStyleBackColor = false;
            btn_ViewGoals.Click += btn_ViewGoals_Click;
            // 
            // btn_ViewProgress
            // 
            btn_ViewProgress.BackColor = Color.DarkOrange;
            btn_ViewProgress.ForeColor = Color.White;
            btn_ViewProgress.Location = new Point(150, 250);
            btn_ViewProgress.Name = "btn_ViewProgress";
            btn_ViewProgress.Size = new Size(120, 40);
            btn_ViewProgress.TabIndex = 3;
            btn_ViewProgress.Text = "My Progress";
            btn_ViewProgress.UseVisualStyleBackColor = false;
            btn_ViewProgress.Click += btn_ViewProgress_Click;
            // 
            // btn_LogOut
            // 
            btn_LogOut.BackColor = Color.DarkOrange;
            btn_LogOut.ForeColor = Color.White;
            btn_LogOut.Location = new Point(280, 250);
            btn_LogOut.Name = "btn_LogOut";
            btn_LogOut.Size = new Size(100, 40);
            btn_LogOut.TabIndex = 4;
            btn_LogOut.Text = "Logout";
            btn_LogOut.UseVisualStyleBackColor = false;
            btn_LogOut.Click += btn_LogOut_Click;
            // 
            // MainPage
            // 
            BackColor = Color.White;
            ClientSize = new Size(400, 350);
            Controls.Add(grp_Exercise);
            Controls.Add(grp_Nutrition);
            Controls.Add(btn_ViewGoals);
            Controls.Add(btn_ViewProgress);
            Controls.Add(btn_LogOut);
            Name = "MainPage";
            Text = "Fitness App - Main Page";
            grp_Exercise.ResumeLayout(false);
            grp_Exercise.PerformLayout();
            grp_Nutrition.ResumeLayout(false);
            grp_Nutrition.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Exercise;
        private System.Windows.Forms.GroupBox grp_Nutrition;
        private System.Windows.Forms.Label lbl_TodayWorkout;
        private System.Windows.Forms.Label lbl_TodayMeals;
        private System.Windows.Forms.Button btn_LogWorkout;
        private System.Windows.Forms.Button btn_LogMeals;
        private System.Windows.Forms.Button btn_ViewGoals;
        private System.Windows.Forms.Button btn_ViewProgress;
        private System.Windows.Forms.Button btn_LogOut;

    }
}