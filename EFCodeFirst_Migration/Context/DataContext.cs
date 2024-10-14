using EFCodeFirst_Migration.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst_Migration.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("ProductDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<
               DataContext, EFCodeFirst_Migration.Migrations.Configuration>());
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Student> Students { get; set; }
    }
}
