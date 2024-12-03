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
            lbl_Title = new Label();
            lbl_MealName = new Label();
            txt_MealName = new TextBox();
            lbl_Description = new Label();
            txt_Description = new TextBox();
            lbl_Calories = new Label();
            txt_Calories = new TextBox();
            lbl_Macros = new Label();
            txt_Protein = new TextBox();
            txt_Carbs = new TextBox();
            txt_Fat = new TextBox();
            lbl_Date = new Label();
            dtp_Date = new DateTimePicker();
            btn_AddMeal = new Button();
            btn_DeleteMeal = new Button();
            btn_Refresh = new Button();
            btn_ViewHistory = new Button();
            btn_Back = new Button();
            dgv_Meals = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_Meals).BeginInit();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lbl_Title.ForeColor = Color.White;
            lbl_Title.Location = new Point(220, 20);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(213, 37);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "Log Your Meals";
            // 
            // lbl_MealName
            // 
            lbl_MealName.AutoSize = true;
            lbl_MealName.ForeColor = Color.White;
            lbl_MealName.Location = new Point(20, 80);
            lbl_MealName.Name = "lbl_MealName";
            lbl_MealName.Size = new Size(86, 20);
            lbl_MealName.TabIndex = 1;
            lbl_MealName.Text = "Meal Name";
            // 
            // txt_MealName
            // 
            txt_MealName.Location = new Point(150, 80);
            txt_MealName.Name = "txt_MealName";
            txt_MealName.Size = new Size(200, 27);
            txt_MealName.TabIndex = 2;
            // 
            // lbl_Description
            // 
            lbl_Description.AutoSize = true;
            lbl_Description.ForeColor = Color.White;
            lbl_Description.Location = new Point(20, 120);
            lbl_Description.Name = "lbl_Description";
            lbl_Description.Size = new Size(85, 20);
            lbl_Description.TabIndex = 3;
            lbl_Description.Text = "Description";
            // 
            // txt_Description
            // 
            txt_Description.Location = new Point(150, 120);
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new Size(200, 27);
            txt_Description.TabIndex = 4;
            // 
            // lbl_Calories
            // 
            lbl_Calories.AutoSize = true;
            lbl_Calories.ForeColor = Color.White;
            lbl_Calories.Location = new Point(20, 160);
            lbl_Calories.Name = "lbl_Calories";
            lbl_Calories.Size = new Size(62, 20);
            lbl_Calories.TabIndex = 5;
            lbl_Calories.Text = "Calories";
            // 
            // txt_Calories
            // 
            txt_Calories.Location = new Point(150, 160);
            txt_Calories.Name = "txt_Calories";
            txt_Calories.Size = new Size(200, 27);
            txt_Calories.TabIndex = 6;
            // 
            // lbl_Macros
            // 
            lbl_Macros.AutoSize = true;
            lbl_Macros.ForeColor = Color.White;
            lbl_Macros.Location = new Point(20, 200);
            lbl_Macros.Name = "lbl_Macros";
            lbl_Macros.Size = new Size(57, 20);
            lbl_Macros.TabIndex = 7;
            lbl_Macros.Text = "Macros";
            // 
            // txt_Protein
            // 
            txt_Protein.Location = new Point(150, 200);
            txt_Protein.Name = "txt_Protein";
            txt_Protein.PlaceholderText = "Protein (%)";
            txt_Protein.Size = new Size(60, 27);
            txt_Protein.TabIndex = 8;
            // 
            // txt_Carbs
            // 
            txt_Carbs.Location = new Point(220, 200);
            txt_Carbs.Name = "txt_Carbs";
            txt_Carbs.PlaceholderText = "Carbs (%)";
            txt_Carbs.Size = new Size(60, 27);
            txt_Carbs.TabIndex = 9;
            // 
            // txt_Fat
            // 
            txt_Fat.Location = new Point(290, 200);
            txt_Fat.Name = "txt_Fat";
            txt_Fat.PlaceholderText = "Fat (%)";
            txt_Fat.Size = new Size(60, 27);
            txt_Fat.TabIndex = 10;
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.ForeColor = Color.White;
            lbl_Date.Location = new Point(20, 240);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(41, 20);
            lbl_Date.TabIndex = 11;
            lbl_Date.Text = "Date";
            // 
            // dtp_Date
            // 
            dtp_Date.Location = new Point(150, 240);
            dtp_Date.Name = "dtp_Date";
            dtp_Date.Size = new Size(200, 27);
            dtp_Date.TabIndex = 12;
            // 
            // btn_AddMeal
            // 
            btn_AddMeal.Location = new Point(20, 290);
            btn_AddMeal.Name = "btn_AddMeal";
            btn_AddMeal.Size = new Size(100, 30);
            btn_AddMeal.TabIndex = 13;
            btn_AddMeal.Text = "Add Meal";
            btn_AddMeal.UseVisualStyleBackColor = true;
            btn_AddMeal.Click += btn_AddMeal_Click;
            // 
            // btn_DeleteMeal
            // 
            btn_DeleteMeal.Location = new Point(130, 290);
            btn_DeleteMeal.Name = "btn_DeleteMeal";
            btn_DeleteMeal.Size = new Size(100, 30);
            btn_DeleteMeal.TabIndex = 14;
            btn_DeleteMeal.Text = "Delete Meal";
            btn_DeleteMeal.UseVisualStyleBackColor = true;
            btn_DeleteMeal.Click += btn_DeleteMeal_Click;
            // 
            // btn_Refresh
            // 
            btn_Refresh.Location = new Point(350, 290);
            btn_Refresh.Name = "btn_Refresh";
            btn_Refresh.Size = new Size(100, 30);
            btn_Refresh.TabIndex = 15;
            btn_Refresh.Text = "Refresh";
            btn_Refresh.UseVisualStyleBackColor = true;
            btn_Refresh.Click += btn_Refresh_Click;
            // 
            // btn_ViewHistory
            // 
            btn_ViewHistory.BackColor = Color.White;
            btn_ViewHistory.FlatStyle = FlatStyle.Flat;
            btn_ViewHistory.ForeColor = Color.DarkOrange;
            btn_ViewHistory.Location = new Point(538, 560);
            btn_ViewHistory.Name = "btn_ViewHistory";
            btn_ViewHistory.Size = new Size(150, 30);
            btn_ViewHistory.TabIndex = 19;
            btn_ViewHistory.Text = "View History";
            btn_ViewHistory.UseVisualStyleBackColor = true;
            btn_ViewHistory.Click += btn_ViewHistory_Click;
            // 
            // btn_Back
            // 
            btn_Back.Location = new Point(20, 560);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(100, 30);
            btn_Back.TabIndex = 19;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // dgv_Meals
            // 
            dgv_Meals.ColumnHeadersHeight = 29;
            dgv_Meals.Location = new Point(20, 340);
            dgv_Meals.Name = "dgv_Meals";
            dgv_Meals.RowHeadersWidth = 51;
            dgv_Meals.Size = new Size(600, 200);
            dgv_Meals.TabIndex = 18;
            // 
            // LogMealsPage
            // 
            BackColor = Color.DarkOrange;
            ClientSize = new Size(700, 600);
            Controls.Add(lbl_Title);
            Controls.Add(lbl_MealName);
            Controls.Add(txt_MealName);
            Controls.Add(lbl_Description);
            Controls.Add(txt_Description);
            Controls.Add(lbl_Calories);
            Controls.Add(txt_Calories);
            Controls.Add(lbl_Macros);
            Controls.Add(txt_Protein);
            Controls.Add(txt_Carbs);
            Controls.Add(txt_Fat);
            Controls.Add(lbl_Date);
            Controls.Add(dtp_Date);
            Controls.Add(btn_AddMeal);
            Controls.Add(btn_DeleteMeal);
            Controls.Add(btn_Refresh);
            Controls.Add(btn_ViewHistory);
            Controls.Add(dgv_Meals);
            Controls.Add(btn_Back);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "LogMealsPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log Meals";
            ((System.ComponentModel.ISupportInitialize)dgv_Meals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
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
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_ViewHistory;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DataGridView dgv_Meals;
    }
}


