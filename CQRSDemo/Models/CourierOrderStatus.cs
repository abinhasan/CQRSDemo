using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CQRSDemo.Models
{
    public partial class CourierOrderStatus
    {
        public int StatusId { get; set; }
        public string StatusNameEng { get; set; }
        public string StatusNameBng { get; set; }
        public string StatusGroup { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? PostedOn { get; set; }
        public string FulfillmentStatusGroup { get; set; }
        public string OrderTrackStatusGroup { get; set; }
        public string StatusType { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
        public string CustomerMessage { get; set; }
        public string CustomerEmail { get; set; }
        public string OrderTrackStatusPublicGroup { get; set; }
        public string DashboardStatusGroup { get; set; }
    }
}
