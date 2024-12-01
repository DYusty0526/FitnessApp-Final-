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
            this.grp_Workouts = new System.Windows.Forms.GroupBox();
            this.lst_Workouts = new System.Windows.Forms.ListBox();
            this.grp_Nutrition = new System.Windows.Forms.GroupBox();
            this.lst_Meals = new System.Windows.Forms.ListBox();
            this.btn_LogWorkout = new System.Windows.Forms.Button();
            this.btn_LogMeals = new System.Windows.Forms.Button();
            this.btn_ViewGoals = new System.Windows.Forms.Button();
            this.btn_ViewProgress = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // GroupBox: Workouts
            this.grp_Workouts.Controls.Add(this.lst_Workouts);
            this.grp_Workouts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grp_Workouts.Location = new System.Drawing.Point(20, 20);
            this.grp_Workouts.Name = "grp_Workouts";
            this.grp_Workouts.Size = new System.Drawing.Size(180, 200);
            this.grp_Workouts.TabIndex = 0;
            this.grp_Workouts.TabStop = false;
            this.grp_Workouts.Text = "Today's Workouts";

            // ListBox: Workouts
            this.lst_Workouts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_Workouts.FormattingEnabled = true;
            this.lst_Workouts.ItemHeight = 20;
            this.lst_Workouts.Location = new System.Drawing.Point(3, 23);
            this.lst_Workouts.Name = "lst_Workouts";
            this.lst_Workouts.Size = new System.Drawing.Size(174, 174);
            this.lst_Workouts.TabIndex = 1;

            // GroupBox: Nutrition
            this.grp_Nutrition.Controls.Add(this.lst_Meals);
            this.grp_Nutrition.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grp_Nutrition.Location = new System.Drawing.Point(210, 20);
            this.grp_Nutrition.Name = "grp_Nutrition";
            this.grp_Nutrition.Size = new System.Drawing.Size(180, 200);
            this.grp_Nutrition.TabIndex = 2;
            this.grp_Nutrition.TabStop = false;
            this.grp_Nutrition.Text = "Today's Meals";

            // ListBox: Meals
            this.lst_Meals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_Meals.FormattingEnabled = true;
            this.lst_Meals.ItemHeight = 20;
            this.lst_Meals.Location = new System.Drawing.Point(3, 23);
            this.lst_Meals.Name = "lst_Meals";
            this.lst_Meals.Size = new System.Drawing.Size(174, 174);
            this.lst_Meals.TabIndex = 3;

            // Button: Log Workout
            this.btn_LogWorkout.Location = new System.Drawing.Point(20, 230);
            this.btn_LogWorkout.Name = "btn_LogWorkout";
            this.btn_LogWorkout.Size = new System.Drawing.Size(150, 40);
            this.btn_LogWorkout.TabIndex = 4;
            this.btn_LogWorkout.Text = "Log Workout";
            this.btn_LogWorkout.UseVisualStyleBackColor = true;
            this.btn_LogWorkout.Click += new System.EventHandler(this.btn_LogWorkout_Click);

            // Button: Log Meals
            this.btn_LogMeals.Location = new System.Drawing.Point(210, 230);
            this.btn_LogMeals.Name = "btn_LogMeals";
            this.btn_LogMeals.Size = new System.Drawing.Size(150, 40);
            this.btn_LogMeals.TabIndex = 5;
            this.btn_LogMeals.Text = "Log Meals";
            this.btn_LogMeals.UseVisualStyleBackColor = true;
            this.btn_LogMeals.Click += new System.EventHandler(this.btn_LogMeals_Click);

            // Button: View Goals
            this.btn_ViewGoals.Location = new System.Drawing.Point(20, 280);
            this.btn_ViewGoals.Name = "btn_ViewGoals";
            this.btn_ViewGoals.Size = new System.Drawing.Size(150, 40);
            this.btn_ViewGoals.TabIndex = 6;
            this.btn_ViewGoals.Text = "View My Goals";
            this.btn_ViewGoals.UseVisualStyleBackColor = true;
            this.btn_ViewGoals.Click += new System.EventHandler(this.btn_ViewGoals_Click);

            // Button: View Progress
            this.btn_ViewProgress.Location = new System.Drawing.Point(210, 280);
            this.btn_ViewProgress.Name = "btn_ViewProgress";
            this.btn_ViewProgress.Size = new System.Drawing.Size(150, 40);
            this.btn_ViewProgress.TabIndex = 7;
            this.btn_ViewProgress.Text = "View My Progress";
            this.btn_ViewProgress.UseVisualStyleBackColor = true;
            this.btn_ViewProgress.Click += new System.EventHandler(this.btn_ViewProgress_Click);

            // Button: Logout
            this.btn_LogOut.Location = new System.Drawing.Point(20, 330);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(340, 40);
            this.btn_LogOut.TabIndex = 8;
            this.btn_LogOut.Text = "Logout";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);

            // MainPage
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.grp_Workouts);
            this.Controls.Add(this.grp_Nutrition);
            this.Controls.Add(this.btn_LogWorkout);
            this.Controls.Add(this.btn_LogMeals);
            this.Controls.Add(this.btn_ViewGoals);
            this.Controls.Add(this.btn_ViewProgress);
            this.Controls.Add(this.btn_LogOut);
            this.Name = "MainPage";
            this.Text = "Fitness App - Main Page";
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.GroupBox grp_Workouts;
        private System.Windows.Forms.ListBox lst_Workouts;
        private System.Windows.Forms.GroupBox grp_Nutrition;
        private System.Windows.Forms.ListBox lst_Meals;
        private System.Windows.Forms.Button btn_LogWorkout;
        private System.Windows.Forms.Button btn_LogMeals;
        private System.Windows.Forms.Button btn_ViewGoals;
        private System.Windows.Forms.Button btn_ViewProgress;
        private System.Windows.Forms.Button btn_LogOut;
    }
}