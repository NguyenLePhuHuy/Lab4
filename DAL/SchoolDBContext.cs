using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public SchoolDbContext() : base("name=SchoolDBConnectionString")
        { }
    }
}
