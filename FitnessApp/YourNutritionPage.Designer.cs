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
            this.lbl_TotalCalories = new System.Windows.Forms.Label();
            this.dgv_NutritionLog = new System.Windows.Forms.DataGridView();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_MyGoals = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgv_NutritionLog)).BeginInit();

            // 
            // lbl_TotalCalories
            // 
            this.lbl_TotalCalories.AutoSize = true;
            this.lbl_TotalCalories.Location = new System.Drawing.Point(20, 20);
            this.lbl_TotalCalories.Name = "lbl_TotalCalories";
            this.lbl_TotalCalories.Size = new System.Drawing.Size(180, 20);
            this.lbl_TotalCalories.TabIndex = 0;
            this.lbl_TotalCalories.Text = "Total Calories Consumed: 0";

            // 
            // dgv_NutritionLog
            // 
            this.dgv_NutritionLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NutritionLog.Location = new System.Drawing.Point(20, 270);
            this.dgv_NutritionLog.Name = "dgv_NutritionLog";
            this.dgv_NutritionLog.Size = new System.Drawing.Size(400, 150);
            this.dgv_NutritionLog.TabIndex = 1;

            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(20, 440);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 30);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);

            // 
            // btn_MyGoals
            // 
            this.btn_MyGoals.Location = new System.Drawing.Point(320, 440);
            this.btn_MyGoals.Name = "btn_MyGoals";
            this.btn_MyGoals.Size = new System.Drawing.Size(100, 30);
            this.btn_MyGoals.TabIndex = 3;
            this.btn_MyGoals.Text = "My Goals";
            this.btn_MyGoals.UseVisualStyleBackColor = true;
            this.btn_MyGoals.Click += new System.EventHandler(this.btn_MyGoals_Click);

            // 
            // YourNutritionPage
            // 
            this.ClientSize = new System.Drawing.Size(450, 500);
            this.Controls.Add(this.lbl_TotalCalories);
            this.Controls.Add(this.dgv_NutritionLog);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_MyGoals);
            this.Name = "YourNutritionPage";
            this.Text = "Your Nutrition";

            ((System.ComponentModel.ISupportInitialize)(this.dgv_NutritionLog)).EndInit();
        }

        #endregion

        private System.Windows.Forms.Label lbl_TotalCalories;
        private System.Windows.Forms.DataGridView dgv_NutritionLog;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_MyGoals;
    }
}