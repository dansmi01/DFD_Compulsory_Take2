namespace DFD_StdMgm.Models;

public class Enrollment
{
    //PK
    public long EnrollmentId { get; set; }
    //FK
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    //Relations
    public Student Student { get; set; } = null;
    public Course Course { get; set; } = null;
}