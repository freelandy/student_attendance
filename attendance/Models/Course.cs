using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace attendance.Models
{
    public class Course
    {
        public int ID { set; get; }

        public string Code { set; get; }

        public string Name { set; get; }

        public string Category { set; get; }

        public int TotalHours { set; get; }

        public float Credit { set; get; }

        public int Semester { set; get; }

        public string AssessmentMethod { set; get; }

        public int IsDeleted { set; get; }
    }
}
