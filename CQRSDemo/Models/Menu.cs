using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CQRSDemo.Models
{
    public partial class Menu
    {
        public int MenuId { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public int? ParentId { get; set; }
        public int? Ranking { get; set; }
        public string Show { get; set; }
        public string Url { get; set; }
    }
}
