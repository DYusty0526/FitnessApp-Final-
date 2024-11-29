namespace FitnessApp
{
    partial class LogMealsPage
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
            this.lbl_MealName = new System.Windows.Forms.Label();
            this.txt_MealName = new System.Windows.Forms.TextBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lbl_Calories = new System.Windows.Forms.Label();
            this.txt_Calories = new System.Windows.Forms.TextBox();
            this.lbl_Macros = new System.Windows.Forms.Label();
            this.txt_Protein = new System.Windows.Forms.TextBox();
            this.txt_Carbs = new System.Windows.Forms.TextBox();
            this.txt_Fat = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_AddMeal = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_ViewHistory = new System.Windows.Forms.Button();

            // 
            // lbl_MealName
            // 
            this.lbl_MealName.AutoSize = true;
            this.lbl_MealName.Location = new System.Drawing.Point(20, 20);
            this.lbl_MealName.Name = "lbl_MealName";
            this.lbl_MealName.Size = new System.Drawing.Size(82, 20);
            this.lbl_MealName.TabIndex = 0;
            this.lbl_MealName.Text = "Meal Name:";

            // 
            // txt_MealName
            // 
            this.txt_MealName.Location = new System.Drawing.Point(150, 20);
            this.txt_MealName.Name = "txt_MealName";
            this.txt_MealName.Size = new System.Drawing.Size(200, 26);
            this.txt_MealName.TabIndex = 1;

            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(20, 60);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(87, 20);
            this.lbl_Description.TabIndex = 2;
            this.lbl_Description.Text = "Description:";

            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(150, 60);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(200, 26);
            this.txt_Description.TabIndex = 3;

            // 
            // lbl_Calories
            // 
            this.lbl_Calories.AutoSize = true;
            this.lbl_Calories.Location = new System.Drawing.Point(20, 100);
            this.lbl_Calories.Name = "lbl_Calories";
            this.lbl_Calories.Size = new System.Drawing.Size(65, 20);
            this.lbl_Calories.TabIndex = 4;
            this.lbl_Calories.Text = "Calories:";

            // 
            // txt_Calories
            // 
            this.txt_Calories.Location = new System.Drawing.Point(150, 100);
            this.txt_Calories.Name = "txt_Calories";
            this.txt_Calories.Size = new System.Drawing.Size(200, 26);
            this.txt_Calories.TabIndex = 5;

            // 
            // lbl_Macros
            // 
            this.lbl_Macros.AutoSize = true;
            this.lbl_Macros.Location = new System.Drawing.Point(20, 140);
            this.lbl_Macros.Name = "lbl_Macros";
            this.lbl_Macros.Size = new System.Drawing.Size(62, 20);
            this.lbl_Macros.TabIndex = 6;
            this.lbl_Macros.Text = "Macros:";

            // 
            // txt_Protein
            // 
            this.txt_Protein.Location = new System.Drawing.Point(150, 140);
            this.txt_Protein.Name = "txt_Protein";
            this.txt_Protein.PlaceholderText = "Protein";
            this.txt_Protein.Size = new System.Drawing.Size(60, 26);
            this.txt_Protein.TabIndex = 7;

            // 
            // txt_Carbs
            // 
            this.txt_Carbs.Location = new System.Drawing.Point(220, 140);
            this.txt_Carbs.Name = "txt_Carbs";
            this.txt_Carbs.PlaceholderText = "Carbs";
            this.txt_Carbs.Size = new System.Drawing.Size(60, 26);
            this.txt_Carbs.TabIndex = 8;

            // 
            // txt_Fat
            // 
            this.txt_Fat.Location = new System.Drawing.Point(290, 140);
            this.txt_Fat.Name = "txt_Fat";
            this.txt_Fat.PlaceholderText = "Fat";
            this.txt_Fat.Size = new System.Drawing.Size(60, 26);
            this.txt_Fat.TabIndex = 9;

            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(20, 180);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(45, 20);
            this.lbl_Date.TabIndex = 10;
            this.lbl_Date.Text = "Date:";

            // 
            // dtp_Date
            // 
            this.dtp_Date.Location = new System.Drawing.Point(150, 180);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(200, 26);
            this.dtp_Date.TabIndex = 11;

            // 
            // btn_AddMeal
            // 
            this.btn_AddMeal.Location = new System.Drawing.Point(20, 240);
            this.btn_AddMeal.Name = "btn_AddMeal";
            this.btn_AddMeal.Size = new System.Drawing.Size(120, 30);
            this.btn_AddMeal.TabIndex = 12;
            this.btn_AddMeal.Text = "Add Meal";
            this.btn_AddMeal.UseVisualStyleBackColor = true;
            this.btn_AddMeal.Click += new System.EventHandler(this.btn_AddMeal_Click);

            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(20, 290);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 30);
            this.btn_Back.TabIndex = 13;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);

            // 
            // btn_ViewHistory
            // 
            this.btn_ViewHistory.Location = new System.Drawing.Point(230, 290);
            this.btn_ViewHistory.Name = "btn_ViewHistory";
            this.btn_ViewHistory.Size = new System.Drawing.Size(120, 30);
            this.btn_ViewHistory.TabIndex = 14;
            this.btn_ViewHistory.Text = "View History";
            this.btn_ViewHistory.UseVisualStyleBackColor = true;
            this.btn_ViewHistory.Click += new System.EventHandler(this.btn_ViewHistory_Click);

            // 
            // LogMealsPage
            // 
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.lbl_MealName);
            this.Controls.Add(this.txt_MealName);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.lbl_Calories);
            this.Controls.Add(this.txt_Calories);
            this.Controls.Add(this.lbl_Macros);
            this.Controls.Add(this.txt_Protein);
            this.Controls.Add(this.txt_Carbs);
            this.Controls.Add(this.txt_Fat);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.btn_AddMeal);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_ViewHistory);
            this.Name = "LogMealsPage";
            this.Text = "Log Meals";
        }

        #endregion

        private System.Windows.Forms.Label lbl_MealName;
        private System.Windows.Forms.TextBox txt_MealName;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label lbl_Calories;
        private System.Windows.Forms.TextBox txt_Calories;
        private System.Windows.Forms.Label lbl_Macros;
        private System.Windows.Forms.TextBox txt_Protein;
        private System.Windows.Forms.TextBox txt_Carbs;
        private System.Windows.Forms.TextBox txt_Fat;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Button btn_AddMeal;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_ViewHistory;
    }
}
