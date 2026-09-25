using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Core.DTOs
{
    public class OrderBoxDTO
    {
        //Outgoing DTO - send info to React
        public int BoxId { get; set; }
        public BoxDTO BoxDTO{ get; set; }
        public int Quantity { get; set; }
        public decimal SumPerBoxSet { get; set; }
    }
}
