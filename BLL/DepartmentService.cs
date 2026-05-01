using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DepartmentService
    {
        private readonly DepartmentRepository _departmentRepository;

        public DepartmentService()
        {
            _departmentRepository = new DepartmentRepository();
        }

        // ADD
        public void Add(Department department)
        {
            _departmentRepository.AddDepartment(department);
        }

        // UPDATE
        public void Update(Department department)
        {
            _departmentRepository.UpdateDepartment(department);
        }

        // DELETE
        public void Delete(int departmentId)
        {
            _departmentRepository.DeleteDepartment(departmentId);
        }

        // REFRESH
        public List<Department> Refresh()
        {
            return _departmentRepository.GetAllDepartments();
        }
    }
}
