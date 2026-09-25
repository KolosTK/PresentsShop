using System;
using System.Collections.Generic;
using System.Text;
using PresentShop.Core.Enums;

namespace PresentShop.Core.Entities
{
    public class OrderBox
    {
        public int OrderId { get; set; }
        public Order Order{ get; set; }
        public int BoxId { get; set; }
        public Box Box { get; set; }
        public decimal FixedOrderPrice { get; set; }
        public int Quantity { get; set; }
    }
}
