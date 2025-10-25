using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Code { get; set; } = string.Empty;

        [Required]
        [Range(1, 10, ErrorMessage = "Credits must be between 1 and 10")]
        public int Credits { get; set; }  // New property

        [Required]
        public int TeacherId { get; set; }

        public Teachers? Teacher { get; set; }

        public List<Enrollment> Enrollments { get; set; } = new();
    }
}
