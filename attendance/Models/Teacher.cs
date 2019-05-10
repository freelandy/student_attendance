using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace attendance.Models
{
    public class Teacher
    {
        public int ID { set; get; }

        public string Code { set; get; }

        public string Name { set; get; }

        public string ProfessionalTitle { set; get; }

        public string Gender { set; get; }

        public DateTime BirthDate { set; get; }

        public string Mobile { set; get; }

        public string Major { set; get; }

        public int DepartmentId { set; get; }

        public int IsDeleted { set; get; }
    }
}
