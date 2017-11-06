using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace week5.Models
{
    public class Form
    {



        /*
		 ODL / PERMIT / ID / CUSTOMER NUMBER
		 DOB
		 name
		 Address
		 city
         state
         zip
		 County
		 Date
         */

        public int ID { get; set; }

        [Display(Name = "ODL / PERMIT / ID / CUSTOMER NUMBER:"), Required]
        public int ODL { get; set; }

        [Display(Name = "Name:"), Required]
        public string Name { get; set; }

        [Display(Name = "Address:"), Required]
        public string Address { get; set; }

        [Display(Name = "City:"), Required]
        public string City { get; set; }

        [Display(Name = "State:"), Required]
        public string State {get; set;}

        [Display(Name = "Zip Code:"), Required]
        public int Zip {get; set;}

        [Display(Name = "County:"), Required]
        public string County {get; set;}

        [Display(Name = "Date:"), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}"), Required]
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}; {ODL} {Name} {Address} {City} {State} {Zip} {County} {Date} ";
        }
    }
}