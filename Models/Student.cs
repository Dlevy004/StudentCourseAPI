using System.ComponentModel.DataAnnotations;

namespace StudentCourseAPI.Models
{
    public class Student
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
