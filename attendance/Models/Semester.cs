using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace attendance.Models
{
    public class Semester
    {
        public int ID { set; get; }

        public string Code { set; get; }

        public string Name { set; get; }

        public DateTime StartDate { set; get; }

        public int Weeks { set; get; }
    }
}
