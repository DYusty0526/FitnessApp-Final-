using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessApp;
using Microsoft.EntityFrameworkCore;

public class FitnessAppContext : DbContext
{
    // Constructor that passes options to the base DbContext class
    public FitnessAppContext(DbContextOptions<FitnessAppContext> options) : base(options)
    {
    }

    // DbSets represent tables in the database
    public DbSet<Workout> Workouts { get; set; }
    public DbSet<Meal> Meals { get; set; }
    public DbSet<Goal> Goals { get; set; }
    public DbSet<ExerciseGoal> ExerciseGoals { get; set; }
    public DbSet<NutritionGoal> NutritionGoals { get; set; }
    public DbSet<CalorieRecord> CalorieRecords { get; set; }
    public DbSet<AttendanceRecord> AttendanceRecords { get; set; } // Ensure proper capitalization

    // Configure the model
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Mark AttendanceRecord as keyless
        modelBuilder.Entity<AttendanceRecord>().HasNoKey();

        // If needed, mark CalorieRecord as keyless (depending on its usage)
        modelBuilder.Entity<CalorieRecord>().HasNoKey();
    }
}

