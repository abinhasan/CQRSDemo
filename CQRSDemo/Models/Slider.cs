using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CQRSDemo.Models
{
    public partial class Slider
    {
        public int SliderId { get; set; }
        public string ButtonName { get; set; }
        public string TextName1 { get; set; }
        public string TextName2 { get; set; }
        public string Link { get; set; }
        public bool? IsActive { get; set; }
    }
}
