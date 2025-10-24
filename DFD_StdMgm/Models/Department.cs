namespace DFD_StdMgm.Models;

public class Department
{
    public int DepartmentID { get; set; }
    public string DepartmentName { get; set; } = "";

    // One department can have multiple professors and courses
    public ICollection<Professor> Professors { get; set; } = new List<Professor>();
    public ICollection<Course> Courses { get; set; } = new List<Course>();
}