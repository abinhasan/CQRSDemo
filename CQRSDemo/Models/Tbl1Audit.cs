using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CQRSDemo.Models
{
    public partial class Tbl1Audit
    {
        public int Id { get; set; }
        public int? Val1 { get; set; }
        public int? Val2 { get; set; }
        public string Ins { get; set; }
        public int? Val11 { get; set; }
        public int? Val22 { get; set; }
    }
}
