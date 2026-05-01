using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CourseRepository
    {
        private readonly SchoolDbContext _context;

        public CourseRepository()
        {
            _context = new SchoolDbContext();
        }

        // Add
        public void AddCourse(Courses course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        // Get by ID
        public Courses GetCourseById(int id)
        {
            return _context.Courses
                           .FirstOrDefault(c => c.CourseID == id);
        }

        // Get all
        public List<Courses> GetAllCourses()
        {
            return _context.Courses.ToList();
        }

        // Update
        public void UpdateCourse(Courses course)
        {
            var existingCourse = _context.Courses
                .FirstOrDefault(c => c.CourseID == course.CourseID);

            if (existingCourse != null)
            {
                existingCourse.CourseName = course.CourseName;
                existingCourse.Credits = course.Credits;
                existingCourse.DepartmentID = course.DepartmentID;
                existingCourse.InstructorID = course.InstructorID;

                _context.SaveChanges();
            }
        }

        // Delete
        public void DeleteCourse(int id)
        {
            var course = _context.Courses
                .FirstOrDefault(c => c.CourseID == id);

            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
        }
    }
}
