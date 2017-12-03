using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace hw8.Models
{
    public class dateCheck : ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            return value != null && (DateTime)value < DateTime.Now;
        }
    }
}