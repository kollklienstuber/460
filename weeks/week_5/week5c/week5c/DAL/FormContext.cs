using week5c.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;
using System.Web;

namespace week5c.DAL
{
    public class FormContext : DbContext
    {
        public FormContext() : base("name=OurDBContext")
        { }

        public virtual DbSet<Form> Forms { get; set; }
    }
}
