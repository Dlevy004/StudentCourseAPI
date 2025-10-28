using StudentCourseAPI.Models;
using System;

namespace StudentCourseAPI
{
    public interface IStudentService
    {
        Student GetStudentById(int id);

        Student GetStudentByName(string name);

        List<Student> GetStudents();

        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);

        int PrintAverageAge();
    }
}
