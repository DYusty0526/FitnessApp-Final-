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
            this.pnl_CalorieChart = new System.Windows.Forms.Panel();
            this.dgv_NutritionLog = new System.Windows.Forms.DataGridView();
            this.lbl_TotalCalories = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_MyGoals = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgv_NutritionLog)).BeginInit();

            // 
            // pnl_CalorieChart
            // 
            this.pnl_CalorieChart.Location = new System.Drawing.Point(20, 20);
            this.pnl_CalorieChart.Name = "pnl_CalorieChart";
            this.pnl_CalorieChart.Size = new System.Drawing.Size(460, 200);
            this.pnl_CalorieChart.TabIndex = 0;
            this.pnl_CalorieChart.BackColor = System.Drawing.Color.White;

            // 
            // dgv_NutritionLog
            // 
            this.dgv_NutritionLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NutritionLog.Location = new System.Drawing.Point(20, 240);
            this.dgv_NutritionLog.Name = "dgv_NutritionLog";
            this.dgv_NutritionLog.Size = new System.Drawing.Size(460, 150);
            this.dgv_NutritionLog.TabIndex = 1;

            // 
            // lbl_TotalCalories
            // 
            this.lbl_TotalCalories.AutoSize = true;
            this.lbl_TotalCalories.Location = new System.Drawing.Point(20, 400);
            this.lbl_TotalCalories.Name = "lbl_TotalCalories";
            this.lbl_TotalCalories.Size = new System.Drawing.Size(107, 20);
            this.lbl_TotalCalories.TabIndex = 2;
            this.lbl_TotalCalories.Text = "Total Calories: 0";

            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(20, 440);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 30);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;

            // 
            // btn_MyGoals
            // 
            this.btn_MyGoals.Location = new System.Drawing.Point(380, 440);
            this.btn_MyGoals.Name = "btn_MyGoals";
            this.btn_MyGoals.Size = new System.Drawing.Size(100, 30);
            this.btn_MyGoals.TabIndex = 4;
            this.btn_MyGoals.Text = "My Goals";
            this.btn_MyGoals.UseVisualStyleBackColor = true;

            // 
            // YourNutritionPage
            // 
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.pnl_CalorieChart);
            this.Controls.Add(this.dgv_NutritionLog);
            this.Controls.Add(this.lbl_TotalCalories);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_MyGoals);
            this.Name = "YourNutritionPage";
            this.Text = "Your Nutrition";

            ((System.ComponentModel.ISupportInitialize)(this.dgv_NutritionLog)).EndInit();
        }

        #endregion

        private System.Windows.Forms.Panel pnl_CalorieChart;
        private System.Windows.Forms.DataGridView dgv_NutritionLog;
        private System.Windows.Forms.Label lbl_TotalCalories;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_MyGoals;
    }
}