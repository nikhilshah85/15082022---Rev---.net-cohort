using System;
using System.Collections.Generic;

namespace shoppingAPP.Models.EF
{
    public partial class User
    {
        public string? Username { get; set; }
        public string Password { get; set; } = null!;
        public int UserNo { get; set; }
    }
}
