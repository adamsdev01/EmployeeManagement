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

       
    }
}
