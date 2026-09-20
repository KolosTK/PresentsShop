using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Core.DTOs
{
    public class CartBoxDTO
    {
        //Outgoing DTO - send info to React
        public int BoxId { get; set; }
        public BoxDTO Box{ get; set; }
        public int BoxQuantity { get; set; }
    }
}
