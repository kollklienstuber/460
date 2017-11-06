using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using week5b.Models;
using System.Data.Entity;



namespace week5b.DAL
{
    public class FormContext : DbContext
    {
        public FormContext() : base("name=FormContext")
        { }

        public virtual DbSet<Request> Requests { get; set; }

    }
}