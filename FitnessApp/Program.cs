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
            // Set up Dependency Injection
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // Build the service provider
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Start the application using the Login Form
            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<LoginForm>());
        }

        // Method to configure services for DI
        private static void ConfigureServices(IServiceCollection services)
        {
            // Add the DbContext with SQL Server configuration
            services.AddDbContext<FitnessAppContext>(options =>
                options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FitnessAppDB;Trusted_Connection=True;"));

            // Add forms to DI so they can use FitnessAppContext
            services.AddTransient<LoginForm>();
            services.AddTransient<MainPage>();
            services.AddTransient<LogWorkoutPage>();
            services.AddTransient<LogMealsPage>();
            services.AddTransient<WorkoutHistoryPage>();
            services.AddTransient<MyGoalsPage>();
            services.AddTransient<MyProgressPage>();
        }
    }
}
