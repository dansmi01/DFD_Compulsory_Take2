namespace DFD_StdMgm.Models;

public class Course
{
    public int CourseID { get; set; }
    public string CourseName { get; set; }
    public string? Grade { get; set; }   // traditionelm danish 7 step grade
    public DateTime? CourseStart { get; set; }       // default date
    //Related model
    public int? ProfessorID { get; set; }
    public Professor? Professor { get; set; }

    public int? DepartmentID { get; set; }
    public Department? Department { get; set; }
    
    public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}