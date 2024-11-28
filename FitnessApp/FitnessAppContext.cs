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

}
