namespace FitnessApp
{
    partial class YourNutritionPage
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
            this.lbl_DailyMeals = new System.Windows.Forms.Label();
            this.dgv_DailyMeals = new System.Windows.Forms.DataGridView();
            this.lbl_TotalCalories = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_MyGoals = new System.Windows.Forms.Button();
            this.chart_Calories = new System.Windows.Forms.Panel();
            this.lbl_CaloriesGraph = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DailyMeals)).BeginInit();
            this.SuspendLayout();

            // 
            // lbl_CaloriesGraph
            // 
            this.lbl_CaloriesGraph.AutoSize = true;
            this.lbl_CaloriesGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_CaloriesGraph.Location = new System.Drawing.Point(20, 20);
            this.lbl_CaloriesGraph.Name = "lbl_CaloriesGraph";
            this.lbl_CaloriesGraph.Size = new System.Drawing.Size(172, 25);
            this.lbl_CaloriesGraph.TabIndex = 0;
            this.lbl_CaloriesGraph.Text = "Calories (Last 7 Days)";

            // 
            // chart_Calories
            // 
            this.chart_Calories.Location = new System.Drawing.Point(20, 50);
            this.chart_Calories.Name = "chart_Calories";
            this.chart_Calories.Size = new System.Drawing.Size(600, 200);
            this.chart_Calories.TabIndex = 1;
            this.chart_Calories.BackColor = System.Drawing.Color.White;

            // 
            // lbl_DailyMeals
            // 
            this.lbl_DailyMeals.AutoSize = true;
            this.lbl_DailyMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_DailyMeals.Location = new System.Drawing.Point(20, 270);
            this.lbl_DailyMeals.Name = "lbl_DailyMeals";
            this.lbl_DailyMeals.Size = new System.Drawing.Size(123, 25);
            this.lbl_DailyMeals.TabIndex = 2;
            this.lbl_DailyMeals.Text = "Daily Meals";

            // 
            // dgv_DailyMeals
            // 
            this.dgv_DailyMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DailyMeals.Location = new System.Drawing.Point(20, 300);
            this.dgv_DailyMeals.Name = "dgv_DailyMeals";
            this.dgv_DailyMeals.RowHeadersWidth = 51;
            this.dgv_DailyMeals.RowTemplate.Height = 24;
            this.dgv_DailyMeals.Size = new System.Drawing.Size(600, 200);
            this.dgv_DailyMeals.TabIndex = 3;

            // 
            // lbl_TotalCalories
            // 
            this.lbl_TotalCalories.AutoSize = true;
            this.lbl_TotalCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_TotalCalories.Location = new System.Drawing.Point(20, 520);
            this.lbl_TotalCalories.Name = "lbl_TotalCalories";
            this.lbl_TotalCalories.Size = new System.Drawing.Size(143, 25);
            this.lbl_TotalCalories.TabIndex = 4;
            this.lbl_TotalCalories.Text = "Total Calories: 0";

            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(20, 560);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 30);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);

            // 
            // btn_MyGoals
            // 
            this.btn_MyGoals.Location = new System.Drawing.Point(520, 560);
            this.btn_MyGoals.Name = "btn_MyGoals";
            this.btn_MyGoals.Size = new System.Drawing.Size(100, 30);
            this.btn_MyGoals.TabIndex = 6;
            this.btn_MyGoals.Text = "My Goals";
            this.btn_MyGoals.UseVisualStyleBackColor = true;
            this.btn_MyGoals.Click += new System.EventHandler(this.btn_MyGoals_Click);

            // 
            // YourNutritionPage
            // 
            this.ClientSize = new System.Drawing.Size(650, 620);
            this.Controls.Add(this.lbl_CaloriesGraph);
            this.Controls.Add(this.chart_Calories);
            this.Controls.Add(this.lbl_DailyMeals);
            this.Controls.Add(this.dgv_DailyMeals);
            this.Controls.Add(this.lbl_TotalCalories);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_MyGoals);
            this.Name = "YourNutritionPage";
            this.Text = "Your Nutrition";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DailyMeals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_CaloriesGraph;
        private System.Windows.Forms.Panel chart_Calories;
        private System.Windows.Forms.Label lbl_DailyMeals;
        private System.Windows.Forms.DataGridView dgv_DailyMeals;
        private System.Windows.Forms.Label lbl_TotalCalories;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_MyGoals;
    }
}