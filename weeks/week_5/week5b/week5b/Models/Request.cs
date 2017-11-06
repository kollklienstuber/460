using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace week5b.Models
{
    public class Request
    {

        [Display(Name = "Customer Number"), Required]
        public int ID { get; set; }

        [Display(Name = "ODL"), Required]
        public int ODL { get; set; }

        [Display(Name = "Name:"), Required]
        public string PName { get; set; }

        [Display(Name = "Address:"), Required]
        public string PAddress { get; set; }

        [Display(Name = "City:"), Required]
        public string City { get; set; }

        [Display(Name = "State:"), Required]
        public string PState { get; set; }

        [Display(Name = "Zip Code:"), Required]
        public int Zip { get; set; }

        [Display(Name = "County:"), Required]
        public string County { get; set; }

        [Display(Name = "Date of birth:"), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}"), Required]
        public DateTime DOB { get; set; }

        [Display(Name = "Date:"), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}"), Required]
        public DateTime TodaysDate { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}; {ID} {ODL} {PName} {PAddress} {City} {PState} {Zip} {County} {TodaysDate} {DOB} ";
        }
    }
}