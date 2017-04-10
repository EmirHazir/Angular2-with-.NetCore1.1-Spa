using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SpaAngularDemo.Models
{
    public class EmployeeDbContext  : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options):base(options)
        {

        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Project> Project { get; set; }
    }
}
