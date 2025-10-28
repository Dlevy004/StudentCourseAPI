using System.ComponentModel.DataAnnotations;

namespace StudentCourseAPI.Models
{
    public class Course
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public int Credits { get; set; }
    }
}
