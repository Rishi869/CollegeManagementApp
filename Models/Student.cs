using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace CollegeApp.Models
{
public class Student
{
public int Id { get; set; }
[Required] public string? Name { get; set; }
[EmailAddress] public string? Email { get; set; }
public string? Phone { get; set; }
public ICollection<Enrollment>? Enrollments { get; set; }
}
}