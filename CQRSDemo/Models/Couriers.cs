using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CQRSDemo.Models
{
    public partial class Couriers
    {
        public int CourierId { get; set; }
        public string CourierName { get; set; }
        public string ContactNo { get; set; }
        public string ContactAddress { get; set; }
        public int? DeliveryChargeInDhaka { get; set; }
        public int? DeliveryChargeOutDhaka { get; set; }
        public int? DeliveryPeriferiCharge { get; set; }
        public int? ReturnChargeInDhaka { get; set; }
        public int? ReturnChargeOutDhaka { get; set; }
        public int? ReturnPeriferiCharge { get; set; }
        public int? CodchargeInDhaka { get; set; }
        public int? CodchargeOutDhaka { get; set; }
        public int? CodperiferiCharge { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? PostedOn { get; set; }
        public DateTime? LastPullDate { get; set; }
        public bool? IsProvidePod { get; set; }
        public int? PostedBy { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
