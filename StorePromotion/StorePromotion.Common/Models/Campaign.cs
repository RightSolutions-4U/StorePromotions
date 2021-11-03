using System;
using System.Collections.Generic;

#nullable disable

namespace StorePromotion.Common.Models
{
    public partial class Campaign
    {
        public int CampaignId { get; set; }
        public int StoreId { get; set; }
        public string Message { get; set; }
        public DateTime? Cdate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? SentDate { get; set; }
    }
}
