using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Core.Entities
{
    public class OrderBox
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order{ get; set; }
        public int BoxId { get; set; }
        public Box Box { get; set; }
        public decimal FixedOrderPrice{ get; set; }
        public decimal Quantity { get; set; }
    }
}
