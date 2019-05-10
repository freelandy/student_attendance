using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace attendance.Models
{
    public class LeaveApplication
    {
        public int ID { set; get; }

        public int ScheduleId { set; get; }

        public int StudentId { set; get; }

        public DateTime ApplyDate { set; get; }

        public DateTime LeaveDate { set; get; }

        public string Reason { set; get; }

        public int IsApproved { set; get; }
    }
}
