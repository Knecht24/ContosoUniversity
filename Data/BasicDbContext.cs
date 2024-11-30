using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class BasicDbContext(DbContextOptions<BasicDbContext> options) : DbContext(options)
    {
        public DbSet<Course> Courses { get; set; }
       public DbSet<Enrollment> Enrollments { get; set; }
       public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
};