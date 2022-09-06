using System;
using System.Collections.Generic;

namespace shoppingAPP.Models.EF
{
    public partial class Item
    {
        public string ItemName { get; set; } = null!;
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
        public string? Description { get; set; }
    }
}
