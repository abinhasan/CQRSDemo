using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CQRSDemo.Models
{
    public partial class CourierOrders
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Mobile { get; set; }
        public string OtherMobile { get; set; }
        public string Address { get; set; }
        public int? DistrictId { get; set; }
        public int? ThanaId { get; set; }
        public int? AreaId { get; set; }
        public string CourierOrdersId { get; set; }
        public string PaymentType { get; set; }
        public string OrderType { get; set; }
        public string Weight { get; set; }
        public string CollectionName { get; set; }
        public decimal? CollectionAmount { get; set; }
        public decimal? DeliveryCharge { get; set; }
        public bool? IsActive { get; set; }
        public int? Status { get; set; }
        public DateTime? PostedOn { get; set; }
        public int? PostedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string PodNumber { get; set; }
        public int? MerchantId { get; set; }
        public string Comment { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public decimal? BreakableCharge { get; set; }
        public string ThirdPartyCourierInfo { get; set; }
        public string IsConfirmedBy { get; set; }
        public string Note { get; set; }
        public decimal? CodCharge { get; set; }
        public int? CourierId { get; set; }
        public decimal? CollectionCharge { get; set; }
        public decimal? ReturnCharge { get; set; }
        public string PackagingName { get; set; }
        public decimal? PackagingCharge { get; set; }
        public string CollectAddress { get; set; }
        public bool? IsDownloaded { get; set; }
        public string HubName { get; set; }
        public string OrderFrom { get; set; }
        public decimal? CourierCharge { get; set; }
        public bool? IsOpenBox { get; set; }
        public bool? IsAutoProcess { get; set; }
        public bool? IsTakaCollectionFromCourier { get; set; }
    }
}
