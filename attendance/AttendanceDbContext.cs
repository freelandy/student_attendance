using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using attendance.Models;

namespace attendance
{
    public class AttendanceDbContext : DbContext
    {
        public AttendanceDbContext() { }
        public AttendanceDbContext(DbContextOptions<AttendanceDbContext> options) : base(options) { }

        //添加集合
        public DbSet<Admin> Admins {get;set;}
        public DbSet<Attendance> Attendances {get;set;}
        public DbSet<Class> Classes {get;set;}
        public DbSet<Course> Courses {get;set;}
        public DbSet<Department> Departments {get;set;}
        public DbSet<LeaveApplication> LeaveApplications {get;set;}
        public DbSet<Location> Locations {get;set;}
        public DbSet<Login> Logins {get;set;}
        public DbSet<Schedule> Schedules {get;set;}
        public DbSet<Semester> Semesters {get;set;}
        public DbSet<Student> Student { get; set; }
        public DbSet<StudentClass> StudentClasses {get;set;}
        public DbSet<Teacher> Teachers {get;set;}
        public DbSet<TeacherDepartment> TeacherDepartments {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<StudentClass>()
            //    .HasKey(sc => new { sc.StudentId, sc.ClassId });

            base.OnModelCreating(modelBuilder);
        }

}
}
