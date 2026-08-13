using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Core.Entities
{
    public class CartBox
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int BoxId { get; set; }
        public Box Box { get; set; }
    }
}
