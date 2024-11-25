using System;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            InitializeLoginForm();
        }

        private void InitializeLoginForm()
        {
            this.Text = "Login to Fitness App";
            this.Width = 400;
            this.Height = 500;
            this.StartPosition = FormStartPosition.CenterParent;

            Label lbl_Title = new Label();
            lbl_Title.Text = "Fitness App";
            lbl_Title.Font = new System.Drawing.Font("Ariel", 20, System.Drawing.FontStyle.Bold);
            lbl_Title.AutoSize = true;
            lbl_Title.Location = new System.Drawing.Point(120, 50);
            this.Controls.Add(lbl_Title);

            lbl_Username.Text = "Username:";
            lbl_Username.Location = new System.Drawing.Point(50, 150);
            lbl_Username.AutoSize = true;
            this.Controls.Add(lbl_Username);

            txt_Username.Name = "txtUsername";
            txt_Username.Location = new System.Drawing.Point(150, 145);
            txt_Username.Width = 180;
            this.Controls.Add(txt_Username);

            lbl_Password.Text = "Password:";
            lbl_Password.Location = new System.Drawing.Point(50, 200);
            lbl_Password.AutoSize = true;
            this.Controls.Add(lbl_Password);

            txt_Password.Name = "txtPassword";
            txt_Password.Location = new System.Drawing.Point(150, 195);
            txt_Password.Width = 180;
            txt_Password.PasswordChar = '*';
            this.Controls.Add(txt_Password);


        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = ((TextBox)this.Controls["txtUsername"]).Text;
            string password = ((TextBox)this.Controls["txtPassword"]).Text;

            if (username == "user" && password == "password") // Example: Hardcoded credentials
            {
                MessageBox.Show("Login Successful!", "Welcome");
             
                this.Hide();
                MainPage mainPage = new MainPage();
                mainPage.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error");
            }
        }
    }
}
