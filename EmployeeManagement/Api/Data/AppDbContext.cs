using Microsoft.EntityFrameworkCore;
using Models;
using System;

namespace Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=Server-Name;Database=EmployeeV2DB;Trusted_Connection=True;MultipleActiveResultSets=true");


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Departments Table
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "Information Technology" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "Humar Resources" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 4, DepartmentName = "Administration" });

            // Seed Employee Table
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "Poppy",
                LastName = "Li",
                EmailAddress = "Poppy.Li@opus.com",
                DOB = new DateTime(2000, 10, 05),
                Gender = Gender.Female,
                DepartmentId = 1,
                PhotoPath = "images/personStock.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                FirstName = "Brad",
                LastName = "Baskshi",
                EmailAddress = "Brad.Baskshi@opus.com",
                DOB = new DateTime(1987, 11, 15),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/personStock.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "Richard",
                LastName = "Hendricks",
                EmailAddress = "Richard.Hendricks@opus.com",
                DOB = new DateTime(1979, 01, 01),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/personStock.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                FirstName = "Malcolm",
                LastName = "Adekanbi",
                EmailAddress = "Malcolm.Adekanbi@opus.com",
                DOB = new DateTime(1980, 03, 22),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/personStock.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 5,
                FirstName = "Elliot",
                LastName = "Alderson",
                EmailAddress = "Elliot.Alderson@opus.com",
                DOB = new DateTime(1986, 09, 17),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/personStock.jpg"
            });
        }
    }
}
