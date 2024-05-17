using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.ComponentModel;
using System.Reflection.Emit;
using VacancyProject.Entities;

namespace VacancyProject.Context
{
    public class VacancyDbContext : DbContext
    {
        public VacancyDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
    }
}
