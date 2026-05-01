using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InstructorRepository
    {
        private readonly SchoolDbContext _context;

        public InstructorRepository()
        {
            _context = new SchoolDbContext();
        }

        // Add
        public void AddInstructor(Instructor instructor)
        {
            _context.Instructors.Add(instructor);
            _context.SaveChanges();
        }

        // Get by ID
        public Instructor GetInstructorById(int id)
        {
            return _context.Instructors
                           .FirstOrDefault(i => i.InstructorID == id);
        }

        // Get all
        public List<Instructor> GetAllInstructors()
        {
            return _context.Instructors.ToList();
        }

        // Update
        public void UpdateInstructor(Instructor instructor)
        {
            var existingInstructor = _context.Instructors
                .FirstOrDefault(i => i.InstructorID == instructor.InstructorID);

            if (existingInstructor != null)
            {
                existingInstructor.InstructorName = instructor.InstructorName;
                existingInstructor.DepartmentID = instructor.DepartmentID;

                _context.SaveChanges();
            }
        }

        // Delete
        public void DeleteInstructor(int id)
        {
            var instructor = _context.Instructors
                .FirstOrDefault(i => i.InstructorID == id);

            if (instructor != null)
            {
                _context.Instructors.Remove(instructor);
                _context.SaveChanges();
            }
        }
    }
}
