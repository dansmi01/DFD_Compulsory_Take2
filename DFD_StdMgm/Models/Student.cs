using System.ComponentModel.DataAnnotations;

namespace DFD_StdMgm.Models;

public class Student
{
    [Key]
    public int StudentID { get; set; }
    public string StudentName { get; set; } = "";
    public int StudentAge { get; set; }

    public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

}