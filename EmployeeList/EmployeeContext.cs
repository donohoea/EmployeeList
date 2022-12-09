using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeeList
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData
              (new Employee { EmployeeId = 1, Gender = "male", Title = "Mr.", GivenName = "Kenneth", MiddleIntial = "J", Surname = "Montero", Ciy = "Richmond Hill", State = "ON", ZipCode = "L4C 3Y2", Birthday = new DateTime(7/18/1968) });
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
