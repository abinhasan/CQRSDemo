﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CQRSDemo.Models
{
    public partial class TestTable
    {
        public int? MerchantId { get; set; }
        public decimal? NetPayableAmount { get; set; }
    }
}
