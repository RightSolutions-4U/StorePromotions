using System;
using System.Collections.Generic;

#nullable disable

namespace StorePromotion.Common.Models
{
    public partial class City
    {
        public int CityId { get; set; }
        public int? StateId { get; set; }
        public string CityName { get; set; }
    }
}
