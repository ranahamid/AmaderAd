using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AmaderAd.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public Newspaper Newspaper { get; set; }
        public List<OrderPaymentMethod> PaymentMethods { get; set; }
        public string PaymentMethodName { get; set; }

        public  int OrderId { get; set; }
        public string PaymentChannel { get; set; }

        [Display(Name = "Transaction Mobile")]
        public string PaymentMobile { get; set; }

        [Display(Name = "Transaction Id")]
        public string PaymentTrxId { get; set; }

        [Display(Name = "Transaction Amount")]
        public string PaymentAmount { get; set; }

    }

    public class OrderPaymentMethod
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Instructions { get; set; }

        public string InstructionsImageUrl { get; set; }

        public string RawDbImagePath { get; set; }

        public bool? Published { get; set; }
    }

    public class OrderPaymentStatus
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [ScaffoldColumn(false)]
        public bool? DefaultStatus { get; set; }
    }

}