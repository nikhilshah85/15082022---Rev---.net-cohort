using System;
using System.Collections.Generic;

namespace shoppingAPP.Models.EF
{
    public partial class Cart
    {
        public string? ItemName { get; set; }
        public decimal? Cost { get; set; }

        public virtual Item? ItemNameNavigation { get; set; }
    }
}
