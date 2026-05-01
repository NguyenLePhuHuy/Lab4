using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class StudentService
    {
        private readonly StudentRepository _studentRepository;

        public StudentService()
        {
            _studentRepository = new StudentRepository();
        }

        // ADD
        public void Add(Student student)
        {
            _studentRepository.AddStudent(student);
        }

        // UPDATE
        public void Update(Student student)
        {
            _studentRepository.UpdateStudent(student);
        }

        // DELETE
        public void Delete(int studentId)
        {
            _studentRepository.DeleteStudent(studentId);
        }

        // REFRESH (Load lại dữ liệu)
        public List<Student> Refresh()
        {
            return _studentRepository.GetAllStudents();
        }
    }
}
