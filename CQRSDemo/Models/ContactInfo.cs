using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CQRSDemo.Models
{
    public partial class ContactInfo
    {
        public int ContactInfoId { get; set; }
        public string HeaderMobile { get; set; }
        public string HeaderEmail { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Linkedin { get; set; }
        public string FooterEmail { get; set; }
        public string FooterMobileOne { get; set; }
        public string FooterMobileTwo { get; set; }
        public string FooterAddress { get; set; }
        public string FooterWebUrl { get; set; }
    }
}
