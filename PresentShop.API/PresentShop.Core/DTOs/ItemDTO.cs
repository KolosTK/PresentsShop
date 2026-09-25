using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Core.DTOs
{
    public class ItemDTO
    {
        //Outgoing DTO - send info to React
        public int Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; } = 1;
        public double Width { get; set; } = 1;
        public double Height { get; set; } = 1;
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
        public string ImageURL { get; set; }
        public BoxItemDTO BoxItemDTO { get; set; }
    }
}
