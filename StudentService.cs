using StudentCourseAPI.Models;

namespace StudentCourseAPI
{
    public class StudentService : IStudentService
    {
        private readonly List<Student> _students = new();

        public StudentService() { }

        public void AddStudent(Student student)
        {
            if (student is not null)
            { 
                _students.Add(student);
            }
        }

        public void DeleteStudent(int id)
        {
            var student = _students.Find(s => s.Id == id);
            if (student is not null)
            {
                _students.Remove(student);
            }
        }

        public Student GetStudentById(int id)
        {
            var student = _students.Find(s => s.Id == id);
            return student ?? new Student();
        }

        public List<Student> GetStudents()
        {
            return _students;
        }

        public void UpdateStudent(Student student)
        {
            var oldStudent = _students.Find(s => s.Id == student.Id);

            if (oldStudent is not null)
            {
                oldStudent.Name = student.Name;
                oldStudent.Age = student.Age;
                oldStudent.Email = student.Email;
            }
        }
    }
}
