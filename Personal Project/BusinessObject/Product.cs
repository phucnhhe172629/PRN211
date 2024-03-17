using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public decimal Price { get; set; }
        public int? CategoryId { get; set; }
        public string? Image { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
