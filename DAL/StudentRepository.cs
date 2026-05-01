using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentRepository
    {
        private readonly SchoolDbContext _context;
        public StudentRepository()
        {
            _context = new SchoolDbContext();
        }
        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        // Get by ID
        public Student GetStudentById(int id)
        {
            return _context.Students
                           .FirstOrDefault(s => s.StudentID == id);
        }

        // Get all
        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        // Update
        public void UpdateStudent(Student student)
        {
            var existingStudent = _context.Students
                .FirstOrDefault(s => s.StudentID == student.StudentID);

            if (existingStudent != null)
            {
                existingStudent.StudentName = student.StudentName;
                existingStudent.DateOfBirth = student.DateOfBirth;
                existingStudent.City = student.City;
                existingStudent.Age = student.Age;
                existingStudent.YearOfEnroll = student.YearOfEnroll;
                existingStudent.Major = student.Major;
                existingStudent.GPA = student.GPA;

                _context.SaveChanges();
            }
        }

        // Delete
        public void DeleteStudent(int id)
        {
            var student = _context.Students
                .FirstOrDefault(s => s.StudentID == id);

            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }

        }

    }
}
