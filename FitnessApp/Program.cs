using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace FitnessApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Configure DbContext globally
            var optionsBuilder = new DbContextOptionsBuilder<FitnessAppContext>();
            optionsBuilder.UseSqlServer("Server=CUYABRO-LAPTOP2\\SQLEXPRESS;Database=FitnessAppDB;Trusted_Connection=True;TrustServerCertificate=True;");
            var context = new FitnessAppContext(optionsBuilder.Options);

            // Start application with LoginForm
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm(context));
        }
    }
}
