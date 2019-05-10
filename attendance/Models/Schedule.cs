using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace attendance.Models
{
    public class Schedule
    {
        public int ID { set; get; }

        public int SartWeek { set; get; }

        public int EndWeek { set; get; }

        public int Day { set; get; }

        public int SemesterId { set; get; }

        public int ClassPeriod { set; get; }

        public int LocationId { set; get; }

        public int TeacherId { set; get; }

        public int ClassId { set; get; }

        public int CourseId { set; get; }
    }
}
