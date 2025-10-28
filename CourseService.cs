using StudentCourseAPI.Models;

namespace StudentCourseAPI
{
    public class CourseService : ICourseService
    {
        private readonly List<Course> _courses = new();

        public CourseService() { }

        public void AddCourse(Course course)
        {
            if (course is not null)
            {
                _courses.Add(course);
            }
        }

        public void DeleteCourse(int id)
        {
            var course = _courses.Find(c => c.Id == id);
            if (course is not null)
            {
                _courses.Remove(course);
            }
        }

        public Course GetCourseById(int id)
        {
            var course = _courses.Find(s => s.Id == id);
            return course ?? new Course();
        }

        public List<Course> GetCourses()
        {
            return _courses;
        }

        public void UpdateCourse(Course course)
        {
            var oldCourse = _courses.Find(c => c.Id == course.Id);
            if (oldCourse is not null)
            {
                oldCourse.Title = course.Title;
                oldCourse.Credits = course.Credits;
            }
        }
    }
}
