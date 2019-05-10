using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using attendance_api.Entity;

namespace attendance_api.Repository
{
    public class StudentRepository:RepositoryBase<Student>
    {
        private readonly AttendanceDbContext dbContext;

        public StudentRepository(AttendanceDbContext dbContext):base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
