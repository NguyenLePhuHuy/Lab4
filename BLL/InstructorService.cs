using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class InstructorService
    {
        private readonly InstructorRepository _instructorRepository;

        public InstructorService()
        {
            _instructorRepository = new InstructorRepository();
        }

        // ADD
        public void Add(Instructor instructor)
        {
            _instructorRepository.AddInstructor(instructor);
        }

        // UPDATE
        public void Update(Instructor instructor)
        {
            _instructorRepository.UpdateInstructor(instructor);
        }

        // DELETE
        public void Delete(int instructorId)
        {
            _instructorRepository.DeleteInstructor(instructorId);
        }

        // REFRESH
        public List<Instructor> Refresh()
        {
            return _instructorRepository.GetAllInstructors();
        }
    }
}
