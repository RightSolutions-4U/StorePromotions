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
        public string UserId { get; set; }
        public string Pwd { get; set; }
        public bool? IsActive { get; set; }
    }
}
