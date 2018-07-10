using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmaderAd.Models
{
    public class Newspaper
    {
        public int Id { get; set; }

        public Guid? NewsGuidId { get; set; }

        //main
        [Required]
        [Display(Name = "পত্রিকার নাম (Newspaper name)")]
        public string NewspaperName { get; set; }

        [Required]
        [Display(Name = "বিজ্ঞাপনের স্থান (Advertisement Location)")]
        public string AdLocation { get; set; }

        [Display(Name = "Price")]
        public int? PriceDescription { get; set; }

        public int? PriceDescriptionFriday { get; set; }

        public int? PriceDescriptionLow { get; set; }

        public int? PriceDescriptionLowFriday { get; set; }

        public int? PriceDescriptionBlack { get; set; }

        public int? PriceDescriptionBlackFriday { get; set; }

        [Required]
        [Display(Name = "বিজ্ঞাপনদাতার নাম (Advertiser Name)")]
        public string AdvertiserName { get; set; }


        [Display(Name = "বিজ্ঞাপনদাতার ঠিকানা (Advertiser Address)")]
        public string AdvertiserAddress { get; set; }

        [Phone]
        [Display(Name = "বিজ্ঞাপনদাতার ফোন নাম্বার (Advertiser Mobile)")]
        public string AdvertiserMobile { get; set; }

        [EmailAddress]
        [Display(Name = "বিজ্ঞাপনদাতার ইমেইল (Advertiser Email)")]
        public string AdvertiserEmail { get; set; }

        
        [Required]
        [Display(Name = "বিজ্ঞাপনটি প্রকাশের তারিখ (Date of Publication)")]
        public DateTime? DateofPublication { get; set; }

        [Display(Name = "কলাম (Column)")]
        public int? ColumnSize { get; set; }

        [Display(Name = "ইঞ্চি (Inch)")]
        public int? Inch { get; set; }

        [Display(Name = "সর্বমোট কলামইঞ্চি (Total column inch)")]
        public int? TotalColumnInch { get; set; }

        public int? MinTotalColumnInch { get; set; }
        public int? MaxTotalColumnInch { get; set; }
        public bool? MinMaxRestrictiion { get; set; }


        [Display(Name = "কলাম (Column)")]
        public string ColumnSizeFloat { get; set; }

        [Display(Name = "ইঞ্চি (Inch)")]
        public string InchFloat { get; set; }


        [Display(Name = "Total Price")]
        public int? TotalPrice { get; set; }

        [Display(Name = "আপনার বিজ্ঞাপনটি লিখুন")]
        public string Description { get; set; }

        [Display(Name = "আপনার মতামত")]
        public string Comments { get; set; }

        [Display(Name = "Word Limit")]
        public int WordLimit { get; set; }



        public int FirstWordLimitBase { get; set; }

        public int ExtraWordPrice { get; set; }

        public double VAT { get; set; }


        [ScaffoldColumn(false)]
        public string RawDbImagePath { get; set; }

        //end of main

        //ittefaq
        [ScaffoldColumn(false)]
        public List<SelectListItem> AllAdCategory { get; set; }

   
        [ScaffoldColumn(false)]
        [Display(Name = "Ad Category")]
        public string AdCategoryId { get; set; }


        [Display(Name = "Ad Category")]
        public string AdCategoryName { get; set; }
        

        [Display(Name = "Choose File")]
        [DataType(DataType.Upload)]
        public HttpPostedFileBase MainImagePath { get; set; }


        public DateTime? CreatedOnUtc { get; set; }

        public DateTime? UpdatedOnUtc { get; set; }

        //color option
        [Display(Name = "Is Color?")]
        public bool? IsColor { get; set; }

        public bool? IsColorOption { get; set; }

        // page choose

        [Display(Name = "Choose page")]
        public string GovtPageOption { get; set; }

        public bool? IsGovtPageOption { get; set; }


        public bool? Active { get; set; }
    }
}