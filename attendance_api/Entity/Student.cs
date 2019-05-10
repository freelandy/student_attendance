using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace attendance_api.Entity
{
    public class Student
    {

        [Key]
        public int ID { set; get; }

        public string Code { set; get; }

        public int DepartmentId { set; get; }

        public int ClassId { set; get; }

        public string Gender { set; get; }

        public DateTime BirthDate { set; get; }

        public string Native { set; get; }

        public string Mobile { set; get; }

        public string PhotoPath { set; get; }

        public int IsDeleted { set; get; }
    }
}
