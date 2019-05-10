using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace attendance.Models
{
    [Table("student")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Display(Name = "学号")]
        [Required(ErrorMessage = "学号不可为空")]
        public string Code { set; get; }

        [Display(Name = "姓名")]
        [Required(ErrorMessage = "姓名不可为空")]
        public string Name { set; get; }

        public int DepartmentId { set; get; }
        
        public int ClassId { set; get; }

        [Display(Name = "性别")]
        public string Gender { set; get; }

        [Display(Name = "出生日期")]
        public DateTime BirthDate { set; get; }

        [Display(Name = "籍贯")]
        public string Native { set; get; }

        [Display(Name = "手机")]
        public string Mobile { set; get; }

        public string PhotoPath { set; get; }

        public int IsDeleted { set; get; }

        [ForeignKey("DepartmentId")]
        public virtual Department Department { set; get; }

        [ForeignKey("ClassId")]
        public virtual Class Class { set; get; }
    }
}
