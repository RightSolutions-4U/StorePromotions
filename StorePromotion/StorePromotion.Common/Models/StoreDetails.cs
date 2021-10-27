using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StorePromotion.Common.Models
{
    public class StoreDetails
    {
        [Key]
        public int StoreId { get; set; }
        public IEnumerable<Customer> Customer { get; set; }
        public IEnumerable<Campaign> Campaign { get; set; }
    }
}
