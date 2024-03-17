using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class Bill
    {
        public Bill()
        {
            Orders = new HashSet<Order>();
        }

        public int BillId { get; set; }
        public int? TableId { get; set; }
        public int? NumberOfPeople { get; set; }
        public decimal? Total { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
