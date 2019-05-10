using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace attendance.Models
{
    public class Login
    {
        public int ID { set; get; }

        public int UserId { set; get; }

        public string Password { set; get; }

        public int LoginType { set; get; }

        public DateTime LastLoginTime { set; get; }

        public string ClientIP { set; get; }

        public int IsDeleted { set; get; }


    }
}
