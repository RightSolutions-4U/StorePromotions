using System;
using System.Collections.Generic;

#nullable disable

namespace StorePromotion.API.Models
{
    public partial class Customer
    {
        public int CustId { get; set; }
        public int StoreId { get; set; }
        public string CellNo { get; set; }
        public string CustFname { get; set; }
        public string CustLname { get; set; }
        public string Email { get; set; }
        public bool? IsActive { get; set; }
    }
}
