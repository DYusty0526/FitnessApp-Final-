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
            this.btn_DeleteMeal = new System.Windows.Forms.Button();
            this.btn_UpdateMeal = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_ViewHistory = new System.Windows.Forms.Button();
            this.dgv_Meals = new System.Windows.Forms.DataGridView();
            this.btn_Back = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgv_Meals)).BeginInit();
            this.SuspendLayout();

            // Label: Meal Name
            this.lbl_MealName.AutoSize = true;
            this.lbl_MealName.Location = new System.Drawing.Point(20, 20);
            this.lbl_MealName.Name = "lbl_MealName";
            this.lbl_MealName.Size = new System.Drawing.Size(82, 20);
            this.lbl_MealName.TabIndex = 0;
            this.lbl_MealName.Text = "Meal Name";

            // TextBox: Meal Name
            this.txt_MealName.Location = new System.Drawing.Point(150, 20);
            this.txt_MealName.Name = "txt_MealName";
            this.txt_MealName.Size = new System.Drawing.Size(200, 26);
            this.txt_MealName.TabIndex = 1;

            // Label: Description
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(20, 60);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(85, 20);
            this.lbl_Description.TabIndex = 2;
            this.lbl_Description.Text = "Description";

            // TextBox: Description
            this.txt_Description.Location = new System.Drawing.Point(150, 60);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(200, 26);
            this.txt_Description.TabIndex = 3;

            // Label: Calories
            this.lbl_Calories.AutoSize = true;
            this.lbl_Calories.Location = new System.Drawing.Point(20, 100);
            this.lbl_Calories.Name = "lbl_Calories";
            this.lbl_Calories.Size = new System.Drawing.Size(64, 20);
            this.lbl_Calories.TabIndex = 4;
            this.lbl_Calories.Text = "Calories";

            // TextBox: Calories
            this.txt_Calories.Location = new System.Drawing.Point(150, 100);
            this.txt_Calories.Name = "txt_Calories";
            this.txt_Calories.Size = new System.Drawing.Size(200, 26);
            this.txt_Calories.TabIndex = 5;

            // Label: Macros
            this.lbl_Macros.AutoSize = true;
            this.lbl_Macros.Location = new System.Drawing.Point(20, 140);
            this.lbl_Macros.Name = "lbl_Macros";
            this.lbl_Macros.Size = new System.Drawing.Size(59, 20);
            this.lbl_Macros.TabIndex = 6;
            this.lbl_Macros.Text = "Macros";

            // TextBox: Protein
            this.txt_Protein.Location = new System.Drawing.Point(150, 140);
            this.txt_Protein.Name = "txt_Protein";
            this.txt_Protein.PlaceholderText = "Protein (%)";
            this.txt_Protein.Size = new System.Drawing.Size(60, 26);
            this.txt_Protein.TabIndex = 7;

            // TextBox: Carbs
            this.txt_Carbs.Location = new System.Drawing.Point(220, 140);
            this.txt_Carbs.Name = "txt_Carbs";
            this.txt_Carbs.PlaceholderText = "Carbs (%)";
            this.txt_Carbs.Size = new System.Drawing.Size(60, 26);
            this.txt_Carbs.TabIndex = 8;

            // TextBox: Fat
            this.txt_Fat.Location = new System.Drawing.Point(290, 140);
            this.txt_Fat.Name = "txt_Fat";
            this.txt_Fat.PlaceholderText = "Fat (%)";
            this.txt_Fat.Size = new System.Drawing.Size(60, 26);
            this.txt_Fat.TabIndex = 9;

            // Label: Date
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(20, 180);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(38, 20);
            this.lbl_Date.TabIndex = 10;
            this.lbl_Date.Text = "Date";

            // DateTimePicker: Date
            this.dtp_Date.Location = new System.Drawing.Point(150, 180);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(200, 26);
            this.dtp_Date.TabIndex = 11;

            // Button: Add Meal
            this.btn_AddMeal.Location = new System.Drawing.Point(20, 220);
            this.btn_AddMeal.Name = "btn_AddMeal";
            this.btn_AddMeal.Size = new System.Drawing.Size(100, 30);
            this.btn_AddMeal.TabIndex = 12;
            this.btn_AddMeal.Text = "Add Meal";
            this.btn_AddMeal.UseVisualStyleBackColor = true;
            this.btn_AddMeal.Click += new System.EventHandler(this.btn_AddMeal_Click);

            // Button: Delete Meal
            this.btn_DeleteMeal.Location = new System.Drawing.Point(130, 220);
            this.btn_DeleteMeal.Name = "btn_DeleteMeal";
            this.btn_DeleteMeal.Size = new System.Drawing.Size(100, 30);
            this.btn_DeleteMeal.TabIndex = 13;
            this.btn_DeleteMeal.Text = "Delete Meal";
            this.btn_DeleteMeal.UseVisualStyleBackColor = true;
            this.btn_DeleteMeal.Click += new System.EventHandler(this.btn_DeleteMeal_Click);

            // Button: Update Meal
            this.btn_UpdateMeal.Location = new System.Drawing.Point(240, 220);
            this.btn_UpdateMeal.Name = "btn_UpdateMeal";
            this.btn_UpdateMeal.Size = new System.Drawing.Size(100, 30);
            this.btn_UpdateMeal.TabIndex = 14;
            this.btn_UpdateMeal.Text = "Update Meal";
            this.btn_UpdateMeal.UseVisualStyleBackColor = true;
            this.btn_UpdateMeal.Click += new System.EventHandler(this.btn_UpdateMeal_Click);

            // Button: Refresh
            this.btn_Refresh.Location = new System.Drawing.Point(350, 220);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(100, 30);
            this.btn_Refresh.TabIndex = 15;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);

            // Button: View History
            this.btn_ViewHistory.Location = new System.Drawing.Point(460, 220);
            this.btn_ViewHistory.Name = "btn_ViewHistory";
            this.btn_ViewHistory.Size = new System.Drawing.Size(150, 30);
            this.btn_ViewHistory.TabIndex = 16;
            this.btn_ViewHistory.Text = "View History";
            this.btn_ViewHistory.UseVisualStyleBackColor = true;
            this.btn_ViewHistory.Click += new System.EventHandler(this.btn_ViewHistory_Click);

            // DataGridView: Meals
            this.dgv_Meals.Location = new System.Drawing.Point(20, 270);
            this.dgv_Meals.Name = "dgv_Meals";
            this.dgv_Meals.Size = new System.Drawing.Size(600, 200);
            this.dgv_Meals.TabIndex = 17;

            // Button: Back
            this.btn_Back.Location = new System.Drawing.Point(20, 490);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 30);
            this.btn_Back.TabIndex = 18;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);

            // LogMealsPage
            this.ClientSize = new System.Drawing.Size(650, 550);
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
            this.Controls.Add(this.btn_DeleteMeal);
            this.Controls.Add(this.btn_UpdateMeal);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_ViewHistory);
            this.Controls.Add(this.dgv_Meals);
            this.Controls.Add(this.btn_Back);
            this.Name = "LogMealsPage";
            this.Text = "Log Meals";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Meals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
        private System.Windows.Forms.Button btn_DeleteMeal;
        private System.Windows.Forms.Button btn_UpdateMeal;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_ViewHistory;
        private System.Windows.Forms.DataGridView dgv_Meals;
        private System.Windows.Forms.Button btn_Back;
    }
}

