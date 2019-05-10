using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace attendance.Models
{
    public class TeacherDepartment
    {
        public int ID { set; get; }

        public int TeacherId { set; get; }

        public int DepartmentId { set; get; }
    }
}
