using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CQRSDemo.Models
{
    public partial class CourierUsers
    {
        public int CourierUserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public decimal? SmsCharge { get; set; }
        public decimal? MailCharge { get; set; }
        public decimal? ReturnCharge { get; set; }
        public decimal? CollectionCharge { get; set; }
        public bool? IsSms { get; set; }
        public bool? IsEmail { get; set; }
        public string EmailAddress { get; set; }
        public string BkashNumber { get; set; }
        public string AlterMobile { get; set; }
        public string SourceType { get; set; }
        public int? RetentionUserId { get; set; }
        public int? AcquisitionUserId { get; set; }
        public DateTime? JoinDate { get; set; }
        public bool? IsDocument { get; set; }
        public string Remarks { get; set; }
        public string CompanyName { get; set; }
        public bool? IsCustomerSms { get; set; }
        public bool? IsCustomerEmail { get; set; }
        public decimal? MaxCodCharge { get; set; }
        public string Refreshtoken { get; set; }
        public bool? IsAutoProcess { get; set; }
    }
}
