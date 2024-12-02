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
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text.Trim();
            string password = txt_Password.Text.Trim();

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
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

