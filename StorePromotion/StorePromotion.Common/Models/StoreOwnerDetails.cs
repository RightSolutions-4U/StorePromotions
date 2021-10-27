using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StorePromotion.Common.Models
{
    public class StoreOwnerDetails
    {
        [Key]
        public int StoreOwnerId { get; set; }
        public IEnumerable<Store> Store { get; set; }
    }
}
