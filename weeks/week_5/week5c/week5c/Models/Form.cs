using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace week5c.Models
{
    public class Form
    {
        public int ID { get; set; }

        [Required, StringLength(64)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, StringLength(64)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Required, StringLength(128)]
        [Display(Name = "Address")]
        public string NewAddress { get; set; }



        [Display(Name = "DOB")]
        public DateTime DOB { get; set; }

        [Required, StringLength(128)]
        [Display(Name = "City")]
        public string City { get; set; }


        [Display(Name = "County")]
        public string County { get; set; }


        [Required, StringLength(64)]
        [Display(Name = "State")]
        public string NewState { get; set; }


        [Display(Name = "Zip")]
        public int Zip { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}: {FirstName} {LastName} DOB = {DOB} {NewAddress} {City} {NewState} Zip = {Zip}";
        }
    }
}