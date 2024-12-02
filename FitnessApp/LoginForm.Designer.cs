namespace FitnessApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            lbl_Username = new Label();
            txt_Username = new TextBox();
            lbl_Password = new Label();
            txt_Password = new TextBox();
            btn_Login = new Button();
            btn_Exit = new Button();
            panel_Header = new Panel();
            panel_Header.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lbl_Title.ForeColor = Color.White;
            lbl_Title.Location = new Point(100, 20);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(205, 46);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "Fitness App";
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_Username.Location = new Point(50, 120);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(111, 28);
            lbl_Username.TabIndex = 1;
            lbl_Username.Text = "Username:";
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(50, 150);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(300, 27);
            txt_Username.TabIndex = 2;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_Password.Location = new Point(50, 200);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(106, 28);
            lbl_Password.TabIndex = 3;
            lbl_Password.Text = "Password:";
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(50, 230);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(300, 27);
            txt_Password.TabIndex = 4;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.DarkOrange;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Login.ForeColor = Color.White;
            btn_Login.Location = new Point(50, 300);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(300, 39);
            btn_Login.TabIndex = 5;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = Color.White;
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Exit.ForeColor = Color.DarkOrange;
            btn_Exit.Location = new Point(50, 360);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(300, 41);
            btn_Exit.TabIndex = 6;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // panel_Header
            // 
            panel_Header.BackColor = Color.DarkOrange;
            panel_Header.Controls.Add(lbl_Title);
            panel_Header.Dock = DockStyle.Top;
            panel_Header.Location = new Point(0, 0);
            panel_Header.Name = "panel_Header";
            panel_Header.Size = new Size(400, 80);
            panel_Header.TabIndex = 0;
            // 
            // LoginForm
            // 
            BackColor = Color.Orange;
            ClientSize = new Size(400, 500);
            Controls.Add(panel_Header);
            Controls.Add(lbl_Username);
            Controls.Add(txt_Username);
            Controls.Add(lbl_Password);
            Controls.Add(txt_Password);
            Controls.Add(btn_Login);
            Controls.Add(btn_Exit);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login to Fitness App";
            panel_Header.ResumeLayout(false);
            panel_Header.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel_Header;
    }
}
