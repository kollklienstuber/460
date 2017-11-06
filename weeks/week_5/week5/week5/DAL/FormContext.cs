using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using week5.Models;
using System.Data.Entity;

namespace week5.DAL
{
    public class FormContext : DbContext
    {
        public DbSet<Form> Forms { get; set; }

    }
}