using StudentCourseAPI.Models;
using System;

namespace StudentCourseAPI
{
    public interface IStudentService
    {
        Student GetStudentById(int id);

        List<Student> GetStudents();

        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
    }
}
