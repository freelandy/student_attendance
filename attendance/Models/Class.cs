using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace attendance.Models
{
    public class Class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public string Code { set; get; }

        public string Name { set; get; }

        public int DepartmentId { set; get; }

        public int IsDeleted { set; get; }

        [ForeignKey("DepartmentId")]
        public virtual Department Department { set; get; }
    }
}
