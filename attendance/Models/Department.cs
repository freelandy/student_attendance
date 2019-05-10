using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace attendance.Models
{
    public class Department
    {
        [Key]
        public int ID { set; get; }

        public string Code { set; get; }

        public string Name { set; get; }

        public int IsDeleted { set; get; }
    }
}
