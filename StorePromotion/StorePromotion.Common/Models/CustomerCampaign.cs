using System;
using System.Collections.Generic;

#nullable disable

namespace StorePromotion.Common.Models
{
    public partial class CustomerCampaign
    {
        public int? RecId { get; set; }
        public int? CustomerId { get; set; }
        public int? CampaignId { get; set; }

/*        public virtual Customer Customer { get; set; }
        public virtual Campaign Campain { get; set; }
*/
    }
}
