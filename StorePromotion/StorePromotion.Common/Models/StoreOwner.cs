using System;
using System.Collections.Generic;

#nullable disable

namespace StorePromotion.Common.Models
{
    public partial class StoreOwner
    {
        public int OwnerId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string CellNo { get; set; }
        public string Email { get; set; }
        public bool? IsActive { get; set; }
    }
}
