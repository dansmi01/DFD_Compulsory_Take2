namespace DFD_StdMgm.Models;

public class Professor
{
    public int ProfessorID { get; set; }
    public string ProfessorName { get; set; } = "";
    public string? ProfessorTitle { get; set; }

    // FK
    public int DepartmentID { get; set; }

    // Relations
    public Department Department { get; set; } = null!;
    public ICollection<Course> Courses { get; set; } = new List<Course>();
}