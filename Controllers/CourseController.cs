using Microsoft.AspNetCore.Mvc;
using StudentCourseAPI.Models;

namespace StudentCourseAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public List<Course> GetCourses()
        {
            return _courseService.GetCourses();
        }

        [HttpGet("{id}")]
        public Course GetCourseById(int id)
        {
            return _courseService.GetCourseById(id);
        }

        [HttpPost]
        public void PostCourse(Course Course)
        {
            _courseService.AddCourse(Course);
        }

        [HttpPut("{id}")]
        public IActionResult AddCourse(int id, [FromBody] Course Course)
        {
            if (Course.Id != id)
            {
                return BadRequest();
            }
            _courseService.UpdateCourse(Course);

            return Ok();
        }

        [HttpDelete("{id}")]
        public void DeleteCourse(int id)
        {
            _courseService.DeleteCourse(id);
        }

    }
}
