using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace week7.Models
{
    public partial class GifDBContext : DBContext
    {

        public GifDBContext()
            : base("name=GifDBContext")
        {
        }
        public virtual DbSet<gifLogs> GifLogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            modelBuilder.Entity<gifLogs>()
                .Property(e => e.qAgent)
                .IsUnicode(false);

            modelBuilder.Entity<gifLogs>()
                .Property(e => e.gifQuery)
                .IsUnicode(false);
        }
    }

}
}