using System;
using System.Collections.Generic;

namespace myShoppingAPI.Model.EF
{
    public partial class Customer
    {
        public int CId { get; set; }
        public string? CName { get; set; }
        public string? CType { get; set; }
        public string? CEmail { get; set; }
        public int? CWalletBalance { get; set; }
        public bool? CIsActive { get; set; }
    }
}
