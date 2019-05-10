using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace attendance.Models
{
    public class Location
    {
        public int ID { set; get; }

        public string Name { set; get; }

        public int Capacity { set; get; }

        public string Type { set; get; }

        public int IsDeleted { set; get; }
    }
}
