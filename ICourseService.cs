using StudentCourseAPI.Models;
using System;

namespace StudentCourseAPI
{
    public interface ICourseService
    {
        Course GetCourseById(int id);

        List<Course> GetCourses();

        void AddCourse(Course course);
        void UpdateCourse(Course course);
        void DeleteCourse(int id);
    }
}
