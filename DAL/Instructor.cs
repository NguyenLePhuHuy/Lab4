using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table("tblInstructors")]
    public class Instructor
    {
        [Key]
        public int InstructorID { get; set; }
        public string InstructorName { get; set; }
        public int DepartmentID { get; set; }
    }
}
