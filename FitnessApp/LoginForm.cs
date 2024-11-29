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
        }

        private void InitializeLoginForm()
        {
            this.Text = "Login to Fitness App";
            this.Width = 400;
            this.Height = 500;
            this.StartPosition = FormStartPosition.CenterParent;

            Label lbl_Title = new Label();
            lbl_Title.Text = "Fitness App";
            lbl_Title.Font = new System.Drawing.Font("Arial", 20, System.Drawing.FontStyle.Bold);
            lbl_Title.AutoSize = true;
            lbl_Title.Location = new System.Drawing.Point(120, 50);
            this.Controls.Add(lbl_Title);

            Label lbl_Username = new Label();
            lbl_Username.Text = "Username:";
            lbl_Username.Location = new System.Drawing.Point(50, 150);
            lbl_Username.AutoSize = true;
            this.Controls.Add(lbl_Username);

            TextBox txt_Username = new TextBox();
            txt_Username.Name = "txtUsername";
            txt_Username.Location = new System.Drawing.Point(150, 145);
            txt_Username.Width = 180;
            this.Controls.Add(txt_Username);

            Label lbl_Password = new Label();
            lbl_Password.Text = "Password:";
            lbl_Password.Location = new System.Drawing.Point(50, 200);
            lbl_Password.AutoSize = true;
            this.Controls.Add(lbl_Password);

            TextBox txt_Password = new TextBox();
            txt_Password.Name = "txtPassword";
            txt_Password.Location = new System.Drawing.Point(150, 195);
            txt_Password.Width = 180;
            txt_Password.PasswordChar = '*';
            this.Controls.Add(txt_Password);

            Button btn_Login = new Button();
            btn_Login.Text = "Login";
            btn_Login.Location = new System.Drawing.Point(150, 250);
            btn_Login.Click += new EventHandler(btn_Login_Click);
            this.Controls.Add(btn_Login);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = ((TextBox)this.Controls["txtUsername"]).Text;
            string password = ((TextBox)this.Controls["txtPassword"]).Text;

            if (username == "user" && password == "password")
            {
                MessageBox.Show("Login Successful!", "Welcome");

                // Pass the DbContext to the MainPage
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

