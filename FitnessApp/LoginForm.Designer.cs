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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_Username = new Label();
            lbl_Password = new Label();
            txt_Username = new TextBox();
            txt_Password = new TextBox();
            btn_Login = new Button();
            SuspendLayout();
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Location = new Point(126, 125);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(81, 20);
            lbl_Username.TabIndex = 0;
            lbl_Username.Text = "UserName:";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(126, 222);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(73, 20);
            lbl_Password.TabIndex = 1;
            lbl_Password.Text = "Password:";
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(126, 257);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(125, 27);
            txt_Username.TabIndex = 2;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(126, 148);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(125, 27);
            txt_Password.TabIndex = 3;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(140, 344);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(94, 29);
            btn_Login.TabIndex = 4;
            btn_Login.Text = "Log In";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 453);
            Controls.Add(btn_Login);
            Controls.Add(txt_Password);
            Controls.Add(txt_Username);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Username);
            Name = "LoginForm";
            Text = "Log to Fitness App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Username;
        private Label lbl_Password;
        private TextBox txt_Username;
        private TextBox txt_Password;
        private Button btn_Login;
    }
}
