using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CQRSDemo.Models
{
    public partial class Districts
    {
        public int DistrictId { get; set; }
        public int? DivisionId { get; set; }
        public string Name { get; set; }
        public string BnName { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string Url { get; set; }
        public bool? IsActive { get; set; }
    }
}
