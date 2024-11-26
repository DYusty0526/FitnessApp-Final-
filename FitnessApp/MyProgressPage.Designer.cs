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
            this.rbtn_Weekly = new System.Windows.Forms.RadioButton();
            this.rbtn_Monthly = new System.Windows.Forms.RadioButton();
            this.lbl_NutritionProgress = new System.Windows.Forms.Label();
            this.progressBar_Calories = new System.Windows.Forms.ProgressBar();
            this.progressBar_Meals = new System.Windows.Forms.ProgressBar();
            this.lbl_AverageMacros = new System.Windows.Forms.Label();
            this.lbl_FitnessProgress = new System.Windows.Forms.Label();
            this.progressBar_DaysExercised = new System.Windows.Forms.ProgressBar();
            this.progressBar_ExercisesDone = new System.Windows.Forms.ProgressBar();
            this.lbl_AverageExerciseTime = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();

            // 
            // rbtn_Weekly
            // 
            this.rbtn_Weekly.AutoSize = true;
            this.rbtn_Weekly.Location = new System.Drawing.Point(20, 20);
            this.rbtn_Weekly.Name = "rbtn_Weekly";
            this.rbtn_Weekly.Size = new System.Drawing.Size(78, 24);
            this.rbtn_Weekly.TabIndex = 0;
            this.rbtn_Weekly.TabStop = true;
            this.rbtn_Weekly.Text = "Weekly";
            this.rbtn_Weekly.UseVisualStyleBackColor = true;

            this.rbtn_Weekly.CheckedChanged += new System.EventHandler(this.rbtn_Weekly_CheckedChanged);
            this.rbtn_Monthly.CheckedChanged += new System.EventHandler(this.rbtn_Monthly_CheckedChanged);

            // Register event handlers for buttons
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);

            // 
            // rbtn_Monthly
            // 
            this.rbtn_Monthly.AutoSize = true;
            this.rbtn_Monthly.Location = new System.Drawing.Point(120, 20);
            this.rbtn_Monthly.Name = "rbtn_Monthly";
            this.rbtn_Monthly.Size = new System.Drawing.Size(82, 24);
            this.rbtn_Monthly.TabIndex = 1;
            this.rbtn_Monthly.TabStop = true;
            this.rbtn_Monthly.Text = "Monthly";
            this.rbtn_Monthly.UseVisualStyleBackColor = true;

            // 
            // lbl_NutritionProgress
            // 
            this.lbl_NutritionProgress.AutoSize = true;
            this.lbl_NutritionProgress.Location = new System.Drawing.Point(20, 60);
            this.lbl_NutritionProgress.Name = "lbl_NutritionProgress";
            this.lbl_NutritionProgress.Size = new System.Drawing.Size(124, 20);
            this.lbl_NutritionProgress.TabIndex = 2;
            this.lbl_NutritionProgress.Text = "Nutrition Progress";

            // 
            // progressBar_Calories
            // 
            this.progressBar_Calories.Location = new System.Drawing.Point(20, 90);
            this.progressBar_Calories.Name = "progressBar_Calories";
            this.progressBar_Calories.Size = new System.Drawing.Size(400, 20);
            this.progressBar_Calories.TabIndex = 3;

            // 
            // progressBar_Meals
            // 
            this.progressBar_Meals.Location = new System.Drawing.Point(20, 120);
            this.progressBar_Meals.Name = "progressBar_Meals";
            this.progressBar_Meals.Size = new System.Drawing.Size(400, 20);
            this.progressBar_Meals.TabIndex = 4;

            // 
            // lbl_AverageMacros
            // 
            this.lbl_AverageMacros.AutoSize = true;
            this.lbl_AverageMacros.Location = new System.Drawing.Point(20, 150);
            this.lbl_AverageMacros.Name = "lbl_AverageMacros";
            this.lbl_AverageMacros.Size = new System.Drawing.Size(184, 20);
            this.lbl_AverageMacros.TabIndex = 5;
            this.lbl_AverageMacros.Text = "Average Macros: P: 0% C: 0% F: 0%";

            // 
            // lbl_FitnessProgress
            // 
            this.lbl_FitnessProgress.AutoSize = true;
            this.lbl_FitnessProgress.Location = new System.Drawing.Point(20, 190);
            this.lbl_FitnessProgress.Name = "lbl_FitnessProgress";
            this.lbl_FitnessProgress.Size = new System.Drawing.Size(115, 20);
            this.lbl_FitnessProgress.TabIndex = 6;
            this.lbl_FitnessProgress.Text = "Fitness Progress";

            // 
            // progressBar_DaysExercised
            // 
            this.progressBar_DaysExercised.Location = new System.Drawing.Point(20, 220);
            this.progressBar_DaysExercised.Name = "progressBar_DaysExercised";
            this.progressBar_DaysExercised.Size = new System.Drawing.Size(400, 20);
            this.progressBar_DaysExercised.TabIndex = 7;

            // 
            // progressBar_ExercisesDone
            // 
            this.progressBar_ExercisesDone.Location = new System.Drawing.Point(20, 250);
            this.progressBar_ExercisesDone.Name = "progressBar_ExercisesDone";
            this.progressBar_ExercisesDone.Size = new System.Drawing.Size(400, 20);
            this.progressBar_ExercisesDone.TabIndex = 8;

            // 
            // lbl_AverageExerciseTime
            // 
            this.lbl_AverageExerciseTime.AutoSize = true;
            this.lbl_AverageExerciseTime.Location = new System.Drawing.Point(20, 280);
            this.lbl_AverageExerciseTime.Name = "lbl_AverageExerciseTime";
            this.lbl_AverageExerciseTime.Size = new System.Drawing.Size(197, 20);
            this.lbl_AverageExerciseTime.TabIndex = 9;
            this.lbl_AverageExerciseTime.Text = "Average Exercise Time: 0 hrs";

            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(20, 320);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 30);
            this.btn_Back.TabIndex = 10;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);

            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(320, 320);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(100, 30);
            this.btn_Logout.TabIndex = 11;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);

            // 
            // MyProgressPage
            // 
            this.ClientSize = new System.Drawing.Size(450, 370);
            this.Controls.Add(this.rbtn_Weekly);
            this.Controls.Add(this.rbtn_Monthly);
            this.Controls.Add(this.lbl_NutritionProgress);
            this.Controls.Add(this.progressBar_Calories);
            this.Controls.Add(this.progressBar_Meals);
            this.Controls.Add(this.lbl_AverageMacros);
            this.Controls.Add(this.lbl_FitnessProgress);
            this.Controls.Add(this.progressBar_DaysExercised);
            this.Controls.Add(this.progressBar_ExercisesDone);
            this.Controls.Add(this.lbl_AverageExerciseTime);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Logout);
            this.Name = "MyProgressPage";
            this.Text = "Your Progress";
        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_Weekly;
        private System.Windows.Forms.RadioButton rbtn_Monthly;
        private System.Windows.Forms.Label lbl_NutritionProgress;
        private System.Windows.Forms.ProgressBar progressBar_Calories;
        private System.Windows.Forms.ProgressBar progressBar_Meals;
        private System.Windows.Forms.Label lbl_AverageMacros;
        private System.Windows.Forms.Label lbl_FitnessProgress;
        private System.Windows.Forms.ProgressBar progressBar_DaysExercised;
        private System.Windows.Forms.ProgressBar progressBar_ExercisesDone;
        private System.Windows.Forms.Label lbl_AverageExerciseTime;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Logout;
    }
}