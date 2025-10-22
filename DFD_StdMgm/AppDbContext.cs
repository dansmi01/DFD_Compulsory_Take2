using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using DFD_StdMgm.Models;
using System.IO;


namespace DFD_StdMgm;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
    {
    }
    
    // Parameterless constructor for direct instantiation
    public AppDbContext()
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=StudentMgm;User Id=sa;Password=yourStrong(!)Password;TrustServerCertificate=True;");
        }
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        // Table Creating
        modelBuilder.Entity<Student>().ToTable("Student");
        modelBuilder.Entity<Course>().ToTable("Course");
        modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
        
        base.OnModelCreating(modelBuilder);
        
        //Primary key clarifycation
        modelBuilder.Entity<Student>().HasKey(s => s.StudentID);
        modelBuilder.Entity<Course>().HasKey(c => c.CourseID);
        modelBuilder.Entity<Enrollment>().HasKey(e => e.EnrollmentId);
        
        
        //Create table relatioship 
        modelBuilder.Entity<Enrollment>()
            .HasOne(e => e.Student)
            .WithMany(s => s.Enrollments)
            .HasForeignKey(e => e.StudentId);

        modelBuilder.Entity<Enrollment>()
            .HasOne(e => e.Course)
            .WithMany(c => c.Enrollments)
            .HasForeignKey(e => e.CourseId);
    }
}