using System;
using System.Collections.Generic;

#nullable disable

namespace StorePromotion.API.Models
{
    public partial class CustomerCampaign
    {
        public int? CustomerId { get; set; }
        public int? CampaignId { get; set; }
    }
}
