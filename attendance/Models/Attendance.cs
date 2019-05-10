using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace attendance.Models
{
    public class Attendance
    {
        public int ID { set; get; }

        public int ScheduleId { set; get; }

        public DateTime Date { set; get; }

        public int StudentId { set; get; }

        public int State { set; get; }

        public int ClientId { set; get; }
    }
}
