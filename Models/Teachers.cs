using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Models
{
    public class Teachers
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Department { get; set; }

        public string? Email { get; set; }
    }
}
