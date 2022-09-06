using System;
using System.Collections.Generic;

namespace shoppingAPP.Models.EF
{
    public partial class Traininginfo
    {
        public int TId { get; set; }
        public string? MyName { get; set; }
        public string? MyFavTechSoFar { get; set; }
        public int? MyFeedback { get; set; }
        public string? MyComments { get; set; }
    }
}
