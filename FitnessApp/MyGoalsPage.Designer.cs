namespace FitnessApp
{
    partial class MyGoalsPage
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
            this.lbl_ExerciseGoals = new System.Windows.Forms.Label();
            this.txt_ExerciseDays = new System.Windows.Forms.TextBox();
            this.txt_Exercises = new System.Windows.Forms.TextBox();
            this.txt_ExerciseDuration = new System.Windows.Forms.TextBox();
            this.btn_SetExerciseGoal = new System.Windows.Forms.Button();
            this.lbl_NutritionGoals = new System.Windows.Forms.Label();
            this.txt_Meals = new System.Windows.Forms.TextBox();
            this.txt_MaxCalories = new System.Windows.Forms.TextBox();
            this.txt_MaxMacros = new System.Windows.Forms.TextBox();
            this.btn_SetNutritionGoal = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_MyProgress = new System.Windows.Forms.Button();

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
            this.rbtn_Weekly.CheckedChanged += new System.EventHandler(this.ToggleGoalType);

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
            this.rbtn_Monthly.CheckedChanged += new System.EventHandler(this.ToggleGoalType);

            // 
            // lbl_ExerciseGoals
            // 
            this.lbl_ExerciseGoals.AutoSize = true;
            this.lbl_ExerciseGoals.Location = new System.Drawing.Point(20, 60);
            this.lbl_ExerciseGoals.Name = "lbl_ExerciseGoals";
            this.lbl_ExerciseGoals.Size = new System.Drawing.Size(107, 20);
            this.lbl_ExerciseGoals.TabIndex = 2;
            this.lbl_ExerciseGoals.Text = "Exercise Goals";

            // 
            // txt_ExerciseDays
            // 
            this.txt_ExerciseDays.Location = new System.Drawing.Point(20, 90);
            this.txt_ExerciseDays.Name = "txt_ExerciseDays";
            this.txt_ExerciseDays.PlaceholderText = "Days to Exercise";
            this.txt_ExerciseDays.Size = new System.Drawing.Size(200, 26);
            this.txt_ExerciseDays.TabIndex = 3;

            // 
            // txt_Exercises
            // 
            this.txt_Exercises.Location = new System.Drawing.Point(20, 130);
            this.txt_Exercises.Name = "txt_Exercises";
            this.txt_Exercises.PlaceholderText = "Number of Exercises";
            this.txt_Exercises.Size = new System.Drawing.Size(200, 26);
            this.txt_Exercises.TabIndex = 4;

            // 
            // txt_ExerciseDuration
            // 
            this.txt_ExerciseDuration.Location = new System.Drawing.Point(20, 170);
            this.txt_ExerciseDuration.Name = "txt_ExerciseDuration";
            this.txt_ExerciseDuration.PlaceholderText = "Exercise Duration (mins)";
            this.txt_ExerciseDuration.Size = new System.Drawing.Size(200, 26);
            this.txt_ExerciseDuration.TabIndex = 5;

            // 
            // btn_SetExerciseGoal
            // 
            this.btn_SetExerciseGoal.Location = new System.Drawing.Point(20, 210);
            this.btn_SetExerciseGoal.Name = "btn_SetExerciseGoal";
            this.btn_SetExerciseGoal.Size = new System.Drawing.Size(120, 30);
            this.btn_SetExerciseGoal.TabIndex = 6;
            this.btn_SetExerciseGoal.Text = "Set Exercise Goal";
            this.btn_SetExerciseGoal.UseVisualStyleBackColor = true;
            this.btn_SetExerciseGoal.BackColor = System.Drawing.Color.White;
            this.btn_SetExerciseGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SetExerciseGoal.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_SetExerciseGoal.Click += new System.EventHandler(this.btn_SetExerciseGoal_Click);

            // 
            // lbl_NutritionGoals
            // 
            this.lbl_NutritionGoals.AutoSize = true;
            this.lbl_NutritionGoals.Location = new System.Drawing.Point(250, 60);
            this.lbl_NutritionGoals.Name = "lbl_NutritionGoals";
            this.lbl_NutritionGoals.Size = new System.Drawing.Size(104, 20);
            this.lbl_NutritionGoals.TabIndex = 7;
            this.lbl_NutritionGoals.Text = "Nutrition Goals";

            // 
            // txt_Meals
            // 
            this.txt_Meals.Location = new System.Drawing.Point(250, 90);
            this.txt_Meals.Name = "txt_Meals";
            this.txt_Meals.PlaceholderText = "Number of Meals";
            this.txt_Meals.Size = new System.Drawing.Size(200, 26);
            this.txt_Meals.TabIndex = 8;

            // 
            // txt_MaxCalories
            // 
            this.txt_MaxCalories.Location = new System.Drawing.Point(250, 130);
            this.txt_MaxCalories.Name = "txt_MaxCalories";
            this.txt_MaxCalories.PlaceholderText = "Max Calories";
            this.txt_MaxCalories.Size = new System.Drawing.Size(200, 26);
            this.txt_MaxCalories.TabIndex = 9;

            // 
            // txt_MaxMacros
            // 
            this.txt_MaxMacros.Location = new System.Drawing.Point(250, 170);
            this.txt_MaxMacros.Name = "txt_MaxMacros";
            this.txt_MaxMacros.PlaceholderText = "Max Macros";
            this.txt_MaxMacros.Size = new System.Drawing.Size(200, 26);
            this.txt_MaxMacros.TabIndex = 10;

            // 
            // btn_SetNutritionGoal
            // 
            this.btn_SetNutritionGoal.Location = new System.Drawing.Point(250, 210);
            this.btn_SetNutritionGoal.Name = "btn_SetNutritionGoal";
            this.btn_SetNutritionGoal.Size = new System.Drawing.Size(120, 30);
            this.btn_SetNutritionGoal.TabIndex = 11;
            this.btn_SetNutritionGoal.Text = "Set Nutrition Goal";
            this.btn_SetNutritionGoal.UseVisualStyleBackColor = true;
            this.btn_SetExerciseGoal.BackColor = System.Drawing.Color.White;
            this.btn_SetExerciseGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SetExerciseGoal.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_SetNutritionGoal.Click += new System.EventHandler(this.btn_SetNutritionGoal_Click);

            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(20, 260);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 30);
            this.btn_Back.TabIndex = 12;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_SetExerciseGoal.BackColor = System.Drawing.Color.White;
            this.btn_SetExerciseGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SetExerciseGoal.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);

            // 
            // btn_MyProgress
            // 
            this.btn_MyProgress.Location = new System.Drawing.Point(350, 260);
            this.btn_MyProgress.Name = "btn_MyProgress";
            this.btn_MyProgress.Size = new System.Drawing.Size(100, 30);
            this.btn_MyProgress.TabIndex = 13;
            this.btn_MyProgress.Text = "My Progress";
            this.btn_MyProgress.UseVisualStyleBackColor = true;
            this.btn_SetExerciseGoal.BackColor = System.Drawing.Color.White;
            this.btn_SetExerciseGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SetExerciseGoal.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_MyProgress.Click += new System.EventHandler(this.btn_MyProgress_Click);

            // 
            // MyGoalsPage
            // 
            this.ClientSize = new System.Drawing.Size(480, 320);
            this.Controls.Add(this.rbtn_Weekly);
            this.Controls.Add(this.rbtn_Monthly);
            this.Controls.Add(this.lbl_ExerciseGoals);
            this.Controls.Add(this.txt_ExerciseDays);
            this.Controls.Add(this.txt_Exercises);
            this.Controls.Add(this.txt_ExerciseDuration);
            this.Controls.Add(this.btn_SetExerciseGoal);
            this.Controls.Add(this.lbl_NutritionGoals);
            this.Controls.Add(this.txt_Meals);
            this.Controls.Add(this.txt_MaxCalories);
            this.Controls.Add(this.txt_MaxMacros);
            this.Controls.Add(this.btn_SetNutritionGoal);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_MyProgress);
            this.Name = "MyGoalsPage";
            this.Text = "Set Your Goals";
            this.BackColor = System.Drawing.Color.DarkOrange;

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_Weekly;
        private System.Windows.Forms.RadioButton rbtn_Monthly;
        private System.Windows.Forms.Label lbl_ExerciseGoals;
        private System.Windows.Forms.TextBox txt_ExerciseDays;
        private System.Windows.Forms.TextBox txt_Exercises;
        private System.Windows.Forms.TextBox txt_ExerciseDuration;
        private System.Windows.Forms.Button btn_SetExerciseGoal;
        private System.Windows.Forms.Label lbl_NutritionGoals;
        private System.Windows.Forms.TextBox txt_Meals;
        private System.Windows.Forms.TextBox txt_MaxCalories;
        private System.Windows.Forms.TextBox txt_MaxMacros;
        private System.Windows.Forms.Button btn_SetNutritionGoal;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_MyProgress;

    }
}