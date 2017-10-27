using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace week5.Models
{
    public class Database
    {
        public string Name { get; set; }

        public int ID { get; set; }
        public DateTime JoiningDate { get; set; }
        public int Age { get; set; }

        public string address { get; set; }
        public class EmpDBContext : DbContext
        {
            public EmpDBContext()
            { }
            public DbSet<Database> Databases { get; set; }
        }
    }
}