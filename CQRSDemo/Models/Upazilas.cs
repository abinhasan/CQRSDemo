using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CQRSDemo.Models
{
    public partial class Upazilas
    {
        public int UpazilaId { get; set; }
        public int? DistrictId { get; set; }
        public string Name { get; set; }
        public string BnName { get; set; }
        public string Url { get; set; }
        public bool? IsActive { get; set; }
    }
}
