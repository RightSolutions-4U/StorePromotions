using System;
using System.Collections.Generic;

#nullable disable

namespace StorePromotion.Common.Models
{
    public partial class Store
    {
        public int StoreId { get; set; }
        public int OwnerId { get; set; }
        public string StName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int? CityId { get; set; }
        public string StateId { get; set; }
        public bool? IsActive { get; set; }
        public string Qrurl { get; set; }
        public string MessageText { get; set; }
    }
}
