using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CQRSDemo.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public int? SubSubCategoryId { get; set; }
        public string Sku { get; set; }
        public string ProductDescription { get; set; }
        public decimal? Discount { get; set; }
        public decimal? UnitPrice { get; set; }
        public string UnitSize { get; set; }
        public int? QuantityPerUnit { get; set; }
        public decimal? Msrp { get; set; }
        public decimal? UnitWeight { get; set; }
        public int? UnitsInStock { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDiscount { get; set; }
        public int? SupplierId { get; set; }
        public string ShortDescription { get; set; }
        public string Show { get; set; }
        public int? MenuId { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
