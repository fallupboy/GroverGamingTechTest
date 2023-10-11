using Microsoft.EntityFrameworkCore;

namespace EmployeeDirectory.Models
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=employees.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Tim", JobTitle = "Software Engineer" },
                new Employee { Id = 2, Name = "Justin", JobTitle = "Project Manager" },
                new Employee { Id = 3, Name = "Robert", JobTitle = "Associate" },
                new Employee { Id = 4, Name = "Jason", JobTitle = "UI/UX Designer" });
        }
    }
}
