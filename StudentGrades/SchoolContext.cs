using StudentGrades.Models;
using StudentGrades.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace StudentGrades
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
    : base(@"Data Source=DESKTOP-RJ7758H;Initial Catalog=SchoolEFDb;Integrated Security=True")
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}