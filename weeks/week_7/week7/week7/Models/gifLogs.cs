using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace week7.Models
{
    public class gifLogs
    {
            [Key]
            public int ID { get; set; }

            public DateTime QTime { get; set; }

            [StringLength(64)]
            public string QAgent { get; set; }

            [StringLength(64)]
            public string gifQuery { get; set; }

    }
}