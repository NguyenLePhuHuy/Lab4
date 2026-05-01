using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class CourseService
    {
        private readonly CourseRepository _courseRepository;

        public CourseService()
        {
            _courseRepository = new CourseRepository();
        }

        // ADD
        public void Add(Courses course)
        {
            _courseRepository.AddCourse(course);
        }

        // UPDATE
        public void Update(Courses course)
        {
            _courseRepository.UpdateCourse(course);
        }

        // DELETE
        public void Delete(int courseId)
        {
            _courseRepository.DeleteCourse(courseId);
        }

        // REFRESH
        public List<Courses> Refresh()
        {
            return _courseRepository.GetAllCourses();
        }
    }
}
