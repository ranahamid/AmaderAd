using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AmaderAd.Models
{
    public class Newspaper
    {
        public int Id { get; set; }

        public Guid? NewsGuidId { get; set; }

        //main
        [Required]
        [Display(Name = "Newspaper Name")]
        public string NewspaperName { get; set; }

        [Required]
        [Display(Name = "Advertisement Location")]
        public string AdLocation { get; set; }
        
        public int? Price { get; set; }

        [Required]
        [Display(Name = "Advertiser Name")]
        public string AdvertiserName { get; set; }


        [Display(Name = "Advertiser Address")]
        public string AdvertiserAddress { get; set; }


        [Display(Name = "Advertiser Mobile")]
        public string AdvertiserMobile { get; set; }

        [Display(Name = "Advertiser Email")]
        public string AdvertiserEmail { get; set; }

        [Required]
        [Display(Name = "Date of Publication")]
        public DateTime? DateofPublication { get; set; }

        [Display(Name = "Column")]
        public int? ColumnSize { get; set; }

        public int? Inch { get; set; }

        [Display(Name = "Total Column Inch")]
        public int? TotalColumnInch { get; set; }

        [Display(Name = "Total Price")]
        public int? TotalPrice { get; set; }

        public string Description { get; set; }

        [Display(Name = "Choose File")]
        public string MainImagePath { get; set; }

        public string RawDbImagePath { get; set; }

        //end of main

        public DateTime? CreatedOnUtc { get; set; }

        public DateTime? UpdatedOnUtc { get; set; }

        public bool? Active { get; set; }
    }
}