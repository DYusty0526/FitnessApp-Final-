using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp
{
    public partial class LoginForm : Form
    {
        private readonly FitnessAppContext _context;

        public LoginForm(FitnessAppContext context)
        {
            InitializeComponent();
            _context = context;
            InitializeLoginForm();
        }

        private void InitializeLoginForm()
        {
            this.Text = "Login to Fitness App";
            this.Width = 400;
            this.Height = 300;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Title Label
            Label lbl_Title = new Label
            {
                Text = "Fitness App Login",
                Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold),
                AutoSize = true,
                Location = new System.Drawing.Point(100, 20)
            };
            this.Controls.Add(lbl_Title);

            // Username Label
            Label lbl_Username = new Label
            {
                Text = "Username:",
                Location = new System.Drawing.Point(50, 80),
                AutoSize = true
            };
            this.Controls.Add(lbl_Username);

            // Username TextBox
            TextBox txt_Username = new TextBox
            {
                Name = "txtUsername",
                Location = new System.Drawing.Point(150, 75),
                Width = 180
            };
            this.Controls.Add(txt_Username);

            // Password Label
            Label lbl_Password = new Label
            {
                Text = "Password:",
                Location = new System.Drawing.Point(50, 120),
                AutoSize = true
            };
            this.Controls.Add(lbl_Password);

            // Password TextBox
            TextBox txt_Password = new TextBox
            {
                Name = "txtPassword",
                Location = new System.Drawing.Point(150, 115),
                Width = 180,
                PasswordChar = '*'
            };
            this.Controls.Add(txt_Password);

            // Login Button
            Button btn_Login = new Button
            {
                Text = "Login",
                Location = new System.Drawing.Point(150, 160),
                Width = 100
            };
            btn_Login.Click += btn_Login_Click;
            this.Controls.Add(btn_Login);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            // Get entered credentials
            string username = ((TextBox)this.Controls["txtUsername"]).Text.Trim();
            string password = ((TextBox)this.Controls["txtPassword"]).Text.Trim();

            // Hardcoded login example (replace with actual authentication)
            if (username == "user" && password == "password")
            {
                MessageBox.Show("Login Successful!", "Welcome");

                // Navigate to Main Page
                var mainPage = new MainPage(_context);
                mainPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error");
            }
        }
    }
}

