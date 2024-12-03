using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.IO;

public class FitnessAppContextFactory : IDesignTimeDbContextFactory<FitnessAppContext>
{
    public FitnessAppContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<FitnessAppContext>();

        // connection string here
        optionsBuilder.UseSqlServer("Server=CUYABRO-LAPTOP2\\SQLEXPRESS;Database=FitnessAppDB;Trusted_Connection=True;TrustServerCertificate=True;");

        return new FitnessAppContext(optionsBuilder.Options);
    }
}