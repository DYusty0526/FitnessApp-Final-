﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitnessApp.Migrations
{
    [DbContext(typeof(FitnessAppContext))]
    partial class FitnessAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FitnessApp.AttendanceRecord", b =>
                {
                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Month")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("AttendanceRecords");
                });

            modelBuilder.Entity("FitnessApp.CalorieRecord", b =>
                {
                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalCalories")
                        .HasColumnType("int");

                    b.ToTable("CalorieRecords");
                });

            modelBuilder.Entity("FitnessApp.ExerciseGoal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DaysToExercise")
                        .HasColumnType("int");

                    b.Property<int>("DurationMinutes")
                        .HasColumnType("int");

                    b.Property<int>("GoalType")
                        .HasColumnType("int");

                    b.Property<bool>("IsWeekly")
                        .HasColumnType("bit");

                    b.Property<int>("TotalExercises")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ExerciseGoals");
                });

            modelBuilder.Entity("FitnessApp.Goal", b =>
                {
                    b.Property<int>("GoalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GoalId"));

                    b.Property<int>("ExerciseDays")
                        .HasColumnType("int");

                    b.Property<int>("ExerciseDuration")
                        .HasColumnType("int");

                    b.Property<int>("ExercisesCount")
                        .HasColumnType("int");

                    b.Property<bool>("IsWeekly")
                        .HasColumnType("bit");

                    b.Property<int>("MaxCalories")
                        .HasColumnType("int");

                    b.Property<int>("MaxCarbs")
                        .HasColumnType("int");

                    b.Property<int>("MaxFat")
                        .HasColumnType("int");

                    b.Property<int>("MaxProtein")
                        .HasColumnType("int");

                    b.Property<int>("MealsCount")
                        .HasColumnType("int");

                    b.HasKey("GoalId");

                    b.ToTable("Goals");
                });

            modelBuilder.Entity("FitnessApp.Meal", b =>
                {
                    b.Property<int>("MealId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MealId"));

                    b.Property<int>("Calories")
                        .HasColumnType("int");

                    b.Property<int>("CarbsPercentage")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FatPercentage")
                        .HasColumnType("int");

                    b.Property<DateTime>("MealDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MealName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProteinPercentage")
                        .HasColumnType("int");

                    b.HasKey("MealId");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("FitnessApp.NutritionGoal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GoalType")
                        .HasColumnType("int");

                    b.Property<bool>("IsWeekly")
                        .HasColumnType("bit");

                    b.Property<int>("MaxCalories")
                        .HasColumnType("int");

                    b.Property<string>("MaxMacros")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Meals")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("NutritionGoals");
                });

            modelBuilder.Entity("FitnessApp.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("Repetitions")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Workouts");
                });
#pragma warning restore 612, 618
        }
    }
}
