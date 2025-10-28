using Microsoft.AspNetCore.Mvc;
using StudentCourseAPI.Models;

namespace StudentCourseAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public List<Student> GetStudents()
        {
            return _studentService.GetStudents();
        }

        [HttpGet("{id}")]
        public Student GetStudentById(int id)
        {
            return _studentService.GetStudentById(id);
        }

        [HttpPost]
        public void PostStudent(Student student)
        {
            _studentService.AddStudent(student);
        }

        [HttpPut("{id}")]
        public IActionResult AddStudent(int id, [FromBody] Student student)
        {
            if (student.Id != id)
            {
                return BadRequest();
            }
            _studentService.UpdateStudent(student);

            return Ok();
        }

        [HttpDelete("{id}")]
        public void DeleteStudent(int id)
        {
            _studentService.DeleteStudent(id);
        }

    }
}
