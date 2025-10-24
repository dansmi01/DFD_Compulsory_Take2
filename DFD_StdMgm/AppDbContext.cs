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
    public DbSet<Professor> Professors { get; set; }
    public DbSet<Department> Departments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        // Table Creating
        modelBuilder.Entity<Student>().ToTable("Student");
        modelBuilder.Entity<Course>().ToTable("Course");
        modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
        modelBuilder.Entity<Professor>().ToTable("Professor");
        modelBuilder.Entity<Department>().ToTable("Department");
        
        base.OnModelCreating(modelBuilder);
        
        // Primary key clarifycation
        modelBuilder.Entity<Student>().HasKey(s => s.StudentID);
        modelBuilder.Entity<Course>().HasKey(c => c.CourseID);
        modelBuilder.Entity<Enrollment>().HasKey(e => e.EnrollmentId);
        //add professor department
        modelBuilder.Entity<Professor>().HasKey(p => p.ProfessorID);
        modelBuilder.Entity<Department>().HasKey(d => d.DepartmentID);
        // Create table relatioship 
        modelBuilder.Entity<Enrollment>()
            .HasOne(e => e.Student)
            .WithMany(s => s.Enrollments)
            .HasForeignKey(e => e.StudentId);

        modelBuilder.Entity<Enrollment>()
            .HasOne(e => e.Course)
            .WithMany(c => c.Enrollments)
            .HasForeignKey(e => e.CourseId);
        //Professor departement relationship
        modelBuilder.Entity<Professor>()
            .HasOne(p => p.Department)
            .WithMany(d => d.Professors)
            .HasForeignKey(p => p.DepartmentID);

        modelBuilder.Entity<Course>()
            .HasOne(c => c.Professor)
            .WithMany(p => p.Courses)
            .HasForeignKey(c => c.ProfessorID)
            .IsRequired(false);

        modelBuilder.Entity<Course>()
            .HasOne(c => c.Department)
            .WithMany(d => d.Courses)
            .HasForeignKey(c => c.DepartmentID)
            .IsRequired(false);
            
            
        // insert base data in database
        modelBuilder.Entity<Student>().HasData(
            new Student { StudentID = 1, StudentName = "Alice Johnson", StudentAge = 20 },
            new Student { StudentID = 2, StudentName = "Bob Smith", StudentAge = 21 },
            new Student { StudentID = 3, StudentName = "Charlie Brown", StudentAge = 22 },
            new Student { StudentID = 4, StudentName = "Diana Prince", StudentAge = 23 },
            new Student { StudentID = 5, StudentName = "Ethan Hunt", StudentAge = 24 }
        );

        modelBuilder.Entity<Course>().HasData(
            new Course { CourseID = 1, CourseName = "Mathematics", Grade = null ,CourseStart = null},
            new Course { CourseID = 2, CourseName = "Physics", Grade = null,CourseStart = null },
            new Course { CourseID = 3, CourseName = "Chemistry", Grade = null ,CourseStart = null},
            new Course { CourseID = 4, CourseName = "Biology", Grade = null ,CourseStart = null},
            new Course { CourseID = 5, CourseName = "Computer Science", Grade = null ,CourseStart = null}
        );

        modelBuilder.Entity<Enrollment>().HasData(
            new Enrollment { EnrollmentId = 1, StudentId = 1, CourseId = 1 },
            new Enrollment { EnrollmentId = 2, StudentId = 1, CourseId = 2 },
            new Enrollment { EnrollmentId = 3, StudentId = 1, CourseId = 3 },
            new Enrollment { EnrollmentId = 4, StudentId = 1, CourseId = 4 },
            new Enrollment { EnrollmentId = 5, StudentId = 2, CourseId = 1 },
            new Enrollment { EnrollmentId = 6, StudentId = 2, CourseId = 2 },
            new Enrollment { EnrollmentId = 7, StudentId = 2, CourseId = 3 },
            new Enrollment { EnrollmentId = 8, StudentId = 2, CourseId = 4 },
            new Enrollment { EnrollmentId = 9, StudentId = 3, CourseId = 1 },
            new Enrollment { EnrollmentId = 10, StudentId = 3, CourseId = 2 },
            new Enrollment { EnrollmentId = 11, StudentId = 3, CourseId = 3 },
            new Enrollment { EnrollmentId = 12, StudentId = 4, CourseId = 1 },
            new Enrollment { EnrollmentId = 13, StudentId = 4, CourseId = 2 },
            new Enrollment { EnrollmentId = 14, StudentId = 4, CourseId = 3 }
        );
        modelBuilder.Entity<Department>().HasData(
            new Department { DepartmentID = 1, DepartmentName = "Computer Science Department"},
            new Department { DepartmentID = 2, DepartmentName = "Biology Department"},
            new Department { DepartmentID = 3, DepartmentName = "Physics Department"},
            new Department { DepartmentID = 4, DepartmentName = "Chemistry Department"}

        );
        modelBuilder.Entity<Professor>().HasData(
            new Professor { ProfessorID = 1, DepartmentID = 3, ProfessorName = "Anders Sand", ProfessorTitle = "Teacher" },
            new Professor { ProfessorID = 2, DepartmentID = 4, ProfessorName = "Benny Larsen", ProfessorTitle = "Teacher" },
            new Professor { ProfessorID = 3, DepartmentID = 1, ProfessorName = "Christine Smith", ProfessorTitle = "Teacher" }
        );

    }
}