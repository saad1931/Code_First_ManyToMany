using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Code_First_ManyToMany.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options)
            : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-CT235QF;Initial Catalog=Student(M-M);Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.ID, sc.CourseID });

            modelBuilder.Entity<StudentCourse>()
                .HasOne<Student>(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(Sa => Sa.ID);

            modelBuilder.Entity<StudentCourse>()
                .HasOne<Course>(sc => sc.Course)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sa => sa.CourseID);
                

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> CourseS { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
    }
}
