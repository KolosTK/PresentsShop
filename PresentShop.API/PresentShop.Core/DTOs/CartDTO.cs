using PresentShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Core.DTOs
{
    public class CartDTO
    {
        //Outgoing DTO - send info to React
        public int Id { get; set; }
        public List<CartBoxDTO> CartBox { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
