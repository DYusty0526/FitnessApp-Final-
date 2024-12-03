using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Migrations
{
    /// <inheritdoc />
    public partial class RemoveGoalAndCalorieRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalorieRecords");

            migrationBuilder.DropTable(
                name: "Goals");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalorieRecords",
                columns: table => new
                {
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalCalories = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    GoalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseDays = table.Column<int>(type: "int", nullable: false),
                    ExerciseDuration = table.Column<int>(type: "int", nullable: false),
                    ExercisesCount = table.Column<int>(type: "int", nullable: false),
                    IsWeekly = table.Column<bool>(type: "bit", nullable: false),
                    MaxCalories = table.Column<int>(type: "int", nullable: false),
                    MaxCarbs = table.Column<int>(type: "int", nullable: false),
                    MaxFat = table.Column<int>(type: "int", nullable: false),
                    MaxProtein = table.Column<int>(type: "int", nullable: false),
                    MealsCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.GoalId);
                });
        }
    }
}
